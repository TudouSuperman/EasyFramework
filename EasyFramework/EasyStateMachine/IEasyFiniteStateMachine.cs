//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;

namespace EasyFramework.EasyStateMachine
{
    /// <summary>
    /// Easy Framework 有限状态机接口。
    /// </summary>
    /// <typeparam name="TEasyFiniteStateMachineOwner">有限状态机持有者类型。</typeparam>
    public interface IEasyFiniteStateMachine<TEasyFiniteStateMachineOwner> where TEasyFiniteStateMachineOwner : class
    {
        /// <summary>
        /// 获取有限状态机持有者。
        /// </summary>
        TEasyFiniteStateMachineOwner FiniteStateMachineOwner { get; }

        /// <summary>
        /// 获取有限状态机当前状态。
        /// </summary>
        EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner> FiniteStateMachineCurrentState { get; }

        /// <summary>
        /// 获取状态机持有者类型。
        /// </summary>
        Type StateMachineOwnerType { get; }

        /// <summary>
        /// 获取当前状态机状态名称。
        /// </summary>
        String CurrentStateMachineStateName { get; }

        /// <summary>
        /// 获取状态机中状态的数量。
        /// </summary>
        Int32 StateMachineStateCount { get; }

        /// <summary>
        /// 获取状态机是否正在运行。
        /// </summary>
        Boolean IsRunning { get; }

        /// <summary>
        /// 获取状态机是否被清理。
        /// </summary>
        Boolean IsCleared { get; }

        /// <summary>
        /// 启动有限状态机。
        /// </summary>
        /// <typeparam name="TFiniteStateMachineOwnerState">要启动的有限状态机持有者状态类型。</typeparam>
        void StartFiniteStateMachine<TFiniteStateMachineOwnerState>() where TFiniteStateMachineOwnerState : EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>;

        /// <summary>
        /// 检查是否存在有限状态机状态。
        /// </summary>
        /// <typeparam name="TFiniteStateMachineOwnerState">要检查的有限状态机持有者状态类型。</typeparam>
        /// <returns>是否存在有限状态机状态。</returns>
        Boolean HasFiniteStateMachineState<TFiniteStateMachineOwnerState>() where TFiniteStateMachineOwnerState : EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>;

        /// <summary>
        /// 获取有限状态机状态。
        /// </summary>
        /// <typeparam name="TFiniteStateMachineOwnerState">要获取的有限状态机持有者状态类型。</typeparam>
        /// <returns>获取到的有限状态机状态。</returns>
        TFiniteStateMachineOwnerState GetFiniteStateMachineState<TFiniteStateMachineOwnerState>() where TFiniteStateMachineOwnerState : EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>;

        /// <summary>
        /// 获取有限状态机的所有状态。
        /// </summary>
        /// <returns>获取到的有限状态机所有状态。</returns>
        EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>[] GetFiniteStateMachineStates();

        /// <summary>
        /// 切换有限状态机状态。
        /// </summary>
        /// <typeparam name="TFiniteStateMachineOwnerState">要切换的有限状态机持有者状态类型。</typeparam>
        void ChangeFiniteStateMachineState<TFiniteStateMachineOwnerState>() where TFiniteStateMachineOwnerState : EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>;

        /// <summary>
        /// 关闭有限状态机。
        /// </summary>
        void CloseFiniteStateMachine();
    }
}