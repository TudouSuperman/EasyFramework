//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using System.Linq;
using EasyFramework.EasyCommon;

namespace EasyFramework.EasyEvent
{
    /// <summary>
    /// Easy Framework 事件模块逻辑。
    /// </summary>
    internal sealed partial class EasyEventModule
    {
        /// <summary>
        /// 获取所有事件数量。
        /// </summary>
        public Int32 EventsCount => m_EventHandlers.Count;

        /// <summary>
        /// 获取指定订阅事件的数量。
        /// </summary>
        /// <param name="id">要获取的事件编号。</param>
        /// <returns>指定订阅事件的数量。</returns>
        public Int32 EventCount(Int32 id)
        {
            if (m_EventHandlers.ContainsKey(id))
            {
                return m_EventHandlers[id].GetInvocationList().Length;
            }

            return 0;
        }

        /// <summary>
        /// 检查是否存在指定事件。
        /// </summary>
        /// <param name="id">要检查的事件编号。</param>
        /// <param name="eventHandler">要检查的事件处理函数。</param>
        /// <returns>是否存在指定事件处理函数。</returns>
        public Boolean CheckEvent(Int32 id, EasyFrameworkEventHandler<EasyFrameworkEventArgs> eventHandler)
        {
            if (eventHandler == null)
            {
                throw new EasyFrameworkException("类型为空的要检查的事件处理函数是无效的");
            }

            if (m_EventHandlers.TryGetValue(id, out EasyFrameworkEventHandler<EasyFrameworkEventArgs> eventHandlers))
            {
                return eventHandlers.GetInvocationList().Contains(eventHandler);
            }

            return false;
        }

        /// <summary>
        /// 订阅事件。
        /// </summary>
        /// <param name="id">要订阅的事件编号。</param>
        /// <param name="eventHandler">要订阅的事件处理函数。</param>
        public void SubscribeEvent(Int32 id, EasyFrameworkEventHandler<EasyFrameworkEventArgs> eventHandler)
        {
            if (eventHandler == null)
            {
                throw new EasyFrameworkException("类型为空的要检查的事件处理函数是无效的");
            }

            if (m_EventHandlers.ContainsKey(id))
            {
                m_EventHandlers[id] += eventHandler;
            }
            else
            {
                m_EventHandlers.Add(id, eventHandler);
            }
        }

        /// <summary>
        /// 取消订阅事件。
        /// </summary>
        /// <param name="id">要取消订阅的事件编号。</param>
        /// <param name="eventHandler">要取消订阅的事件处理函数。</param>
        public void UnSubscribeEvent(Int32 id, EasyFrameworkEventHandler<EasyFrameworkEventArgs> eventHandler)
        {
            if (eventHandler == null)
            {
                throw new EasyFrameworkException("类型为空的要检查的事件处理函数是无效的");
            }

            if (m_EventHandlers.ContainsKey(id))
            {
                m_EventHandlers[id] -= eventHandler;
            }
            else
            {
                m_EventHandlers.Remove(id);
            }
        }

        /// <summary>
        /// 广播事件 - 线程安全模式。
        /// </summary>
        /// <param name="sender">事件发送者。</param>
        /// <param name="eventArgs">事件参数。</param>
        public void BroadcastEvent(Object sender, EasyFrameworkEventArgs eventArgs)
        {
            if (eventArgs == null)
            {
                throw new EasyFrameworkException("类型为空的事件参数是无效的");
            }

            lock (m_EasyEventHandlers)
            {
                EasyEvent e = EasyEvent.Create(sender, eventArgs);
                m_EasyEventHandlers.Enqueue(e);
            }
        }

        /// <summary>
        /// 广播事件 - 立即广播模式。
        /// </summary>
        /// <param name="sender">事件发送者。</param>
        /// <param name="eventArgs">事件参数。</param>
        public void BroadcastEventNow(Object sender, EasyFrameworkEventArgs eventArgs)
        {
            if (eventArgs == null)
            {
                throw new EasyFrameworkException("类型为空的事件参数是无效的");
            }

            InternalHandleEvent(sender, eventArgs);
        }

        /// <summary>
        /// 内部处理框架事件函数。
        /// </summary>
        /// <param name="sender">事件发送者。</param>
        /// <param name="eventArgs">框架事件参数。</param>
        private void InternalHandleEvent(Object sender, EasyFrameworkEventArgs eventArgs)
        {
            if (m_EventHandlers.TryGetValue(eventArgs.EventArgsId, out EasyFrameworkEventHandler<EasyFrameworkEventArgs> e))
            {
                e?.Invoke(sender, eventArgs);
            }
        }
    }
}