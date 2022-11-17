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

namespace EasyFramework.EasyMessage
{
    /// <summary>
    /// Easy Framework 消息模块。
    /// </summary>
    internal sealed partial class EasyMessageModule
    {
        /// <summary>
        /// 订阅消息。
        /// </summary>
        /// <param name="id">要订阅的消息编号。</param>
        /// <param name="message">要订阅的消息。</param>
        public void SubscribeMessage(Int32 id, EasyFrameworkAction message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache == null)
            {
                m_MessageCache = new Dictionary<Int32, IEasyMessage>();
            }

            if (m_MessageCache.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage messages = easyMessage as EasyMessage;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要订阅的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList += message;
            }
            else
            {
                m_MessageCache.Add(id, EasyMessage.Create(message));
            }
        }

        /// <summary>
        /// 订阅消息。
        /// </summary>
        /// <param name="id">要订阅的消息编号。</param>
        /// <param name="message">要订阅的消息。</param>
        /// <typeparam name="TMessage">要订阅的消息信息类型。</typeparam>
        public void SubscribeMessage<TMessage>(Int32 id, EasyFrameworkAction<TMessage> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache1 == null)
            {
                m_MessageCache1 = new Dictionary<Int32, IEasyMessage>();
            }

            if (m_MessageCache1.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage> messages = easyMessage as EasyMessage<TMessage>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要订阅的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList += message;
            }
            else
            {
                m_MessageCache1.Add(id, EasyMessage<TMessage>.Create(message));
            }
        }

        /// <summary>
        /// 订阅消息。
        /// </summary>
        /// <param name="id">要订阅的消息编号。</param>
        /// <param name="message">要订阅的消息。</param>
        /// <typeparam name="TMessage1">要订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要订阅的消息信息类型 2。</typeparam>
        public void SubscribeMessage<TMessage1, TMessage2>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache2 == null)
            {
                m_MessageCache2 = new Dictionary<Int32, IEasyMessage>();
            }

            if (m_MessageCache2.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2> messages = easyMessage as EasyMessage<TMessage1, TMessage2>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要订阅的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList += message;
            }
            else
            {
                m_MessageCache2.Add(id, EasyMessage<TMessage1, TMessage2>.Create(message));
            }
        }

        /// <summary>
        /// 订阅消息。
        /// </summary>
        /// <param name="id">要订阅的消息编号。</param>
        /// <param name="message">要订阅的消息。</param>
        /// <typeparam name="TMessage1">要订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要订阅的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要订阅的消息信息类型 3。</typeparam>
        public void SubscribeMessage<TMessage1, TMessage2, TMessage3>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache3 == null)
            {
                m_MessageCache3 = new Dictionary<Int32, IEasyMessage>();
            }

            if (m_MessageCache3.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2, TMessage3> messages = easyMessage as EasyMessage<TMessage1, TMessage2, TMessage3>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要订阅的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList += message;
            }
            else
            {
                m_MessageCache3.Add(id, EasyMessage<TMessage1, TMessage2, TMessage3>.Create(message));
            }
        }

        /// <summary>
        /// 订阅消息。
        /// </summary>
        /// <param name="id">要订阅的消息编号。</param>
        /// <param name="message">要订阅的消息。</param>
        /// <typeparam name="TMessage1">要订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要订阅的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要订阅的消息信息类型 3。</typeparam>
        /// <typeparam name="TMessage4">要订阅的消息信息类型 4。</typeparam>
        public void SubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache4 == null)
            {
                m_MessageCache4 = new Dictionary<Int32, IEasyMessage>();
            }

            if (m_MessageCache4.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4> messages = easyMessage as EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要订阅的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList += message;
            }
            else
            {
                m_MessageCache4.Add(id, EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4>.Create(message));
            }
        }

        /// <summary>
        /// 订阅消息。
        /// </summary>
        /// <param name="id">要订阅的消息编号。</param>
        /// <param name="message">要订阅的消息。</param>
        /// <typeparam name="TMessage1">要订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要订阅的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要订阅的消息信息类型 3。</typeparam>
        /// <typeparam name="TMessage4">要订阅的消息信息类型 4。</typeparam>
        /// <typeparam name="TMessage5">要订阅的消息信息类型 5。</typeparam>
        public void SubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache5 == null)
            {
                m_MessageCache5 = new Dictionary<Int32, IEasyMessage>();
            }

            if (m_MessageCache5.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> messages = easyMessage as EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要订阅的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList += message;
            }
            else
            {
                m_MessageCache5.Add(id, EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>.Create(message));
            }
        }

        /// <summary>
        /// 订阅消息。
        /// </summary>
        /// <param name="id">要订阅的消息编号。</param>
        /// <param name="message">要订阅的消息。</param>
        /// <typeparam name="TMessage1">要订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要订阅的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要订阅的消息信息类型 3。</typeparam>
        /// <typeparam name="TMessage4">要订阅的消息信息类型 4。</typeparam>
        /// <typeparam name="TMessage5">要订阅的消息信息类型 5。</typeparam>
        /// <typeparam name="TMessage6">要订阅的消息信息类型 6。</typeparam>
        public void SubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache6 == null)
            {
                m_MessageCache6 = new Dictionary<Int32, IEasyMessage>();
            }

            if (m_MessageCache6.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> messages = easyMessage as EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要订阅的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList += message;
            }
            else
            {
                m_MessageCache6.Add(id, EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>.Create(message));
            }
        }

        /// <summary>
        /// 订阅消息。
        /// </summary>
        /// <param name="id">要订阅的消息编号。</param>
        /// <param name="message">要订阅的消息。</param>
        /// <typeparam name="TMessage1">要订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要订阅的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要订阅的消息信息类型 3。</typeparam>
        /// <typeparam name="TMessage4">要订阅的消息信息类型 4。</typeparam>
        /// <typeparam name="TMessage5">要订阅的消息信息类型 5。</typeparam>
        /// <typeparam name="TMessage6">要订阅的消息信息类型 6。</typeparam>
        /// <typeparam name="TMessage7">要订阅的消息信息类型 7。</typeparam>
        public void SubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache7 == null)
            {
                m_MessageCache7 = new Dictionary<Int32, IEasyMessage>();
            }

            if (m_MessageCache7.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> messages = easyMessage as EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要订阅的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList += message;
            }
            else
            {
                m_MessageCache7.Add(id, EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>.Create(message));
            }
        }

        /// <summary>
        /// 取消订阅消息。
        /// </summary>
        /// <param name="id">要取消订阅的消息编号。</param>
        /// <param name="message">要取消订阅的消息。</param>
        public void UnSubscribeMessage(Int32 id, EasyFrameworkAction message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要取消订阅的消息信息是无效的");
            }

            if (m_MessageCache.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage messages = easyMessage as EasyMessage;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要取消订阅的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList -= message;
                if (messages.MessageList == null || messages.MessageList.GetInvocationList().Length <= 0)
                {
                    EasyReferencePool.ReleaseReference((EasyMessage) easyMessage);
                    m_MessageCache.Remove(id);
                }
            }
            else
            {
                m_MessageCache.Remove(id);
            }
        }

        /// <summary>
        /// 取消订阅消息。
        /// </summary>
        /// <param name="id">要取消订阅的消息编号。</param>
        /// <param name="message">要取消订阅的消息。</param>
        /// <typeparam name="TMessage">要取消订阅的消息信息类型。</typeparam>
        public void UnSubscribeMessage<TMessage>(Int32 id, EasyFrameworkAction<TMessage> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要取消订阅的消息信息是无效的");
            }

            if (m_MessageCache1.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage> messages = easyMessage as EasyMessage<TMessage>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要取消订阅的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList -= message;
                if (messages.MessageList == null || messages.MessageList.GetInvocationList().Length <= 0)
                {
                    EasyReferencePool.ReleaseReference((EasyMessage<TMessage>) easyMessage);
                    m_MessageCache1.Remove(id);
                }
            }
        }

        /// <summary>
        /// 取消订阅消息。
        /// </summary>
        /// <param name="id">要取消订阅的消息编号。</param>
        /// <param name="message">要取消订阅的消息。</param>
        /// <typeparam name="TMessage1">要取消订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要取消订阅的消息信息类型 2。</typeparam>
        public void UnSubscribeMessage<TMessage1, TMessage2>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要取消订阅的消息信息是无效的");
            }

            if (m_MessageCache2.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2> messages = easyMessage as EasyMessage<TMessage1, TMessage2>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要取消订阅的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList -= message;
                if (messages.MessageList == null || messages.MessageList.GetInvocationList().Length <= 0)
                {
                    EasyReferencePool.ReleaseReference((EasyMessage<TMessage1, TMessage2>) easyMessage);
                    m_MessageCache2.Remove(id);
                }
            }
        }

        /// <summary>
        /// 取消订阅消息。
        /// </summary>
        /// <param name="id">要取消订阅的消息编号。</param>
        /// <param name="message">要取消订阅的消息。</param>
        /// <typeparam name="TMessage1">要取消订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要取消订阅的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要取消订阅的消息信息类型 3。</typeparam>
        public void UnSubscribeMessage<TMessage1, TMessage2, TMessage3>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要取消订阅的消息信息是无效的");
            }

            if (m_MessageCache3.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2, TMessage3> messages = easyMessage as EasyMessage<TMessage1, TMessage2, TMessage3>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要取消订阅的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList -= message;
                if (messages.MessageList == null || messages.MessageList.GetInvocationList().Length <= 0)
                {
                    EasyReferencePool.ReleaseReference((EasyMessage<TMessage1, TMessage2, TMessage3>) easyMessage);
                    m_MessageCache3.Remove(id);
                }
            }
        }

        /// <summary>
        /// 取消订阅消息。
        /// </summary>
        /// <param name="id">要取消订阅的消息编号。</param>
        /// <param name="message">要取消订阅的消息。</param>
        /// <typeparam name="TMessage1">要取消订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要取消订阅的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要取消订阅的消息信息类型 3。</typeparam>
        /// <typeparam name="TMessage4">要取消订阅的消息信息类型 4。</typeparam>
        public void UnSubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要取消订阅的消息信息是无效的");
            }

            if (m_MessageCache4.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4> messages = easyMessage as EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要取消订阅的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList -= message;
                if (messages.MessageList == null || messages.MessageList.GetInvocationList().Length <= 0)
                {
                    EasyReferencePool.ReleaseReference((EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4>) easyMessage);
                    m_MessageCache4.Remove(id);
                }
            }
        }

        /// <summary>
        /// 取消订阅消息。
        /// </summary>
        /// <param name="id">要取消订阅的消息编号。</param>
        /// <param name="message">要取消订阅的消息。</param>
        /// <typeparam name="TMessage1">要取消订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要取消订阅的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要取消订阅的消息信息类型 3。</typeparam>
        /// <typeparam name="TMessage4">要取消订阅的消息信息类型 4。</typeparam>
        /// <typeparam name="TMessage5">要取消订阅的消息信息类型 5。</typeparam>
        public void UnSubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要取消订阅的消息信息是无效的");
            }

            if (m_MessageCache5.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> messages = easyMessage as EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要取消订阅的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList -= message;
                if (messages.MessageList == null || messages.MessageList.GetInvocationList().Length <= 0)
                {
                    EasyReferencePool.ReleaseReference((EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>) easyMessage);
                    m_MessageCache5.Remove(id);
                }
            }
        }

        /// <summary>
        /// 取消订阅消息。
        /// </summary>
        /// <param name="id">要取消订阅的消息编号。</param>
        /// <param name="message">要取消订阅的消息。</param>
        /// <typeparam name="TMessage1">要取消订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要取消订阅的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要取消订阅的消息信息类型 3。</typeparam>
        /// <typeparam name="TMessage4">要取消订阅的消息信息类型 4。</typeparam>
        /// <typeparam name="TMessage5">要取消订阅的消息信息类型 5。</typeparam>
        /// <typeparam name="TMessage6">要取消订阅的消息信息类型 6。</typeparam>
        public void UnSubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要取消订阅的消息信息是无效的");
            }

            if (m_MessageCache6.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> messages = easyMessage as EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要取消订阅的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList -= message;
                if (messages.MessageList == null || messages.MessageList.GetInvocationList().Length <= 0)
                {
                    EasyReferencePool.ReleaseReference((EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>) easyMessage);
                    m_MessageCache6.Remove(id);
                }
            }
        }

        /// <summary>
        /// 取消订阅消息。
        /// </summary>
        /// <param name="id">要取消订阅的消息编号。</param>
        /// <param name="message">要取消订阅的消息。</param>
        /// <typeparam name="TMessage1">要取消订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要取消订阅的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要取消订阅的消息信息类型 3。</typeparam>
        /// <typeparam name="TMessage4">要取消订阅的消息信息类型 4。</typeparam>
        /// <typeparam name="TMessage5">要取消订阅的消息信息类型 5。</typeparam>
        /// <typeparam name="TMessage6">要取消订阅的消息信息类型 6。</typeparam>
        /// <typeparam name="TMessage7">要取消订阅的消息信息类型 7。</typeparam>
        public void UnSubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要取消订阅的消息信息是无效的");
            }

            if (m_MessageCache7.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> messages = easyMessage as EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要取消订阅的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList -= message;
                if (messages.MessageList == null || messages.MessageList.GetInvocationList().Length <= 0)
                {
                    EasyReferencePool.ReleaseReference((EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>) easyMessage);
                    m_MessageCache7.Remove(id);
                }
            }
        }

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        public void SendMessage(Int32 id)
        {
            if (m_MessageCache.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage messages = easyMessage as EasyMessage;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要发送的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList?.Invoke();
            }
        }

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        /// <param name="message">要发送的信息。</param>
        /// <typeparam name="TMessage">要发送的消息信息类型。</typeparam>
        public void SendMessage<TMessage>(Int32 id, TMessage message)
        {
            if (m_MessageCache1.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage> messages = easyMessage as EasyMessage<TMessage>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要发送的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList?.Invoke(message);
            }
        }

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        /// <param name="message1">要发送的信息 1。</param>
        /// <param name="message2">要发送的信息 2。</param>
        /// <typeparam name="TMessage1">要发送的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要发送的消息信息类型 2。</typeparam>
        public void SendMessage<TMessage1, TMessage2>(Int32 id, TMessage1 message1, TMessage2 message2)
        {
            if (m_MessageCache2.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2> messages = easyMessage as EasyMessage<TMessage1, TMessage2>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要发送的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList?.Invoke(message1, message2);
            }
        }

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        /// <param name="message1">要发送的信息 1。</param>
        /// <param name="message2">要发送的信息 2。</param>
        /// <param name="message3">要发送的信息 3。</param>
        /// <typeparam name="TMessage1">要发送的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要发送的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要发送的消息信息类型 3。</typeparam>
        public void SendMessage<TMessage1, TMessage2, TMessage3>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3)
        {
            if (m_MessageCache3.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2, TMessage3> messages = easyMessage as EasyMessage<TMessage1, TMessage2, TMessage3>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要发送的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList?.Invoke(message1, message2, message3);
            }
        }

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        /// <param name="message1">要发送的信息 1。</param>
        /// <param name="message2">要发送的信息 2。</param>
        /// <param name="message3">要发送的信息 3。</param>
        /// <param name="message4">要发送的信息 4。</param>
        /// <typeparam name="TMessage1">要发送的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要发送的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要发送的消息信息类型 3。</typeparam>
        /// <typeparam name="TMessage4">要发送的消息信息类型 4。</typeparam>
        public void SendMessage<TMessage1, TMessage2, TMessage3, TMessage4>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4)
        {
            if (m_MessageCache4.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4> messages = easyMessage as EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要发送的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList?.Invoke(message1, message2, message3, message4);
            }
        }

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        /// <param name="message1">要发送的信息 1。</param>
        /// <param name="message2">要发送的信息 2。</param>
        /// <param name="message3">要发送的信息 3。</param>
        /// <param name="message4">要发送的信息 4。</param>
        /// <param name="message5">要发送的信息 5。</param>
        /// <typeparam name="TMessage1">要发送的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要发送的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要发送的消息信息类型 3。</typeparam>
        /// <typeparam name="TMessage4">要发送的消息信息类型 4。</typeparam>
        /// <typeparam name="TMessage5">要发送的消息信息类型 5。</typeparam>
        public void SendMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4, TMessage5 message5)
        {
            if (m_MessageCache5.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> messages = easyMessage as EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要发送的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList?.Invoke(message1, message2, message3, message4, message5);
            }
        }

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        /// <param name="message1">要发送的信息 1。</param>
        /// <param name="message2">要发送的信息 2。</param>
        /// <param name="message3">要发送的信息 3。</param>
        /// <param name="message4">要发送的信息 4。</param>
        /// <param name="message5">要发送的信息 5。</param>
        /// <param name="message6">要发送的信息 6。</param>
        /// <typeparam name="TMessage1">要发送的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要发送的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要发送的消息信息类型 3。</typeparam>
        /// <typeparam name="TMessage4">要发送的消息信息类型 4。</typeparam>
        /// <typeparam name="TMessage5">要发送的消息信息类型 5。</typeparam>
        /// <typeparam name="TMessage6">要发送的消息信息类型 6。</typeparam>
        public void SendMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4, TMessage5 message5, TMessage6 message6)
        {
            if (m_MessageCache6.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> messages = easyMessage as EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要发送的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList?.Invoke(message1, message2, message3, message4, message5, message6);
            }
        }

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        /// <param name="message1">要发送的信息 1。</param>
        /// <param name="message2">要发送的信息 2。</param>
        /// <param name="message3">要发送的信息 3。</param>
        /// <param name="message4">要发送的信息 4。</param>
        /// <param name="message5">要发送的信息 5。</param>
        /// <param name="message6">要发送的信息 6。</param>
        /// <param name="message7">要发送的信息 7。</param>
        /// <typeparam name="TMessage1">要发送的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要发送的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要发送的消息信息类型 3。</typeparam>
        /// <typeparam name="TMessage4">要发送的消息信息类型 4。</typeparam>
        /// <typeparam name="TMessage5">要发送的消息信息类型 5。</typeparam>
        /// <typeparam name="TMessage6">要发送的消息信息类型 6。</typeparam>
        /// <typeparam name="TMessage7">要发送的消息信息类型 7。</typeparam>
        public void SendMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4, TMessage5 message5, TMessage6 message6, TMessage7 message7)
        {
            if (m_MessageCache7.TryGetValue(id, out IEasyMessage easyMessage))
            {
                EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> messages = easyMessage as EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>;
                if (messages == null)
                {
                    throw new EasyFrameworkException("要发送的消息类型与已订阅的消息类型不匹配");
                }

                messages.MessageList?.Invoke(message1, message2, message3, message4, message5, message6, message7);
            }
        }
    }
}