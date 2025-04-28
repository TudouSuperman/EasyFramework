//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/TudouSuperman/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using System.Collections.Generic;
using EasyFramework.EasyCommon;
using EasyFramework.EasyReference;

namespace EasyFramework.EasyEvent
{
    /// <summary>
    /// Easy Framework 事件模块。
    /// </summary>
    internal sealed partial class EasyEventModule : EasyFrameworkModule, IEasyEventModule, IEasyModuleUpdate
    {
        private readonly IDictionary<Int32, EasyFrameworkEventHandler<EasyFrameworkEventArgs>> m_EventHandlerDic;
        private readonly Queue<EasyEvent> m_EventQueue;

        /// <summary>
        /// 事件模块优先级。
        /// </summary>
        public override EasyModulePriority Priority => EasyModulePriority.EasyEventModule;

        /// <summary>
        /// 初始化事件模块的新实例。
        /// </summary>
        public EasyEventModule()
        {
            m_EventHandlerDic = new Dictionary<Int32, EasyFrameworkEventHandler<EasyFrameworkEventArgs>>();
            m_EventQueue = new Queue<EasyEvent>();
        }

        /// <summary>
        /// 事件模块关闭。
        /// </summary>
        protected internal override void EasyModuleShutdown()
        {
            lock (m_EventHandlerDic)
            {
                m_EventHandlerDic.Clear();
                m_EventQueue.Clear();
            }
        }

        /// <summary>
        /// 事件模块轮询。
        /// </summary>
        /// <param name="logicTime">逻辑时间。</param>
        public void EasyModuleUpdate(Single logicTime)
        {
            if (m_EventQueue == null)
            {
                return;
            }

            lock (m_EventQueue)
            {
                if (m_EventQueue == null || m_EventQueue.Count <= 0)
                {
                    return;
                }

                while (m_EventQueue.Count > 0)
                {
                    EasyEvent e = m_EventQueue.Dequeue();
                    InternalHandleEvent(e.Sender, e.EventArgs);
                    EasyReferencePool.ReleaseReference(e);
                }
            }
        }
    }
}