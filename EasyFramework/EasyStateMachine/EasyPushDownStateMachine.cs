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
    /// 下推状态机。
    /// </summary>
    /// <typeparam name="TEasyPushDownStateMachineOwner">下推状态机持有者类型。</typeparam>
    internal sealed partial class EasyPushDownStateMachine<TEasyPushDownStateMachineOwner> : EasyStateMachineBase, IEasyReference, IEasyPushDownStateMachine<TEasyPushDownStateMachineOwner> where TEasyPushDownStateMachineOwner : class
    {
        private TEasyPushDownStateMachineOwner m_PushDownStateMachineOwner;
        private EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner> m_PushDownStateMachineCurrentState;
        private readonly IDictionary<Type, EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>> m_PushDownStateMachineStates;
        private readonly Stack<EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>> m_PushDownStateMachineStack;
        private Boolean m_IsCleared;

        /// <summary>
        /// 初始化下推状态机的新实例。
        /// </summary>
        public EasyPushDownStateMachine()
        {
            m_PushDownStateMachineOwner = null;
            m_PushDownStateMachineCurrentState = null;
            m_PushDownStateMachineStates = new Dictionary<Type, EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>>();
            m_PushDownStateMachineStack = new Stack<EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>>();
            m_IsCleared = true;
        }

        /// <summary>
        /// 状态机模块轮询。
        /// </summary>
        /// <param name="logicTime">逻辑时间。</param>
        protected internal override Void StateMachineUpdate(Single logicTime)
        {
            if (m_PushDownStateMachineCurrentState == null)
            {
                return;
            }

            m_PushDownStateMachineCurrentState.OnUpdateState(this, logicTime);
        }

        /// <summary>
        /// 状态机模块关闭。
        /// </summary>
        protected internal override Void StateMachineShutdown()
        {
            EasyReferencePool.ReleaseReference(this);
        }

        /// <summary>
        /// 清理引用。
        /// </summary>
        public Void ClearReference()
        {
            m_PushDownStateMachineStack.Clear();

            if (m_PushDownStateMachineCurrentState != null)
            {
                m_PushDownStateMachineCurrentState.OnLeaveState(this);
            }

            foreach (KeyValuePair<Type, EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>> pushDownStateMachineStateItem in m_PushDownStateMachineStates)
            {
                pushDownStateMachineStateItem.Value.OnLeaveState(this);
            }

            m_PushDownStateMachineOwner = null;
            m_PushDownStateMachineCurrentState = null;
            m_PushDownStateMachineStates.Clear();
            m_IsCleared = true;
        }
    }
}