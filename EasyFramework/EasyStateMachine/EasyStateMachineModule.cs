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
    internal sealed partial class EasyStateMachineModule : EasyFrameworkModule, IEasyModuleUpdate, IEasyStateMachineModule
    {
        private readonly IDictionary<Int32, EasyStateMachineBase> m_FiniteStateMachineModules;
        private readonly IDictionary<Int32, EasyStateMachineBase> m_PushDownStateMachineModules;
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
            m_FiniteStateMachineModules = new Dictionary<int, EasyStateMachineBase>();
            m_PushDownStateMachineModules = new Dictionary<int, EasyStateMachineBase>();
            m_TempStateMachineModules = new List<EasyStateMachineBase>();
        }

        /// <summary>
        /// 状态机模块轮询。
        /// </summary>
        /// <param name="logicTime">逻辑时间。</param>
        public void EasyModuleUpdate(Single logicTime)
        {
            m_TempStateMachineModules.Clear();

            if (m_FiniteStateMachineModules.Count >= 0)
            {
                foreach (KeyValuePair<Int32, EasyStateMachineBase> stateMachineModule in m_FiniteStateMachineModules)
                {
                    m_TempStateMachineModules.Add(stateMachineModule.Value);
                }
            }

            if (m_PushDownStateMachineModules.Count >= 0)
            {
                foreach (KeyValuePair<Int32, EasyStateMachineBase> stateMachineModule in m_PushDownStateMachineModules)
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
            foreach (KeyValuePair<Int32, EasyStateMachineBase> stateMachineModule in m_FiniteStateMachineModules)
            {
                stateMachineModule.Value.StateMachineShutdown();
            }

            foreach (KeyValuePair<Int32, EasyStateMachineBase> stateMachineModule in m_PushDownStateMachineModules)
            {
                stateMachineModule.Value.StateMachineShutdown();
            }

            m_FiniteStateMachineModules.Clear();
            m_PushDownStateMachineModules.Clear();
            m_TempStateMachineModules.Clear();
        }
    }
}