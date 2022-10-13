//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using EasyFramework.EasyCommon;
using EasyFramework.EasyStateMachine;

namespace EasyFramework.EasyProcedure
{
    /// <summary>
    /// 流程模块。
    /// </summary>
    internal sealed partial class EasyProcedureModule : EasyFrameworkModule, IEasyProcedureModule
    {
        private IEasyStateMachineModule m_StateMachineModule;
        private IEasyFiniteStateMachine<IEasyProcedureModule> m_FiniteStateMachine;

        /// <summary>
        /// 流程模块优先级。
        /// </summary>
        protected internal override Int32 Priority => 4;

        /// <summary>
        /// 初始化流程模块的新实例。
        /// </summary>
        public EasyProcedureModule()
        {
            m_StateMachineModule = null;
            m_FiniteStateMachine = null;
        }

        /// <summary>
        /// 流程模块关闭。
        /// </summary>
        protected internal override Void EasyModuleShutdown()
        {
            if (m_StateMachineModule == null)
            {
                return;
            }

            if (m_FiniteStateMachine == null)
            {
                return;
            }

            m_StateMachineModule.DestroyFiniteStateMachine<IEasyStateMachineModule>();
            m_FiniteStateMachine = null;
            m_StateMachineModule = null;
        }
    }
}