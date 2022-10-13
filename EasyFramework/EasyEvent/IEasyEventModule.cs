//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using EasyFramework.EasyCommon;

namespace EasyFramework.EasyEvent
{
    /// <summary>
    /// Easy Framework 事件模块接口。
    /// </summary>
    public interface IEasyEventModule
    {
        /// <summary>
        /// 获取所有事件数量。
        /// </summary>
        Int32 EventsCount { get; }

        /// <summary>
        /// 获取指定订阅事件的数量。
        /// </summary>
        /// <param name="id">要获取的事件编号。</param>
        /// <returns>指定订阅事件的数量。</returns>
        Int32 EventCount(Int32 id);

        /// <summary>
        /// 检查是否存在指定事件。
        /// </summary>
        /// <param name="id">要检查的事件编号。</param>
        /// <param name="eventHandler">要检查的事件处理函数。</param>
        /// <returns>是否存在指定事件处理函数。</returns>
        Boolean CheckEvent(Int32 id, EasyFrameworkEventHandler<EasyFrameworkEventArgs> eventHandler);

        /// <summary>
        /// 订阅事件。
        /// </summary>
        /// <param name="id">要订阅的事件编号。</param>
        /// <param name="eventHandler">要订阅的事件处理函数。</param>
        void SubscribeEvent(Int32 id, EasyFrameworkEventHandler<EasyFrameworkEventArgs> eventHandler);

        /// <summary>
        /// 取消订阅事件。
        /// </summary>
        /// <param name="id">要取消订阅的事件编号。</param>
        /// <param name="eventHandler">要取消订阅的事件处理函数。</param>
        void UnSubscribeEvent(Int32 id, EasyFrameworkEventHandler<EasyFrameworkEventArgs> eventHandler);

        /// <summary>
        /// 广播事件 - 线程安全模式。
        /// </summary>
        /// <param name="sender">事件发送者。</param>
        /// <param name="eventArgs">事件参数。</param>
        void BroadcastEvent(Object sender, EasyFrameworkEventArgs eventArgs);

        /// <summary>
        /// 广播事件 - 立即广播模式。
        /// </summary>
        /// <param name="sender">事件发送者。</param>
        /// <param name="eventArgs">事件参数。</param>
        void BroadcastEventNow(Object sender, EasyFrameworkEventArgs eventArgs);
    }
}