//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System.Collections.Generic;
using EasyFramework.EasyCommon;
using EasyFramework.EasyStateMachine;

namespace EasyFramework.EasyProcedure
{
    /// <summary>
    /// 流程模块。
    /// </summary>
    internal sealed partial class EasyProcedureModule
    {
        /// <summary>
        /// 获取当前流程状态。
        /// </summary>
        public EasyProcedureState CurrentProcedureState
        {
            get
            {
                if (m_FiniteStateMachine == null)
                {
                    throw new EasyFrameworkException("请先初始化流程管理器。");
                }

                return (EasyProcedureState) m_FiniteStateMachine.FiniteStateMachineCurrentState;
            }
        }

        /// <summary>
        /// 初始化流程管理器。
        /// </summary>
        /// <param name="stateMachineModule">状态机模块。</param>
        /// <param name="procedures">流程模块包含的流程。</param>
        public void Initialize(IEasyStateMachineModule stateMachineModule, HashSet<EasyProcedureState> procedures)
        {
            if (procedures == null || procedures.Count <= 0)
            {
                throw new EasyFrameworkException("类型为空的流程管理器包含的流程是无效的。");
            }

            m_StateMachineModule = stateMachineModule ?? throw new EasyFrameworkException("类型为空的状态机管理器是无效的。");

            HashSet<EasyFiniteStateMachineState<IEasyProcedureModule>> tempFiniteStateMachineStates = new HashSet<EasyFiniteStateMachineState<IEasyProcedureModule>>();
            foreach (EasyProcedureState itemProcedureState in procedures)
            {
                tempFiniteStateMachineStates.Add(itemProcedureState);
            }

            m_FiniteStateMachine = m_StateMachineModule.CreateFiniteStateMachine(this, tempFiniteStateMachineStates);
        }

        /// <summary>
        /// 启动流程状态。
        /// </summary>
        /// <typeparam name="TEasyProcedureState">要启动的流程持有者状态类型。</typeparam>
        public void StartProcedure<TEasyProcedureState>() where TEasyProcedureState : EasyProcedureState
        {
            if (m_FiniteStateMachine == null)
            {
                throw new EasyFrameworkException("请先初始化流程管理器。");
            }

            m_FiniteStateMachine.StartFiniteStateMachine<EasyProcedureState>();
        }

        /// <summary>
        /// 检查是否存在流程状态。
        /// </summary>
        /// <typeparam name="TEasyProcedureState">要检查的流程持有者状态类型。</typeparam>
        /// <returns>是否存在流程状态。</returns>
        public bool HasProcedure<TEasyProcedureState>() where TEasyProcedureState : EasyProcedureState
        {
            if (m_FiniteStateMachine == null)
            {
                throw new EasyFrameworkException("请先初始化流程管理器。");
            }

            return m_FiniteStateMachine.HasFiniteStateMachineState<EasyProcedureState>();
        }

        /// <summary>
        /// 获取流程状态。
        /// </summary>
        /// <typeparam name="TEasyProcedureState">要获取的流程持有者状态类型。</typeparam>
        /// <returns>获取到的流程状态。</returns>
        public EasyProcedureState GetProcedure<TEasyProcedureState>() where TEasyProcedureState : EasyProcedureState
        {
            if (m_FiniteStateMachine == null)
            {
                throw new EasyFrameworkException("请先初始化流程管理器。");
            }

            return m_FiniteStateMachine.GetFiniteStateMachineState<EasyProcedureState>();
        }

        /// <summary>
        /// 获取所有流程状态。
        /// </summary>
        /// <returns>获取到的所有流程状态。</returns>
        public EasyProcedureState[] GetProcedures()
        {
            if (m_FiniteStateMachine == null)
            {
                throw new EasyFrameworkException("请先初始化流程管理器。");
            }

            EasyFiniteStateMachineState<IEasyProcedureModule>[] tempFiniteStateMachineStates = m_FiniteStateMachine.GetFiniteStateMachineStates();
            EasyProcedureState[] tempProcedureStates = new EasyProcedureState[tempFiniteStateMachineStates.Length];
            for (int i = 0; i < tempFiniteStateMachineStates.Length; i++)
            {
                tempProcedureStates[i] = (EasyProcedureState) tempFiniteStateMachineStates[i];
            }

            return tempProcedureStates;
        }

        /// <summary>
        /// 获取所有流程状态。
        /// </summary>
        /// <param name="procedureStates">获取到的所有流程状态。</param>
        public void GetProcedures(List<EasyProcedureState> procedureStates)
        {
            foreach (EasyFiniteStateMachineState<IEasyProcedureModule> itemProcedureState in m_FiniteStateMachine.GetFiniteStateMachineStates())
            {
                procedureStates.Add((EasyProcedureState) itemProcedureState);
            }
        }
    }
}