//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using System.Collections.Generic;
using EasyFramework.EasyCommon;
using EasyFramework.EasyReference;

namespace EasyFramework.EasyEvent
{
    /// <summary>
    /// 事件模块。
    /// </summary>
    internal sealed partial class EasyEventModule : EasyFrameworkModule, IEasyEventModule, IEasyModuleUpdate
    {
        private readonly IDictionary<Int32, EasyFrameworkEventHandler<EasyFrameworkEventArgs>> m_EventHandlers;
        private readonly Queue<EasyEvent> m_EasyEventHandlers;

        /// <summary>
        /// 事件模块优先级。
        /// </summary>
        public override EasyModulePriority Priority => EasyModulePriority.EasyEventModule;

        /// <summary>
        /// 初始化事件模块的新实例。
        /// </summary>
        public EasyEventModule()
        {
            m_EventHandlers = new Dictionary<Int32, EasyFrameworkEventHandler<EasyFrameworkEventArgs>>();
            m_EasyEventHandlers = new Queue<EasyEvent>();
        }

        /// <summary>
        /// 事件模块关闭。
        /// </summary>
        protected internal override void EasyModuleShutdown()
        {
            lock (m_EventHandlers)
            {
                m_EventHandlers.Clear();
                m_EasyEventHandlers.Clear();
            }
        }

        /// <summary>
        /// 事件模块轮询。
        /// </summary>
        /// <param name="logicTime">逻辑时间。</param>
        public void EasyModuleUpdate(Single logicTime)
        {
            if (m_EasyEventHandlers == null)
            {
                return;
            }

            lock (m_EasyEventHandlers)
            {
                if (m_EasyEventHandlers == null || m_EasyEventHandlers.Count <= 0)
                {
                    return;
                }

                while (m_EasyEventHandlers.Count > 0)
                {
                    EasyEvent e = m_EasyEventHandlers.Dequeue();
                    InternalHandleEvent(e.Sender, e.EventArgs);
                    EasyReferencePool.ReleaseReference(e);
                }
            }
        }
    }
}