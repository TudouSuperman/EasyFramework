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
    /// Easy Framework 下推状态机状态基类。
    /// </summary>
    /// <typeparam name="TEasyPushDownStateMachineOwner">下推状态机持有者类型。</typeparam>
    public abstract class EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner> where TEasyPushDownStateMachineOwner : class
    {
        /// <summary>
        /// 下推状态机进入状态。
        /// </summary>
        /// <param name="pushDownStateMachine">下推状态机持有者。</param>
        protected internal abstract void OnEnterState(IEasyPushDownStateMachine<TEasyPushDownStateMachineOwner> pushDownStateMachine);

        /// <summary>
        /// 下推状态机下推状态。
        /// </summary>
        /// <param name="pushDownStateMachine">下推状态机持有者。</param>
        protected internal abstract void OnPauseState(IEasyPushDownStateMachine<TEasyPushDownStateMachineOwner> pushDownStateMachine);

        /// <summary>
        /// 下推状态机轮询状态。
        /// </summary>
        /// <param name="pushDownStateMachine">下推状态机持有者。</param>
        /// <param name="logicTime">逻辑时间。</param>
        protected internal abstract void OnUpdateState(IEasyPushDownStateMachine<TEasyPushDownStateMachineOwner> pushDownStateMachine, Single logicTime);

        /// <summary>
        /// 下推状态机回滚状态。
        /// </summary>
        /// <param name="pushDownStateMachine">下推状态机持有者。</param>
        protected internal abstract void OnResumeState(IEasyPushDownStateMachine<TEasyPushDownStateMachineOwner> pushDownStateMachine);

        /// <summary>
        /// 下推状态机离开状态。
        /// </summary>
        /// <param name="pushDownStateMachine">下推状态机持有者。</param>
        protected internal abstract void OnLeaveState(IEasyPushDownStateMachine<TEasyPushDownStateMachineOwner> pushDownStateMachine);
    }
}