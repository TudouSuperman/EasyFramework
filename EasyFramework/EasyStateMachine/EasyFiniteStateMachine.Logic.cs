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
    /// 有限状态机。
    /// </summary>
    /// <typeparam name="TEasyFiniteStateMachineOwner">有限状态机持有者类型。</typeparam>
    internal sealed partial class EasyFiniteStateMachine<TEasyFiniteStateMachineOwner>
    {
        /// <summary>
        /// 获取有限状态机持有者。
        /// </summary>
        public TEasyFiniteStateMachineOwner FiniteStateMachineOwner => m_FiniteStateMachineOwner;

        /// <summary>
        /// 获取有限状态机当前状态。
        /// </summary>
        public EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner> FiniteStateMachineCurrentState => m_FiniteStateMachineCurrentState;

        /// <summary>
        /// 获取状态机持有者类型。
        /// </summary>
        public Type StateMachineOwnerType => typeof(TEasyFiniteStateMachineOwner);

        /// <summary>
        /// 获取当前状态机状态名称。
        /// </summary>
        public String CurrentStateMachineStateName => m_FiniteStateMachineCurrentState.GetType().FullName;

        /// <summary>
        /// 获取状态机中状态的数量。
        /// </summary>
        public Int32 StateMachineStateCount => m_FiniteStateMachineStates.Count;

        /// <summary>
        /// 获取状态机是否正在运行。
        /// </summary>
        public override Boolean IsRunning => m_FiniteStateMachineCurrentState != null;

        /// <summary>
        /// 获取状态机是否被清理。
        /// </summary>
        public override Boolean IsCleared => m_IsCleared;

        /// <summary>
        /// 创建有限状态机。
        /// </summary>
        /// <param name="finiteStateMachineOwner">有限状态机持有者。</param>
        /// <param name="finiteStateMachineStates">有限状态机状态集合。</param>
        /// <returns>创建的有限状态机。</returns>
        public static EasyFiniteStateMachine<TEasyFiniteStateMachineOwner> CreateFiniteStateMachine(TEasyFiniteStateMachineOwner finiteStateMachineOwner, HashSet<EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>> finiteStateMachineStates)
        {
            if (finiteStateMachineOwner == null)
            {
                throw new EasyFrameworkException("类型为空的有限状态机持有者是无效的。");
            }

            if (finiteStateMachineStates == null || finiteStateMachineStates.Count < 1)
            {
                throw new EasyFrameworkException("类型为空的有限状态机状态集合是无效的。");
            }

            EasyFiniteStateMachine<TEasyFiniteStateMachineOwner> tempFiniteStateMachine = EasyReferencePool.AcquireReference<EasyFiniteStateMachine<TEasyFiniteStateMachineOwner>>();
            tempFiniteStateMachine.m_FiniteStateMachineOwner = finiteStateMachineOwner;
            tempFiniteStateMachine.m_IsCleared = false;
            foreach (EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner> finiteStateMachineStateItem in finiteStateMachineStates)
            {
                if (finiteStateMachineStateItem == null)
                {
                    throw new EasyFrameworkException("类型为空的有限状态机状态是无效的。");
                }

                tempFiniteStateMachine.m_FiniteStateMachineStates.Add(finiteStateMachineStateItem.GetType(), finiteStateMachineStateItem);
            }

            return tempFiniteStateMachine;
        }

        /// <summary>
        /// 启动有限状态机。
        /// </summary>
        /// <typeparam name="TFiniteStateMachineOwnerState">要启动的有限状态机持有者状态类型。</typeparam>
        public void StartFiniteStateMachine<TFiniteStateMachineOwnerState>() where TFiniteStateMachineOwnerState : EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>
        {
            if (IsRunning)
            {
                throw new EasyFrameworkException("当前有限状态机正在运行无法再次启动。");
            }

            EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner> tempFiniteStateMachineState = GetFiniteStateMachineState<TFiniteStateMachineOwnerState>() ?? throw new EasyFrameworkException("不存在的要启动的有限状态机状态是无效的。");
            m_FiniteStateMachineCurrentState = tempFiniteStateMachineState;
            m_FiniteStateMachineCurrentState.OnEnterState(this);
        }

        /// <summary>
        /// 检查是否存在有限状态机状态。
        /// </summary>
        /// <typeparam name="TFiniteStateMachineOwnerState">要检查的有限状态机持有者状态类型。</typeparam>
        /// <returns>是否存在有限状态机状态。</returns>
        public Boolean HasFiniteStateMachineState<TFiniteStateMachineOwnerState>() where TFiniteStateMachineOwnerState : EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>
        {
            return m_FiniteStateMachineStates.ContainsKey(typeof(TFiniteStateMachineOwnerState));
        }

        /// <summary>
        /// 获取有限状态机状态。
        /// </summary>
        /// <typeparam name="TFiniteStateMachineOwnerState">要获取的有限状态机持有者状态类型。</typeparam>
        /// <returns>获取到的有限状态机状态。</returns>
        public TFiniteStateMachineOwnerState GetFiniteStateMachineState<TFiniteStateMachineOwnerState>() where TFiniteStateMachineOwnerState : EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>
        {
            if (m_FiniteStateMachineStates.TryGetValue(typeof(TFiniteStateMachineOwnerState), out EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner> finiteStateMachineOwnerState))
            {
                return (TFiniteStateMachineOwnerState) finiteStateMachineOwnerState;
            }

            return null;
        }

        /// <summary>
        /// 获取有限状态机的所有状态。
        /// </summary>
        /// <returns>获取到的有限状态机所有状态。</returns>
        public EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>[] GetFiniteStateMachineStates()
        {
            int pointer = 0;
            EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>[] tempStates = new EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>[m_FiniteStateMachineStates.Count];
            foreach (KeyValuePair<Type, EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>> stateItem in m_FiniteStateMachineStates)
            {
                tempStates[pointer++] = stateItem.Value;
            }

            return tempStates;
        }

        /// <summary>
        /// 切换有限状态机状态。
        /// </summary>
        /// <typeparam name="TFiniteStateMachineOwnerState">要切换的有限状态机持有者状态类型。</typeparam>
        public void ChangeFiniteStateMachineState<TFiniteStateMachineOwnerState>() where TFiniteStateMachineOwnerState : EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>
        {
            if (!IsRunning)
            {
                throw new EasyFrameworkException("请先启动有限状态机。");
            }

            EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner> tempFiniteStateMachineState = GetFiniteStateMachineState<TFiniteStateMachineOwnerState>();
            if (tempFiniteStateMachineState == null)
            {
                throw new EasyFrameworkException("不存在的要切换的有限状态机状态是无效的。");
            }

            m_FiniteStateMachineCurrentState.OnLeaveState(this);
            m_FiniteStateMachineCurrentState = tempFiniteStateMachineState;
            m_FiniteStateMachineCurrentState.OnEnterState(this);
        }

        /// <summary>
        /// 关闭有限状态机。
        /// </summary>
        public void CloseFiniteStateMachine()
        {
            if (m_FiniteStateMachineCurrentState == null)
            {
                m_IsCleared = true;
                return;
            }

            m_FiniteStateMachineCurrentState.OnLeaveState(this);
            m_FiniteStateMachineCurrentState = null;
            m_IsCleared = true;
        }
    }
}