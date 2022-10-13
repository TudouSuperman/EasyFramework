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
        private readonly IDictionary<Int32, IEasyMessage> m_MessageCache;
        private readonly IDictionary<Int32, IEasyMessage> m_MessageCache1;
        private readonly IDictionary<Int32, IEasyMessage> m_MessageCache2;
        private readonly IDictionary<Int32, IEasyMessage> m_MessageCache3;
        private readonly IDictionary<Int32, IEasyMessage> m_MessageCache4;
        private readonly IDictionary<Int32, IEasyMessage> m_MessageCache5;
        private readonly IDictionary<Int32, IEasyMessage> m_MessageCache6;
        private readonly IDictionary<Int32, IEasyMessage> m_MessageCache7;

        /// <summary>
        /// 消息模块优先级。
        /// </summary>
        public override EasyModulePriority Priority => EasyModulePriority.EasyMessageModule;

        /// <summary>
        /// 初始化消息模块的新实例。
        /// </summary>
        public EasyMessageModule()
        {
            m_MessageCache = new Dictionary<int, IEasyMessage>();
            m_MessageCache1 = new Dictionary<int, IEasyMessage>();
            m_MessageCache2 = new Dictionary<int, IEasyMessage>();
            m_MessageCache3 = new Dictionary<int, IEasyMessage>();
            m_MessageCache4 = new Dictionary<int, IEasyMessage>();
            m_MessageCache5 = new Dictionary<int, IEasyMessage>();
            m_MessageCache6 = new Dictionary<int, IEasyMessage>();
            m_MessageCache7 = new Dictionary<int, IEasyMessage>();
        }

        /// <summary>
        /// 消息模块关闭。
        /// </summary>
        protected internal override void EasyModuleShutdown()
        {
            m_MessageCache.Clear();
            m_MessageCache1.Clear();
            m_MessageCache2.Clear();
            m_MessageCache3.Clear();
            m_MessageCache4.Clear();
            m_MessageCache5.Clear();
            m_MessageCache6.Clear();
            m_MessageCache7.Clear();
        }
    }
}