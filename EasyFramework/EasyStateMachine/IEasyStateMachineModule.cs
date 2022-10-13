//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace EasyFramework.EasyStateMachine
{
    /// <summary>
    /// Easy Framework 状态机模块接口。
    /// </summary>
    public interface IEasyStateMachineModule
    {
        /// <summary>
        /// 获取所有有限状态机的数量。
        /// </summary>
        Int32 FiniteStateMachineCount { get; }

        /// <summary>
        /// 获取所有下推状态机的数量。
        /// </summary>
        Int32 PushDownStateMachineCount { get; }

        /// <summary>
        /// 检查是否存在有限状态机。
        /// </summary>
        /// <typeparam name="TEasyFiniteStateMachineOwner">要检查的有限状态机持有者类型。</typeparam>
        /// <returns>是否存在有限状态机。</returns>
        Boolean HasFiniteStateMachine<TEasyFiniteStateMachineOwner>() where TEasyFiniteStateMachineOwner : class;

        /// <summary>
        /// 检查是否存在下推状态机。
        /// </summary>
        /// <typeparam name="TEasyPushDownStateMachineOwner">要检查的下推状态机持有者类型。</typeparam>
        /// <returns>是否存在下推状态机。</returns>
        Boolean HasPushDownStateMachine<TEasyPushDownStateMachineOwner>() where TEasyPushDownStateMachineOwner : class;

        /// <summary>
        /// 获取有限状态机。
        /// </summary>
        /// <typeparam name="TEasyFiniteStateMachineOwner">要获取的有限状态机持有者类型。</typeparam>
        /// <returns>获取到的有限状态机。</returns>
        IEasyFiniteStateMachine<TEasyFiniteStateMachineOwner> GetFiniteStateMachine<TEasyFiniteStateMachineOwner>() where TEasyFiniteStateMachineOwner : class;

        /// <summary>
        /// 获取下推状态机。
        /// </summary>
        /// <typeparam name="TEasyPushDownStateMachineOwner">要获取的下推状态机持有者类型。</typeparam>
        /// <returns>获取到的下推状态机。</returns>
        IEasyPushDownStateMachine<TEasyPushDownStateMachineOwner> GetPushDownStateMachine<TEasyPushDownStateMachineOwner>() where TEasyPushDownStateMachineOwner : class;

        /// <summary>
        /// 创建有限状态机。
        /// </summary>
        /// <param name="finiteStateMachineOwner">有限状态机持有者。</param>
        /// <param name="finiteStateMachineStates">有限状态机状态集合。</param>
        /// <typeparam name="TEasyFiniteStateMachineOwner">要创建的有限状态机持有者类型。</typeparam>
        /// <returns>创建的有限状态机。</returns>
        IEasyFiniteStateMachine<TEasyFiniteStateMachineOwner> CreateFiniteStateMachine<TEasyFiniteStateMachineOwner>(TEasyFiniteStateMachineOwner finiteStateMachineOwner, HashSet<EasyFiniteStateMachineState<TEasyFiniteStateMachineOwner>> finiteStateMachineStates) where TEasyFiniteStateMachineOwner : class;

        /// <summary>
        /// 创建下推状态机。
        /// </summary>
        /// <param name="pushDownStateMachineOwner">下推状态机持有者。</param>
        /// <param name="pushDownStateMachineStates">下推状态机状态集合。</param>
        /// <typeparam name="TEasyPushDownStateMachineOwner">要创建的下推状态机持有者类型。</typeparam>
        /// <returns>创建的下推状态机。</returns>
        IEasyPushDownStateMachine<TEasyPushDownStateMachineOwner> CreatePushDownStateMachine<TEasyPushDownStateMachineOwner>(TEasyPushDownStateMachineOwner pushDownStateMachineOwner, HashSet<EasyPushDownStateMachineState<TEasyPushDownStateMachineOwner>> pushDownStateMachineStates) where TEasyPushDownStateMachineOwner : class;

        /// <summary>
        /// 销毁有限状态机。
        /// </summary>
        /// <typeparam name="TEasyFiniteStateMachineOwner">要销毁的有限状态机持有者类型。</typeparam>
        /// <returns>是否销毁有限状态机成功。</returns>
        Boolean DestroyFiniteStateMachine<TEasyFiniteStateMachineOwner>() where TEasyFiniteStateMachineOwner : class;

        /// <summary>
        /// 销毁下推状态机。
        /// </summary>
        /// <typeparam name="TEasyPushDownStateMachineOwner">要销毁的下推状态机持有者类型。</typeparam>
        /// <returns>是否销毁下推状态机成功。</returns>
        Boolean DestroyPushDownStateMachine<TEasyPushDownStateMachineOwner>() where TEasyPushDownStateMachineOwner : class;
    }
}