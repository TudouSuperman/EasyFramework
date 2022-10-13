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
    /// 下推状态机接口。
    /// </summary>
    /// <typeparam name="TEasyPushDownStateMachineOwner">下推状态机持有者类型。</typeparam>
    public interface IEasyPushDownStateMachine<TEasyPushDownStateMachineOwner> where TEasyPushDownStateMachineOwner : class
    {
        /// <summary>
        /// 获取下推状态机持有者。
        /// </summary>
        TEasyPushDownStateMachineOwner PushDownStateMachineOwner { get; }

        /// <summary>
        /// 获取下推状态机当前临时位状态。
        /// </summary>
        EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner> PushDownStateMachineCurrentState { get; }

        /// <summary>
        /// 获取状态机持有者类型。
        /// </summary>
        Type StateMachineOwnerType { get; }

        /// <summary>
        /// 获取当前临时位状态机状态名称。
        /// </summary>
        String CurrentStateMachineStateName { get; }

        /// <summary>
        /// 获取状态机中状态的数量。
        /// </summary>
        Int32 StateMachineStateCount { get; }

        /// <summary>
        /// 获取状态机中栈区状态的数量。
        /// </summary>
        Int32 StateMachineStackStateCount { get; }

        /// <summary>
        /// 获取状态机是否正在运行。
        /// </summary>
        Boolean IsRunning { get; }

        /// <summary>
        /// 获取状态机是否被清理。
        /// </summary>
        Boolean IsCleared { get; }

        /// <summary>
        /// 启动下推状态机。
        /// </summary>
        /// <typeparam name="TEasyPushDownStateMachineOwnerState">要启动的下推状态机持有者状态类型。</typeparam>
        Void StartPushDownStateMachineState<TEasyPushDownStateMachineOwnerState>() where TEasyPushDownStateMachineOwnerState : EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>;

        /// <summary>
        /// 检查是否存在下推状态机状态。
        /// </summary>
        /// <typeparam name="TEasyPushDownStateMachineOwnerState">要检查的下推状态机持有者状态类型。</typeparam>
        /// <returns>是否存在下推状态机状态。</returns>
        Boolean HasPushDownStateMachineState<TEasyPushDownStateMachineOwnerState>() where TEasyPushDownStateMachineOwnerState : EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>;

        /// <summary>
        /// 获取下推状态机状态。
        /// </summary>
        /// <typeparam name="TEasyPushDownStateMachineOwnerState">要获取的下推状态机持有者状态类型。</typeparam>
        /// <returns>获取到的下推状态机状态。</returns>
        TEasyPushDownStateMachineOwnerState GetPushDownStateMachineState<TEasyPushDownStateMachineOwnerState>() where TEasyPushDownStateMachineOwnerState : EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>;

        /// <summary>
        /// 获取下推状态机的所有状态。
        /// </summary>
        /// <returns>获取到的下推状态机所有状态。</returns>
        EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>[] GetPushDownStateMachineStates();

        /// <summary>
        /// 下推下推状态机状态到栈区。
        /// </summary>
        /// <typeparam name="TEasyPushDownStateMachineOwnerState">要下推的下推状态机持有者状态类型。</typeparam>
        Void PushDownStateMachineState<TEasyPushDownStateMachineOwnerState>() where TEasyPushDownStateMachineOwnerState : EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>;

        /// <summary>
        /// 弹出下推状态机状态到临时位。
        /// </summary>
        Void PopUpStateMachineState();
        
        /// <summary>
        /// 关闭下推状态机。
        /// </summary>
        Void ClosePushDownStateMachine();
    }
}