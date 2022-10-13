//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using EasyFramework.EasyStateMachine;
using ProcedureOwner = EasyFramework.EasyStateMachine.IEasyFiniteStateMachine<EasyFramework.EasyProcedure.IEasyProcedureModule>;

namespace EasyFramework.EasyProcedure
{
    /// <summary>
    /// 流程状态基类。
    /// </summary>
    public abstract class EasyProcedureState : EasyFiniteStateMachineState<IEasyProcedureModule>
    {
        /// <summary>
        /// 进入流程状态。
        /// </summary>
        /// <param name="procedure">流程持有者。</param>
        protected internal override Void OnEnterState(ProcedureOwner procedure)
        {
        }

        /// <summary>
        /// 轮询流程状态。
        /// </summary>
        /// <param name="procedure">流程持有者。</param>
        /// <param name="logicTime">逻辑时间。</param>
        protected internal override Void OnUpdateState(ProcedureOwner procedure, Single logicTime)
        {
        }

        /// <summary>
        /// 离开流程状态。
        /// </summary>
        /// <param name="procedure">流程持有者。</param>
        protected internal override Void OnLeaveState(ProcedureOwner procedure)
        {
        }
    }
}