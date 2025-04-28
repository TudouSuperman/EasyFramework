//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/TudouSuperman/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using System.Collections.Generic;
using EasyFramework.EasyCommon;

namespace EasyFramework.EasyStateMachine
{
    /// <summary>
    /// Easy Framework 状态机模块。
    /// </summary>
    internal sealed partial class EasyStateMachineModule : EasyFrameworkModule, IEasyModuleUpdate, IEasyStateMachineModule
    {
        private readonly IDictionary<Int32, EasyStateMachineBase> m_FiniteStateMachineModuleDic;
        private readonly IDictionary<Int32, EasyStateMachineBase> m_PushDownStateMachineModuleDic;
        private readonly IList<EasyStateMachineBase> m_TempStateMachineModules;

        /// <summary>
        /// 引用模块优先级。
        /// </summary>
        public override EasyModulePriority Priority => EasyModulePriority.EasyStateMachineModule;

        /// <summary>
        /// 初始化状态机模块的新实例。
        /// </summary>
        public EasyStateMachineModule()
        {
            m_FiniteStateMachineModuleDic = new Dictionary<int, EasyStateMachineBase>();
            m_PushDownStateMachineModuleDic = new Dictionary<int, EasyStateMachineBase>();
            m_TempStateMachineModules = new List<EasyStateMachineBase>();
        }

        /// <summary>
        /// 状态机模块轮询。
        /// </summary>
        /// <param name="logicTime">逻辑时间。</param>
        public void EasyModuleUpdate(Single logicTime)
        {
            m_TempStateMachineModules.Clear();

            if (m_FiniteStateMachineModuleDic.Count >= 0)
            {
                foreach (KeyValuePair<Int32, EasyStateMachineBase> stateMachineModule in m_FiniteStateMachineModuleDic)
                {
                    m_TempStateMachineModules.Add(stateMachineModule.Value);
                }
            }

            if (m_PushDownStateMachineModuleDic.Count >= 0)
            {
                foreach (KeyValuePair<Int32, EasyStateMachineBase> stateMachineModule in m_PushDownStateMachineModuleDic)
                {
                    m_TempStateMachineModules.Add(stateMachineModule.Value);
                }
            }

            if (m_TempStateMachineModules.Count > 0)
            {
                foreach (EasyStateMachineBase stateMachineModule in m_TempStateMachineModules)
                {
                    if (stateMachineModule.IsCleared)
                    {
                        continue;
                    }

                    stateMachineModule.StateMachineUpdate(logicTime);
                }
            }
        }

        /// <summary>
        /// 状态机模块关闭。
        /// </summary>
        protected internal override void EasyModuleShutdown()
        {
            foreach (KeyValuePair<Int32, EasyStateMachineBase> stateMachineModule in m_FiniteStateMachineModuleDic)
            {
                stateMachineModule.Value.StateMachineShutdown();
            }

            foreach (KeyValuePair<Int32, EasyStateMachineBase> stateMachineModule in m_PushDownStateMachineModuleDic)
            {
                stateMachineModule.Value.StateMachineShutdown();
            }

            m_FiniteStateMachineModuleDic.Clear();
            m_PushDownStateMachineModuleDic.Clear();
            m_TempStateMachineModules.Clear();
        }
    }
}