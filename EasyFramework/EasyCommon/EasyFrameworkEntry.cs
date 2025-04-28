//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/TudouSuperman/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using System.Collections.Generic;
using EasyFramework.EasyReference;

namespace EasyFramework.EasyCommon
{
    /// <summary>
    /// Easy Framework 框架入口。
    /// </summary>
    public static class EasyFrameworkEntry
    {
        private static readonly LinkedList<EasyFrameworkModule> s_ModuleLinked = new LinkedList<EasyFrameworkModule>();
        private static readonly LinkedList<IEasyModuleUpdate> s_UpdateModuleLinked = new LinkedList<IEasyModuleUpdate>();

        /// <summary>
        /// Easy Framework 框架模块轮询。
        /// </summary>
        /// <param name="logicTime">逻辑时间。</param>
        public static void EasyFrameworkUpdate(Single logicTime)
        {
            if (s_UpdateModuleLinked.Count <= 0)
            {
                return;
            }

            foreach (IEasyModuleUpdate module in s_UpdateModuleLinked)
            {
                module.EasyModuleUpdate(logicTime);
            }
        }

        /// <summary>
        /// Easy Framework 框架模块关闭。
        /// </summary>
        public static void EasyFrameworkShutdown()
        {
            s_UpdateModuleLinked.Clear();
            for (LinkedListNode<EasyFrameworkModule> current = s_ModuleLinked.Last; current != null; current = current.Previous)
            {
                current.Value.EasyModuleShutdown();
            }

            s_ModuleLinked.Clear();
            EasyReferencePool.ClearReferences();
        }

        /// <summary>
        /// 获取 Easy Framework 框架模块。
        /// </summary>
        /// <typeparam name="TEasyModule">要获取的框架模块类型。</typeparam>
        /// <returns>要获取的框架模块。</returns>
        /// <remarks>如果要获取的框架模块不存在，则自动创建该框架模块。</remarks>
        public static TEasyModule GetEasyFrameworkModule<TEasyModule>() where TEasyModule : class
        {
            Type interfaceType = typeof(TEasyModule);

            if (!interfaceType.IsInterface)
            {
                throw new EasyFrameworkException($"你必须通过接口获取模块，但 '{interfaceType.FullName}' 不是。");
            }

            if (!(string.IsNullOrEmpty(interfaceType.FullName) ? String.Empty : interfaceType.FullName).StartsWith("EasyFramework.", StringComparison.Ordinal))
            {
                throw new EasyFrameworkException($"你必须获取框架内的模块，但 '{interfaceType.FullName}' 不是。");
            }

            string moduleName = $"{interfaceType.Namespace}.{interfaceType.Name.Substring(1)}";
            Type moduleType = Type.GetType(moduleName);
            if (moduleType == null)
            {
                throw new EasyFrameworkException($"框架内找不到此模块类型 '{moduleName}' 。");
            }

            TEasyModule module = GetEasyFrameworkModule(moduleType) as TEasyModule;
            if (typeof(IEasyModuleUpdate).IsAssignableFrom(module?.GetType()))
            {
                LinkedListNode<IEasyModuleUpdate> current = s_UpdateModuleLinked.First;
                while (current != null)
                {
                    if (((IEasyModuleUpdate)module)?.Priority > current.Value.Priority)
                    {
                        break;
                    }

                    current = current.Next;
                }

                if (current != null)
                {
                    s_UpdateModuleLinked.AddBefore(current, (IEasyModuleUpdate)module);
                }
                else
                {
                    s_UpdateModuleLinked.AddLast((IEasyModuleUpdate)module);
                }
            }

            return module;
        }

        /// <summary>
        /// 获取 Easy Framework 框架模块。
        /// </summary>
        /// <param name="moduleType">要获取的框架模块类型。</param>
        /// <returns>要获取的框架模块。</returns>
        /// <remarks>如果要获取的框架模块不存在，则自动创建该框架模块。</remarks>
        private static EasyFrameworkModule GetEasyFrameworkModule(Type moduleType)
        {
            foreach (EasyFrameworkModule module in s_ModuleLinked)
            {
                if (module.GetType() == moduleType)
                {
                    return module;
                }
            }

            return CreateEasyFrameworkModule(moduleType);
        }

        /// <summary>
        /// 创建 Easy Framework 框架模块。
        /// </summary>
        /// <param name="moduleType">要创建的框架模块类型。</param>
        /// <returns>要创建的框架模块。</returns>
        private static EasyFrameworkModule CreateEasyFrameworkModule(Type moduleType)
        {
            EasyFrameworkModule module = (EasyFrameworkModule)Activator.CreateInstance(moduleType);
            if (module == null)
            {
                throw new EasyFrameworkException($"无法创建此模块 '{moduleType.FullName}' 。");
            }

            LinkedListNode<EasyFrameworkModule> current = s_ModuleLinked.First;
            while (current != null)
            {
                if (module.Priority > current.Value.Priority)
                {
                    break;
                }

                current = current.Next;
            }

            if (current != null)
            {
                s_ModuleLinked.AddBefore(current, module);
            }
            else
            {
                s_ModuleLinked.AddLast(module);
            }

            return module;
        }
    }
}