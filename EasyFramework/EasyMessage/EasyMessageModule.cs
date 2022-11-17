//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using System.Collections.Generic;
using EasyFramework.EasyCommon;

namespace EasyFramework.EasyMessage
{
    /// <summary>
    /// Easy Framework 消息模块。
    /// </summary>
    internal sealed partial class EasyMessageModule : EasyFrameworkModule, IEasyMessageModule
    {
        private IDictionary<Int32, IEasyMessage> m_MessageCache;
        private IDictionary<Int32, IEasyMessage> m_MessageCache1;
        private IDictionary<Int32, IEasyMessage> m_MessageCache2;
        private IDictionary<Int32, IEasyMessage> m_MessageCache3;
        private IDictionary<Int32, IEasyMessage> m_MessageCache4;
        private IDictionary<Int32, IEasyMessage> m_MessageCache5;
        private IDictionary<Int32, IEasyMessage> m_MessageCache6;
        private IDictionary<Int32, IEasyMessage> m_MessageCache7;

        /// <summary>
        /// 消息模块优先级。
        /// </summary>
        public override EasyModulePriority Priority => EasyModulePriority.EasyMessageModule;

        /// <summary>
        /// 初始化消息模块的新实例。
        /// </summary>
        public EasyMessageModule()
        {
        }

        /// <summary>
        /// 消息模块关闭。
        /// </summary>
        protected internal override void EasyModuleShutdown()
        {
            if (m_MessageCache != null && m_MessageCache.Count > 0)
            {
                m_MessageCache.Clear();
            }

            if (m_MessageCache1 != null && m_MessageCache1.Count > 0)
            {
                m_MessageCache1.Clear();
            }

            if (m_MessageCache2 != null && m_MessageCache2.Count > 0)
            {
                m_MessageCache2.Clear();
            }

            if (m_MessageCache3 != null && m_MessageCache3.Count > 0)
            {
                m_MessageCache3.Clear();
            }

            if (m_MessageCache4 != null && m_MessageCache4.Count > 0)
            {
                m_MessageCache4.Clear();
            }

            if (m_MessageCache5 != null && m_MessageCache5.Count > 0)
            {
                m_MessageCache5.Clear();
            }

            if (m_MessageCache6 != null && m_MessageCache6.Count > 0)
            {
                m_MessageCache6.Clear();
            }

            if (m_MessageCache7 != null && m_MessageCache7.Count > 0)
            {
                m_MessageCache7.Clear();
            }
        }
    }
}