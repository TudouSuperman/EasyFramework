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
    /// 有限状态机状态基类。
    /// </summary>
    /// <typeparam name="TEasyFiniteStateMachineOwner">有限状态机持有者类型。</typeparam>
    public abstract class EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner> where TEasyFiniteStateMachineOwner : class
    {
        /// <summary>
        /// 进入有限状态机状态。
        /// </summary>
        /// <param name="finiteStateMachine">有限状态机持有者。</param>
        protected internal abstract Void OnEnterState(IEasyFiniteStateMachine<TEasyFiniteStateMachineOwner> finiteStateMachine);

        /// <summary>
        /// 轮询有限状态机状态。
        /// </summary>
        /// <param name="finiteStateMachine">有限状态机持有者。</param>
        /// <param name="logicTime">逻辑时间。</param>
        protected internal abstract Void OnUpdateState(IEasyFiniteStateMachine<TEasyFiniteStateMachineOwner> finiteStateMachine, Single logicTime);

        /// <summary>
        /// 离开有限状态机状态。
        /// </summary>
        /// <param name="finiteStateMachine">有限状态机持有者。</param>
        protected internal abstract Void OnLeaveState(IEasyFiniteStateMachine<TEasyFiniteStateMachineOwner> finiteStateMachine);
    }
}