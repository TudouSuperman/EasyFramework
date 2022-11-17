//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System.Collections.Generic;
using EasyFramework.EasyStateMachine;

namespace EasyFramework.EasyProcedure
{
    /// <summary>
    /// Easy Framework 流程模块接口。
    /// </summary>
    public interface IEasyProcedureModule
    {
        /// <summary>
        /// 获取当前流程状态。
        /// </summary>
        EasyProcedureState CurrentProcedureState { get; }

        /// <summary>
        /// 初始化流程管理器。
        /// </summary>
        /// <param name="stateMachineModule">状态机模块。</param>
        /// <param name="procedures">流程模块包含的流程。</param>
        void Initialize(IEasyStateMachineModule stateMachineModule, HashSet<EasyProcedureState> procedures);

        /// <summary>
        /// 启动流程状态。
        /// </summary>
        /// <typeparam name="TProcedureState">要启动的流程持有者状态类型。</typeparam>
        void StartProcedure<TProcedureState>() where TProcedureState : EasyProcedureState;

        /// <summary>
        /// 检查是否存在流程状态。
        /// </summary>
        /// <typeparam name="TProcedureState">要检查的流程持有者状态类型。</typeparam>
        /// <returns>是否存在流程状态。</returns>
        bool HasProcedure<TProcedureState>() where TProcedureState : EasyProcedureState;

        /// <summary>
        /// 获取流程状态。
        /// </summary>
        /// <typeparam name="TProcedureState">要获取的流程持有者状态类型。</typeparam>
        /// <returns>获取到的流程状态。</returns>
        EasyProcedureState GetProcedure<TProcedureState>() where TProcedureState : EasyProcedureState;

        /// <summary>
        /// 获取所有流程状态。
        /// </summary>
        /// <returns>获取到的所有流程状态。</returns>
        EasyProcedureState[] GetProcedures();

        /// <summary>
        /// 获取所有流程状态。
        /// </summary>
        /// <param name="procedureStates">获取到的所有流程状态。</param>
        void GetProcedures(List<EasyProcedureState> procedureStates);
    }
}