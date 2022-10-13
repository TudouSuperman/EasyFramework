//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using System.Collections.Generic;
using EasyFramework.EasyCommon;
using EasyFramework.EasyReference;

namespace EasyFramework.EasyStateMachine
{
    /// <summary>
    /// Easy Framework 下推状态机。
    /// </summary>
    internal sealed partial class EasyPushDownStateMachine<TEasyPushDownStateMachineOwner>
    {
        /// <summary>
        /// 获取下推状态机持有者。
        /// </summary>
        public TEasyPushDownStateMachineOwner PushDownStateMachineOwner => m_PushDownStateMachineOwner;

        /// <summary>
        /// 获取下推状态机当前临时位状态。
        /// </summary>
        public EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner> PushDownStateMachineCurrentState => m_PushDownStateMachineCurrentState;

        /// <summary>
        /// 获取状态机持有者类型。
        /// </summary>
        public Type StateMachineOwnerType => typeof(TEasyPushDownStateMachineOwner);

        /// <summary>
        /// 获取当前临时位状态机状态名称。
        /// </summary>
        public String CurrentStateMachineStateName => m_PushDownStateMachineCurrentState.GetType().FullName;

        /// <summary>
        /// 获取状态机中状态的数量。
        /// </summary>
        public Int32 StateMachineStateCount => m_PushDownStateMachineStates.Count;

        /// <summary>
        /// 获取状态机中栈区状态的数量。
        /// </summary>
        public Int32 StateMachineStackStateCount => m_PushDownStateMachineStack.Count;

        /// <summary>
        /// 获取状态机是否正在运行。
        /// </summary>
        public override Boolean IsRunning => m_PushDownStateMachineCurrentState != null;

        /// <summary>
        /// 获取状态机是否被清理。
        /// </summary>
        public override Boolean IsCleared => m_IsCleared;

        /// <summary>
        /// 创建下推状态机。
        /// </summary>
        /// <param name="pushDownStateMachineOwner">下推状态机持有者。</param>
        /// <param name="pushDownStateMachineStates">下推状态机状态集合。</param>
        /// <returns>创建的下推状态机。</returns>
        public static EasyPushDownStateMachine<TEasyPushDownStateMachineOwner> CreatePushDownStateMachine(TEasyPushDownStateMachineOwner pushDownStateMachineOwner, HashSet<EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>> pushDownStateMachineStates)
        {
            if (pushDownStateMachineOwner == null)
            {
                throw new EasyFrameworkException("类型为空的下推状态机持有者是无效的。");
            }

            if (pushDownStateMachineStates == null || pushDownStateMachineStates.Count < 1)
            {
                throw new EasyFrameworkException("类型为空的下推状态机状态集合是无效的。");
            }

            EasyPushDownStateMachine<TEasyPushDownStateMachineOwner> tempPushDownStateMachine = EasyReferencePool.AcquireReference<EasyPushDownStateMachine<TEasyPushDownStateMachineOwner>>();
            tempPushDownStateMachine.m_PushDownStateMachineOwner = pushDownStateMachineOwner;
            tempPushDownStateMachine.m_IsCleared = false;
            foreach (EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner> pushDownStateMachineStateItem in pushDownStateMachineStates)
            {
                if (pushDownStateMachineStateItem == null)
                {
                    throw new EasyFrameworkException("类型为空的下推状态机状态是无效的。");
                }

                tempPushDownStateMachine.m_PushDownStateMachineStates.Add(pushDownStateMachineStateItem.GetType(), pushDownStateMachineStateItem);
            }

            return tempPushDownStateMachine;
        }

        /// <summary>
        /// 启动下推状态机。
        /// </summary>
        /// <typeparam name="TEasyPushDownStateMachineOwnerState">要启动的下推状态机持有者状态类型。</typeparam>
        public void StartPushDownStateMachineState<TEasyPushDownStateMachineOwnerState>() where TEasyPushDownStateMachineOwnerState : EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>
        {
            if (IsRunning)
            {
                throw new EasyFrameworkException("当前下推状态机正在运行无法再次启动。");
            }

            EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner> tempPushDownStateMachineState = GetPushDownStateMachineState<TEasyPushDownStateMachineOwnerState>() ?? throw new EasyFrameworkException("不存在的要启动的下推状态机状态是无效的。");
            m_PushDownStateMachineCurrentState = tempPushDownStateMachineState;
            m_PushDownStateMachineCurrentState.OnEnterState(this);
        }

        /// <summary>
        /// 检查是否存在下推状态机状态。
        /// </summary>
        /// <typeparam name="TEasyPushDownStateMachineOwnerState">要检查的下推状态机持有者状态类型。</typeparam>
        /// <returns>是否存在下推状态机状态。</returns>
        public Boolean HasPushDownStateMachineState<TEasyPushDownStateMachineOwnerState>() where TEasyPushDownStateMachineOwnerState : EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>
        {
            return m_PushDownStateMachineStates.ContainsKey(typeof(TEasyPushDownStateMachineOwnerState));
        }

        /// <summary>
        /// 获取下推状态机状态。
        /// </summary>
        /// <typeparam name="TEasyPushDownStateMachineOwnerState">要获取的下推状态机持有者状态类型。</typeparam>
        /// <returns>获取到的下推状态机状态。</returns>
        public TEasyPushDownStateMachineOwnerState GetPushDownStateMachineState<TEasyPushDownStateMachineOwnerState>() where TEasyPushDownStateMachineOwnerState : EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>
        {
            if (m_PushDownStateMachineStates.TryGetValue(typeof(TEasyPushDownStateMachineOwnerState), out EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner> pushDownStateMachineOwnerState))
            {
                return (TEasyPushDownStateMachineOwnerState) pushDownStateMachineOwnerState;
            }

            return null;
        }

        /// <summary>
        /// 获取下推状态机的所有状态。
        /// </summary>
        /// <returns>获取到的下推状态机所有状态。</returns>
        public EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>[] GetPushDownStateMachineStates()
        {
            Int32 pointer = 0;
            EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>[] tempStates = new EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>[m_PushDownStateMachineStates.Count];
            foreach (KeyValuePair<Type, EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>> stateItem in m_PushDownStateMachineStates)
            {
                tempStates[pointer++] = stateItem.Value;
            }

            return tempStates;
        }

        /// <summary>
        /// 下推下推状态机状态到栈区。
        /// </summary>
        /// <typeparam name="TEasyPushDownStateMachineOwnerState">要下推的下推状态机持有者状态类型。</typeparam>
        public void PushDownStateMachineState<TEasyPushDownStateMachineOwnerState>() where TEasyPushDownStateMachineOwnerState : EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>
        {
            if (m_PushDownStateMachineCurrentState == null)
            {
                throw new EasyFrameworkException("类型为空的当前临时位下推状态机状态是无效的。");
            }

            EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner> tempPushDownStateMachineState = GetPushDownStateMachineState<TEasyPushDownStateMachineOwnerState>();
            if (tempPushDownStateMachineState == null)
            {
                throw new EasyFrameworkException("不存在的要下推的下推状态机状态是无效的。");
            }

            if (m_PushDownStateMachineCurrentState.Equals(tempPushDownStateMachineState))
            {
                return;
            }

            if (m_PushDownStateMachineStack.Contains(m_PushDownStateMachineCurrentState))
            {
                return;
            }

            if (m_PushDownStateMachineStack.Contains(tempPushDownStateMachineState))
            {
                return;
            }

            m_PushDownStateMachineCurrentState.OnPauseState(this);
            m_PushDownStateMachineStack.Push(m_PushDownStateMachineCurrentState);
            m_PushDownStateMachineCurrentState = tempPushDownStateMachineState;
            m_PushDownStateMachineCurrentState.OnEnterState(this);
        }

        /// <summary>
        /// 弹出下推状态机状态到临时位。
        /// </summary>
        public void PopUpStateMachineState()
        {
            if (m_PushDownStateMachineCurrentState == null)
            {
                throw new EasyFrameworkException("类型为空的当前临时位下推状态机状态是无效的。");
            }

            if (m_PushDownStateMachineStack == null || m_PushDownStateMachineStack.Count <= 0)
            {
                return;
            }

            EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner> tempPopUpState = m_PushDownStateMachineStack.Pop();
            while (tempPopUpState == null && m_PushDownStateMachineStack.Count > 0)
            {
                tempPopUpState = m_PushDownStateMachineStack.Pop();
            }

            if (tempPopUpState == null)
            {
                return;
            }

            m_PushDownStateMachineCurrentState.OnLeaveState(this);
            m_PushDownStateMachineCurrentState = tempPopUpState;
            m_PushDownStateMachineCurrentState.OnResumeState(this);
        }

        /// <summary>
        /// 关闭下推状态机。
        /// </summary>
        public void ClosePushDownStateMachine()
        {
            if (m_PushDownStateMachineCurrentState == null)
            {
                m_IsCleared = true;
                return;
            }

            m_PushDownStateMachineCurrentState.OnLeaveState(this);

            while (m_PushDownStateMachineStack.Count > 0)
            {
                EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner> tempPopUpState = m_PushDownStateMachineStack.Pop();
                if (tempPopUpState == null) continue;
                tempPopUpState.OnResumeState(this);
                tempPopUpState.OnLeaveState(this);
            }

            m_PushDownStateMachineCurrentState = null;
            m_IsCleared = true;
        }
    }
}