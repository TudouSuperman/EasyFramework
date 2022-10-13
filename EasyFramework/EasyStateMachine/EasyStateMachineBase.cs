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
    /// Easy Framework 状态机基类。
    /// </summary>
    internal abstract class EasyStateMachineBase
    {
        /// <summary>
        /// 获取状态机是否正在运行。
        /// </summary>
        public abstract Boolean IsRunning { get; }

        /// <summary>
        /// 获取状态机是否被清理。
        /// </summary>
        public abstract Boolean IsCleared { get; }

        /// <summary>
        /// 状态机轮询。
        /// </summary>
        /// <param name="logicTime">逻辑时间。</param>
        protected internal abstract void StateMachineUpdate(Single logicTime);

        /// <summary>
        /// 状态机关闭。
        /// </summary>
        protected internal abstract void StateMachineShutdown();
    }
}