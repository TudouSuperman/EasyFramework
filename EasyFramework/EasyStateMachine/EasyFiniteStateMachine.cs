//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using System.Collections.Generic;
using EasyFramework.EasyReference;

namespace EasyFramework.EasyStateMachine
{
    /// <summary>
    /// 有限状态机。
    /// </summary>
    /// <typeparam name="TEasyFiniteStateMachineOwner">有限状态机持有者类型。</typeparam>
    internal sealed partial class EasyFiniteStateMachine<TEasyFiniteStateMachineOwner> : EasyStateMachineBase, IEasyReference, IEasyFiniteStateMachine<TEasyFiniteStateMachineOwner> where TEasyFiniteStateMachineOwner : class
    {
        private TEasyFiniteStateMachineOwner m_FiniteStateMachineOwner;
        private EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner> m_FiniteStateMachineCurrentState;
        private readonly IDictionary<Type, EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>> m_FiniteStateMachineStates;
        private bool m_IsCleared;

        /// <summary>
        /// 初始化有限状态机类的新实例。
        /// </summary>
        public EasyFiniteStateMachine()
        {
            m_FiniteStateMachineOwner = null;
            m_FiniteStateMachineCurrentState = null;
            m_FiniteStateMachineStates = new Dictionary<Type, EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>>();
            m_IsCleared = true;
        }

        /// <summary>
        /// 状态机轮询。
        /// </summary>
        /// <param name="logicTime">逻辑时间。</param>
        protected internal override void StateMachineUpdate(Single logicTime)
        {
            if (m_FiniteStateMachineCurrentState == null)
            {
                return;
            }

            m_FiniteStateMachineCurrentState.OnUpdateState(this, logicTime);
        }

        /// <summary>
        /// 状态机关闭。
        /// </summary>
        protected internal override void StateMachineShutdown()
        {
            EasyReferencePool.ReleaseReference(this);
        }

        /// <summary>
        /// 清理引用。
        /// </summary>
        public void ClearReference()
        {
            if (m_FiniteStateMachineCurrentState != null)
            {
                m_FiniteStateMachineCurrentState.OnLeaveState(this);
            }

            foreach (KeyValuePair<Type, EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>> finiteStateMachineStateItem in m_FiniteStateMachineStates)
            {
                finiteStateMachineStateItem.Value.OnLeaveState(this);
            }

            m_FiniteStateMachineOwner = null;
            m_FiniteStateMachineCurrentState = null;
            m_FiniteStateMachineStates.Clear();
            m_IsCleared = true;
        }
    }
}