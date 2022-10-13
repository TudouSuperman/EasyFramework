//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using EasyFramework.EasyReference;

namespace EasyFramework.EasyCommon
{
    /// <summary>
    /// Easy Framework 事件参数基类。
    /// </summary>
    public abstract class EasyFrameworkEventArgs : EventArgs, IEasyReference
    {
        /// <summary>
        /// Easy Framework 事件参数编号。
        /// </summary>
        public abstract Int32 EventArgsId { get; }

        /// <summary>
        /// 初始化 Easy Framework 事件参数基类的新实例。
        /// </summary>
        protected EasyFrameworkEventArgs()
        {
        }

        /// <summary>
        /// 清理 EasyFrameworkEventArgs 引用。
        /// </summary>
        public abstract void ClearReference();
    }
}