//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using EasyFramework.EasyCommon;
using EasyFramework.EasyReference;

namespace EasyFramework.EasyMessage
{
    /// <summary>
    /// 消息模块。
    /// </summary>
    internal sealed partial class EasyMessageModule
    {
        /// <summary>
        /// 获取所有订阅消息数量。
        /// </summary>
        public Int32 MessagesCount => m_MessageCache.Count + m_MessageCache1.Count + m_MessageCache2.Count + m_MessageCache3.Count + m_MessageCache4.Count + m_MessageCache5.Count + m_MessageCache6.Count + m_MessageCache7.Count;

        /// <summary>
        /// 检查是否存在指定消息。
        /// </summary>
        /// <param name="id">要检查的消息编号。</param>
        /// <typeparam name="TMessage">要检查的消息信息类型。</typeparam>
        /// <returns>是否存在指定消息。</returns>
        public Boolean CheckMessage<TMessage>(Int32 id)
        {
            return default;
        }

        /// <summary>
        /// 检查是否存在指定消息。
        /// </summary>
        /// <param name="id">要检查的消息编号。</param>
        /// <typeparam name="TMessage1">要检查的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要检查的消息信息类型 2。</typeparam>
        /// <returns>是否存在指定消息。</returns>
        public Boolean CheckMessage<TMessage1, TMessage2>(Int32 id)
        {
            return default;
        }

        /// <summary>
        /// 检查是否存在指定消息。
        /// </summary>
        /// <param name="id">要检查的消息编号。</param>
        /// <typeparam name="TMessage1">要检查的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要检查的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要检查的消息信息类型 3。</typeparam>
        /// <returns>是否存在指定消息。</returns>
        public Boolean CheckMessage<TMessage1, TMessage2, TMessage3>(Int32 id)
        {
            return default;
        }

        /// <summary>
        /// 订阅消息。
        /// </summary>
        /// <param name="id">要订阅的消息编号。</param>
        /// <param name="message">要订阅的消息。</param>
        public Void SubscribeMessage(Int32 id, EasyFrameworkAction message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction tempMessageListInfo = (EasyFrameworkAction) msg.MessageListInfo;
                tempMessageListInfo += message;
            }
            else
            {
                EasyMessage tempEasyMessage = EasyReferencePool.AcquireReference<EasyMessage>();
                tempEasyMessage.MessageList += message;
                m_MessageCache.Add(id, tempEasyMessage);
            }
        }

        /// <summary>
        /// 订阅消息。
        /// </summary>
        /// <param name="id">要订阅的消息编号。</param>
        /// <param name="message">要订阅的消息。</param>
        /// <typeparam name="TMessage">要订阅的消息信息类型。</typeparam>
        public Void SubscribeMessage<TMessage>(Int32 id, EasyFrameworkAction<TMessage> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache1.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage> tempMessageListInfo = (EasyFrameworkAction<TMessage>) msg.MessageListInfo;
                tempMessageListInfo += message;
            }
            else
            {
                EasyMessage<TMessage> tempEasyMessage = EasyReferencePool.AcquireReference<EasyMessage<TMessage>>();
                tempEasyMessage.MessageList += message;
                m_MessageCache1.Add(id, tempEasyMessage);
            }
        }

        /// <summary>
        /// 订阅消息。
        /// </summary>
        /// <param name="id">要订阅的消息编号。</param>
        /// <param name="message">要订阅的消息。</param>
        /// <typeparam name="TMessage1">要订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要订阅的消息信息类型 2。</typeparam>
        public Void SubscribeMessage<TMessage1, TMessage2>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache2.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2>) msg.MessageListInfo;
                tempMessageListInfo += message;
            }
            else
            {
                EasyMessage<TMessage1, TMessage2> tempEasyMessage = EasyReferencePool.AcquireReference<EasyMessage<TMessage1, TMessage2>>();
                tempEasyMessage.MessageList += message;
                m_MessageCache2.Add(id, tempEasyMessage);
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
        public Void SubscribeMessage<TMessage1, TMessage2, TMessage3>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache3.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2, TMessage3> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2, TMessage3>) msg.MessageListInfo;
                tempMessageListInfo += message;
            }
            else
            {
                EasyMessage<TMessage1, TMessage2, TMessage3> tempEasyMessage = EasyReferencePool.AcquireReference<EasyMessage<TMessage1, TMessage2, TMessage3>>();
                tempEasyMessage.MessageList += message;
                m_MessageCache3.Add(id, tempEasyMessage);
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
        public Void SubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache4.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4>) msg.MessageListInfo;
                tempMessageListInfo += message;
            }
            else
            {
                EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4> tempEasyMessage = EasyReferencePool.AcquireReference<EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4>>();
                tempEasyMessage.MessageList += message;
                m_MessageCache4.Add(id, tempEasyMessage);
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
        public Void SubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache5.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>) msg.MessageListInfo;
                tempMessageListInfo += message;
            }
            else
            {
                EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> tempEasyMessage = EasyReferencePool.AcquireReference<EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>>();
                tempEasyMessage.MessageList += message;
                m_MessageCache5.Add(id, tempEasyMessage);
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
        public Void SubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache6.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>) msg.MessageListInfo;
                tempMessageListInfo += message;
            }
            else
            {
                EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> tempEasyMessage = EasyReferencePool.AcquireReference<EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>>();
                tempEasyMessage.MessageList += message;
                m_MessageCache6.Add(id, tempEasyMessage);
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
        public Void SubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache7.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>) msg.MessageListInfo;
                tempMessageListInfo += message;
            }
            else
            {
                EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> tempEasyMessage = EasyReferencePool.AcquireReference<EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>>();
                tempEasyMessage.MessageList += message;
                m_MessageCache7.Add(id, tempEasyMessage);
            }
        }

        /// <summary>
        /// 取消订阅消息。
        /// </summary>
        /// <param name="id">要取消订阅的消息编号。</param>
        /// <param name="message">要取消订阅的消息。</param>
        public Void UnSubscribeMessage(Int32 id, EasyFrameworkAction message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction tempMessageListInfo = (EasyFrameworkAction) msg.MessageListInfo;
                tempMessageListInfo -= message;
                if (tempMessageListInfo.GetInvocationList().Length <= 0)
                {
                    EasyReferencePool.ReleaseReference((EasyMessage) msg);
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
        public Void UnSubscribeMessage<TMessage>(Int32 id, EasyFrameworkAction<TMessage> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache1.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage> tempMessageListInfo = (EasyFrameworkAction<TMessage>) msg.MessageListInfo;
                tempMessageListInfo -= message;
                if (tempMessageListInfo.GetInvocationList().Length <= 0)
                {
                    EasyReferencePool.ReleaseReference((EasyMessage<TMessage>) msg);
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
        public Void UnSubscribeMessage<TMessage1, TMessage2>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache2.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2>) msg.MessageListInfo;
                tempMessageListInfo -= message;
                if (tempMessageListInfo.GetInvocationList().Length <= 0)
                {
                    EasyReferencePool.ReleaseReference((EasyMessage<TMessage1, TMessage2>) msg);
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
        public Void UnSubscribeMessage<TMessage1, TMessage2, TMessage3>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache3.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2, TMessage3> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2, TMessage3>) msg.MessageListInfo;
                tempMessageListInfo -= message;
                if (tempMessageListInfo.GetInvocationList().Length <= 0)
                {
                    EasyReferencePool.ReleaseReference((EasyMessage<TMessage1, TMessage2, TMessage3>) msg);
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
        public Void UnSubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache4.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4>) msg.MessageListInfo;
                tempMessageListInfo -= message;
                if (tempMessageListInfo.GetInvocationList().Length <= 0)
                {
                    EasyReferencePool.ReleaseReference((EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4>) msg);
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
        public Void UnSubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache5.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>) msg.MessageListInfo;
                tempMessageListInfo -= message;
                if (tempMessageListInfo.GetInvocationList().Length <= 0)
                {
                    EasyReferencePool.ReleaseReference((EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>) msg);
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
        public Void UnSubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache6.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>) msg.MessageListInfo;
                tempMessageListInfo -= message;
                if (tempMessageListInfo.GetInvocationList().Length <= 0)
                {
                    EasyReferencePool.ReleaseReference((EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>) msg);
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
        public Void UnSubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> message)
        {
            if (message == null)
            {
                throw new EasyFrameworkException("类型为空的要订阅的消息信息是无效的");
            }

            if (m_MessageCache7.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>) msg.MessageListInfo;
                tempMessageListInfo -= message;
                if (tempMessageListInfo.GetInvocationList().Length <= 0)
                {
                    EasyReferencePool.ReleaseReference((EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>) msg);
                    m_MessageCache7.Remove(id);
                }
            }
        }

        /// <summary>
        /// 发送消息 - 线程安全模式。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        public Void SendMessage(Int32 id)
        {
        }

        /// <summary>
        /// 发送消息 - 线程安全模式。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        /// <param name="message">要发送的信息。</param>
        /// <typeparam name="TMessage">要发送的消息信息类型。</typeparam>
        public Void SendMessage<TMessage>(Int32 id, TMessage message)
        {
        }

        /// <summary>
        /// 发送消息 - 线程安全模式。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        /// <param name="message1">要发送的信息 1。</param>
        /// <param name="message2">要发送的信息 2。</param>
        /// <typeparam name="TMessage1">要发送的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要发送的消息信息类型 2。</typeparam>
        public Void SendMessage<TMessage1, TMessage2>(Int32 id, TMessage1 message1, TMessage2 message2)
        {
        }

        /// <summary>
        /// 发送消息 - 线程安全模式。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        /// <param name="message1">要发送的信息 1。</param>
        /// <param name="message2">要发送的信息 2。</param>
        /// <param name="message3">要发送的信息 3。</param>
        /// <typeparam name="TMessage1">要发送的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要发送的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要发送的消息信息类型 3。</typeparam>
        public Void SendMessage<TMessage1, TMessage2, TMessage3>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3)
        {
        }

        /// <summary>
        /// 发送消息 - 线程安全模式。
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
        public Void SendMessage<TMessage1, TMessage2, TMessage3, TMessage4>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4)
        {
        }

        /// <summary>
        /// 发送消息 - 线程安全模式。
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
        public Void SendMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4, TMessage5 message5)
        {
        }

        /// <summary>
        /// 发送消息 - 线程安全模式。
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
        public Void SendMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4, TMessage5 message5, TMessage6 message6)
        {
        }

        /// <summary>
        /// 发送消息 - 线程安全模式。
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
        public Void SendMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4, TMessage5 message5, TMessage6 message6, TMessage7 message7)
        {
        }

        /// <summary>
        /// 发送消息 - 立即发送模式。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        public Void SendMessageNow(Int32 id)
        {
            if (m_MessageCache.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction tempMessageListInfo = (EasyFrameworkAction) msg.MessageListInfo;
                tempMessageListInfo?.Invoke();
            }
            else
            {
                throw new EasyFrameworkException($"未订阅消息编号为 {id} 的无参数类型消息");
            }
        }

        /// <summary>
        /// 发送消息 - 立即发送模式。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        /// <param name="message">要发送的信息。</param>
        /// <typeparam name="TMessage">要发送的消息信息类型。</typeparam>
        public Void SendMessageNow<TMessage>(Int32 id, TMessage message)
        {
            if (m_MessageCache1.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage> tempMessageListInfo = (EasyFrameworkAction<TMessage>) msg.MessageListInfo;
                tempMessageListInfo?.Invoke(message);
            }
            else
            {
                throw new EasyFrameworkException($"未订阅消息编号为 {id} 的 {typeof(TMessage).FullName} 参数类型消息");
            }
        }

        /// <summary>
        /// 发送消息 - 立即发送模式。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        /// <param name="message1">要发送的信息 1。</param>
        /// <param name="message2">要发送的信息 2。</param>
        /// <typeparam name="TMessage1">要发送的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要发送的消息信息类型 2。</typeparam>
        public Void SendMessageNow<TMessage1, TMessage2>(Int32 id, TMessage1 message1, TMessage2 message2)
        {
            if (m_MessageCache2.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2>) msg.MessageListInfo;
                tempMessageListInfo?.Invoke(message1, message2);
            }
            else
            {
                throw new EasyFrameworkException($"未订阅消息编号为 {id} 的 {typeof(TMessage1).FullName} {typeof(TMessage2).FullName} 参数类型消息");
            }
        }

        /// <summary>
        /// 发送消息 - 立即发送模式。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        /// <param name="message1">要发送的信息 1。</param>
        /// <param name="message2">要发送的信息 2。</param>
        /// <param name="message3">要发送的信息 3。</param>
        /// <typeparam name="TMessage1">要发送的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要发送的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要发送的消息信息类型 3。</typeparam>
        public Void SendMessageNow<TMessage1, TMessage2, TMessage3>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3)
        {
            if (m_MessageCache3.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2, TMessage3> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2, TMessage3>) msg.MessageListInfo;
                tempMessageListInfo?.Invoke(message1, message2, message3);
            }
            else
            {
                throw new EasyFrameworkException($"未订阅消息编号为 {id} 的 {typeof(TMessage1).FullName} {typeof(TMessage2).FullName} {typeof(TMessage3).FullName} 参数类型消息");
            }
        }

        /// <summary>
        /// 发送消息 - 立即发送模式。
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
        public Void SendMessageNow<TMessage1, TMessage2, TMessage3, TMessage4>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4)
        {
            if (m_MessageCache4.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4>) msg.MessageListInfo;
                tempMessageListInfo?.Invoke(message1, message2, message3, message4);
            }
            else
            {
                throw new EasyFrameworkException($"未订阅消息编号为 {id} 的 {typeof(TMessage1).FullName} {typeof(TMessage2).FullName} {typeof(TMessage3).FullName} {typeof(TMessage4).FullName} 参数类型消息");
            }
        }

        /// <summary>
        /// 发送消息 - 立即发送模式。
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
        public Void SendMessageNow<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4, TMessage5 message5)
        {
            if (m_MessageCache5.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>) msg.MessageListInfo;
                tempMessageListInfo?.Invoke(message1, message2, message3, message4, message5);
            }
            else
            {
                throw new EasyFrameworkException($"未订阅消息编号为 {id} 的 {typeof(TMessage1).FullName} {typeof(TMessage2).FullName} {typeof(TMessage3).FullName} {typeof(TMessage4).FullName} {typeof(TMessage5).FullName} 参数类型消息");
            }
        }

        /// <summary>
        /// 发送消息 - 立即发送模式。
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
        public Void SendMessageNow<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4, TMessage5 message5, TMessage6 message6)
        {
            if (m_MessageCache6.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>) msg.MessageListInfo;
                tempMessageListInfo?.Invoke(message1, message2, message3, message4, message5, message6);
            }
            else
            {
                throw new EasyFrameworkException($"未订阅消息编号为 {id} 的 {typeof(TMessage1).FullName} {typeof(TMessage2).FullName} {typeof(TMessage3).FullName} {typeof(TMessage4).FullName} {typeof(TMessage5).FullName} {typeof(TMessage6).FullName} 参数类型消息");
            }
        }

        /// <summary>
        /// 发送消息 - 立即发送模式。
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
        public Void SendMessageNow<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4, TMessage5 message5, TMessage6 message6, TMessage7 message7)
        {
            if (m_MessageCache7.TryGetValue(id, out IEasyMessage msg))
            {
                EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> tempMessageListInfo = (EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>) msg.MessageListInfo;
                tempMessageListInfo?.Invoke(message1, message2, message3, message4, message5, message6, message7);
            }
            else
            {
                throw new EasyFrameworkException($"未订阅消息编号为 {id} 的 {typeof(TMessage1).FullName} {typeof(TMessage2).FullName} {typeof(TMessage3).FullName} {typeof(TMessage4).FullName} {typeof(TMessage5).FullName} {typeof(TMessage6).FullName} {typeof(TMessage7).FullName} 参数类型消息");
            }
        }
    }
}