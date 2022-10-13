//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using System.Collections.Generic;
using EasyFramework.EasyCommon;

namespace EasyFramework.EasyStateMachine
{
    /// <summary>
    /// 状态机模块。
    /// </summary>
    internal sealed partial class EasyStateMachineModule
    {
        /// <summary>
        /// 获取所有有限状态机的数量。
        /// </summary>
        public Int32 FiniteStateMachineCount => m_FiniteStateMachineModules.Count;

        /// <summary>
        /// 获取所有下推状态机的数量。
        /// </summary>
        public Int32 PushDownStateMachineCount => m_PushDownStateMachineModules.Count;

        /// <summary>
        /// 检查是否存在有限状态机。
        /// </summary>
        /// <typeparam name="TEasyFiniteStateMachineOwner">要检查的有限状态机持有者类型。</typeparam>
        /// <returns>是否存在有限状态机。</returns>
        public Boolean HasFiniteStateMachine<TEasyFiniteStateMachineOwner>() where TEasyFiniteStateMachineOwner : class
        {
            return m_FiniteStateMachineModules.ContainsKey(typeof(TEasyFiniteStateMachineOwner).GetHashCode());
        }

        /// <summary>
        /// 检查是否存在下推状态机。
        /// </summary>
        /// <typeparam name="TEasyPushDownStateMachineOwner">要检查的下推状态机持有者类型。</typeparam>
        /// <returns>是否存在下推状态机。</returns>
        public Boolean HasPushDownStateMachine<TEasyPushDownStateMachineOwner>() where TEasyPushDownStateMachineOwner : class
        {
            return m_PushDownStateMachineModules.ContainsKey(typeof(TEasyPushDownStateMachineOwner).GetHashCode());
        }

        /// <summary>
        /// 获取有限状态机。
        /// </summary>
        /// <typeparam name="TEasyFiniteStateMachineOwner">要获取的有限状态机持有者类型。</typeparam>
        /// <returns>获取到的有限状态机。</returns>
        public IEasyFiniteStateMachine<TEasyFiniteStateMachineOwner> GetFiniteStateMachine<TEasyFiniteStateMachineOwner>() where TEasyFiniteStateMachineOwner : class
        {
            if (m_FiniteStateMachineModules.TryGetValue(typeof(TEasyFiniteStateMachineOwner).GetHashCode(), out EasyStateMachineBase stateMachineModule))
            {
                return (IEasyFiniteStateMachine<TEasyFiniteStateMachineOwner>) stateMachineModule;
            }

            return null;
        }

        /// <summary>
        /// 获取下推状态机。
        /// </summary>
        /// <typeparam name="TEasyPushDownStateMachineOwner">要获取的下推状态机持有者类型。</typeparam>
        /// <returns>获取到的下推状态机。</returns>
        public IEasyPushDownStateMachine<TEasyPushDownStateMachineOwner> GetPushDownStateMachine<TEasyPushDownStateMachineOwner>() where TEasyPushDownStateMachineOwner : class
        {
            if (m_PushDownStateMachineModules.TryGetValue(typeof(TEasyPushDownStateMachineOwner).GetHashCode(), out EasyStateMachineBase stateMachineModule))
            {
                return (IEasyPushDownStateMachine<TEasyPushDownStateMachineOwner>) stateMachineModule;
            }

            return null;
        }

        /// <summary>
        /// 创建有限状态机。
        /// </summary>
        /// <param name="finiteStateMachineOwner">有限状态机持有者。</param>
        /// <param name="finiteStateMachineStates">有限状态机状态集合。</param>
        /// <typeparam name="TEasyFiniteStateMachineOwner">要创建的有限状态机持有者类型。</typeparam>
        /// <returns>创建的有限状态机。</returns>
        public IEasyFiniteStateMachine<TEasyFiniteStateMachineOwner> CreateFiniteStateMachine<TEasyFiniteStateMachineOwner>(TEasyFiniteStateMachineOwner finiteStateMachineOwner, HashSet<EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>> finiteStateMachineStates) where TEasyFiniteStateMachineOwner : class
        {
            if (HasFiniteStateMachine<TEasyFiniteStateMachineOwner>())
            {
                throw new EasyFrameworkException($"已存在此有限状态机持有者类型的有限状态机 ：{typeof(TEasyFiniteStateMachineOwner).FullName}");
            }

            EasyFiniteStateMachine<TEasyFiniteStateMachineOwner> tempFiniteStateMachine = EasyFiniteStateMachine<TEasyFiniteStateMachineOwner>.CreateFiniteStateMachine(finiteStateMachineOwner, finiteStateMachineStates);
            m_FiniteStateMachineModules.Add(typeof(TEasyFiniteStateMachineOwner).GetHashCode(), tempFiniteStateMachine);
            return tempFiniteStateMachine;
        }

        /// <summary>
        /// 创建下推状态机。
        /// </summary>
        /// <param name="pushDownStateMachineOwner">下推状态机持有者。</param>
        /// <param name="pushDownStateMachineStates">下推状态机状态集合。</param>
        /// <typeparam name="TEasyPushDownStateMachineOwner">要创建的下推状态机持有者类型。</typeparam>
        /// <returns>创建的下推状态机。</returns>
        public IEasyPushDownStateMachine<TEasyPushDownStateMachineOwner> CreatePushDownStateMachine<TEasyPushDownStateMachineOwner>(TEasyPushDownStateMachineOwner pushDownStateMachineOwner, HashSet<EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>> pushDownStateMachineStates) where TEasyPushDownStateMachineOwner : class
        {
            if (HasPushDownStateMachine<TEasyPushDownStateMachineOwner>())
            {
                throw new EasyFrameworkException($"已存在此下推状态机持有者类型的下推状态机 ：{typeof(TEasyPushDownStateMachineOwner).FullName}");
            }

            EasyPushDownStateMachine<TEasyPushDownStateMachineOwner> tempPushDownStateMachine = EasyPushDownStateMachine<TEasyPushDownStateMachineOwner>.CreatePushDownStateMachine(pushDownStateMachineOwner, pushDownStateMachineStates);
            m_PushDownStateMachineModules.Add(typeof(TEasyPushDownStateMachineOwner).GetHashCode(), tempPushDownStateMachine);
            return tempPushDownStateMachine;
        }

        /// <summary>
        /// 销毁有限状态机。
        /// </summary>
        /// <typeparam name="TEasyFiniteStateMachineOwner">要销毁的有限状态机持有者类型。</typeparam>
        /// <returns>是否销毁有限状态机成功。</returns>
        public Boolean DestroyFiniteStateMachine<TEasyFiniteStateMachineOwner>() where TEasyFiniteStateMachineOwner : class
        {
            Int32 id = typeof(TEasyFiniteStateMachineOwner).GetHashCode();
            if (m_FiniteStateMachineModules.TryGetValue(id, out EasyStateMachineBase stateMachineModule))
            {
                stateMachineModule.StateMachineShutdown();
                return m_FiniteStateMachineModules.Remove(id);
            }

            return false;
        }

        /// <summary>
        /// 销毁下推状态机。
        /// </summary>
        /// <typeparam name="TEasyPushDownStateMachineOwner">要销毁的下推状态机持有者类型。</typeparam>
        /// <returns>是否销毁下推状态机成功。</returns>
        public Boolean DestroyPushDownStateMachine<TEasyPushDownStateMachineOwner>() where TEasyPushDownStateMachineOwner : class
        {
            Int32 id = typeof(TEasyPushDownStateMachineOwner).GetHashCode();
            if (m_PushDownStateMachineModules.TryGetValue(id, out EasyStateMachineBase stateMachineModule))
            {
                stateMachineModule.StateMachineShutdown();
                return m_PushDownStateMachineModules.Remove(id);
            }

            return false;
        }
    }
}