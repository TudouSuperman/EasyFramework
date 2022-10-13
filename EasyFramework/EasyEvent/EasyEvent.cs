//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using EasyFramework.EasyCommon;
using EasyFramework.EasyReference;

namespace EasyFramework.EasyEvent
{
    /// <summary>
    /// 事件。
    /// </summary>
    internal sealed class EasyEvent : IEasyReference
    {
        /// <summary>
        /// 事件发送者。
        /// </summary>
        public Object Sender { get; private set; }

        /// <summary>
        /// 事件参数。
        /// </summary>
        public EasyFrameworkEventArgs EventArgs { get; private set; }

        /// <summary>
        /// 初始化事件的新实例。
        /// </summary>
        public EasyEvent()
        {
            Sender = null;
            EventArgs = null;
        }

        /// <summary>
        /// 创建事件的新实例。
        /// </summary>
        /// <param name="sender">事件发送者。</param>
        /// <param name="eventArgs">事件参数。</param>
        /// <returns>创建的事件。</returns>
        public static EasyEvent Create(Object sender, EasyFrameworkEventArgs eventArgs)
        {
            EasyEvent e = EasyReferencePool.AcquireReference<EasyEvent>();
            e.Sender = sender;
            e.EventArgs = eventArgs;
            return e;
        }

        /// <summary>
        /// 清理 EasyEvent 引用。
        /// </summary>
        public void ClearReference()
        {
            Sender = null;
            EventArgs = null;
        }
    }
}