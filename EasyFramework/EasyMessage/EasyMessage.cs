//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/TudouSuperman/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using EasyFramework.EasyCommon;
using EasyFramework.EasyReference;

namespace EasyFramework.EasyMessage
{
    /// <summary>
    /// Easy Framework 消息。
    /// </summary>
    internal sealed class EasyMessage : IEasyReference, IEasyMessage
    {
        /// <summary>
        /// 消息列表。
        /// </summary>
        public event EasyFrameworkAction MessageList;

        /// <summary>
        /// 初始化消息的新实例。
        /// </summary>
        public EasyMessage()
        {
            MessageList = null;
        }

        /// <summary>
        /// 创建消息的新实例。
        /// </summary>
        /// <returns>创建的消息。</returns>
        public static EasyMessage Create(EasyFrameworkAction message)
        {
            EasyMessage msg = EasyReferencePool.AcquireReference<EasyMessage>();
            msg.MessageList = message;
            return msg;
        }

        /// <summary>
        /// 检查消息。
        /// </summary>
        public Boolean Check() => null == MessageList || MessageList.GetInvocationList().Length <= 0;

        /// <summary>
        /// 发送消息。
        /// </summary>
        public void Send() => MessageList?.Invoke();

        /// <summary>
        /// 清理 EasyMessage 引用。
        /// </summary>
        public void ClearReference()
        {
            MessageList = null;
        }
    }

    /// <summary>
    /// 消息。
    /// </summary>
    /// <typeparam name="TMessage">消息信息类型。</typeparam>
    internal sealed class EasyMessage<TMessage> : IEasyReference, IEasyMessage
    {
        /// <summary>
        /// 消息列表。
        /// </summary>
        public event EasyFrameworkAction<TMessage> MessageList;

        /// <summary>
        /// 初始化消息的新实例。
        /// </summary>
        public EasyMessage()
        {
            MessageList = null;
        }

        /// <summary>
        /// 创建消息的新实例。
        /// </summary>
        /// <param name="message">消息。</param>
        /// <returns>创建的消息。</returns>
        public static EasyMessage<TMessage> Create(EasyFrameworkAction<TMessage> message)
        {
            EasyMessage<TMessage> msg = EasyReferencePool.AcquireReference<EasyMessage<TMessage>>();
            msg.MessageList = message;
            return msg;
        }

        /// <summary>
        /// 检查消息。
        /// </summary>
        public Boolean Check() => null == MessageList || MessageList.GetInvocationList().Length <= 0;

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="message">消息内容。</param>
        public void Send(TMessage message) => MessageList?.Invoke(message);

        /// <summary>
        /// 清理 EasyMessage 引用。
        /// </summary>
        public void ClearReference()
        {
            MessageList = null;
        }
    }

    /// <summary>
    /// 消息。
    /// </summary>
    /// <typeparam name="TMessage1">消息信息类型 1。</typeparam>
    /// <typeparam name="TMessage2">消息信息类型 2。</typeparam>
    internal sealed class EasyMessage<TMessage1, TMessage2> : IEasyReference, IEasyMessage
    {
        /// <summary>
        /// 消息列表。
        /// </summary>
        public event EasyFrameworkAction<TMessage1, TMessage2> MessageList;

        /// <summary>
        /// 初始化消息的新实例。
        /// </summary>
        public EasyMessage()
        {
            MessageList = null;
        }

        /// <summary>
        /// 创建消息的新实例。
        /// </summary>
        /// <param name="message">消息。</param>
        /// <returns>创建的消息。</returns>
        public static EasyMessage<TMessage1, TMessage2> Create(EasyFrameworkAction<TMessage1, TMessage2> message)
        {
            EasyMessage<TMessage1, TMessage2> msg = EasyReferencePool.AcquireReference<EasyMessage<TMessage1, TMessage2>>();
            msg.MessageList = message;
            return msg;
        }

        /// <summary>
        /// 检查消息。
        /// </summary>
        public Boolean Check() => null == MessageList || MessageList.GetInvocationList().Length <= 0;

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="message1">消息内容1。</param>
        /// <param name="message2">消息内容2。</param>
        public void Send(TMessage1 message1, TMessage2 message2) => MessageList?.Invoke(message1, message2);

        /// <summary>
        /// 清理 EasyMessage 引用。
        /// </summary>
        public void ClearReference()
        {
            MessageList = null;
        }
    }

    /// <summary>
    /// 消息。
    /// </summary>
    /// <typeparam name="TMessage1">消息信息类型 1。</typeparam>
    /// <typeparam name="TMessage2">消息信息类型 2。</typeparam>
    /// <typeparam name="TMessage3">消息信息类型 3。</typeparam>
    internal sealed class EasyMessage<TMessage1, TMessage2, TMessage3> : IEasyReference, IEasyMessage
    {
        /// <summary>
        /// 消息列表。
        /// </summary>
        public event EasyFrameworkAction<TMessage1, TMessage2, TMessage3> MessageList;

        /// <summary>
        /// 初始化消息的新实例。
        /// </summary>
        public EasyMessage()
        {
            MessageList = null;
        }

        /// <summary>
        /// 创建消息的新实例。
        /// </summary>
        /// <param name="message">消息。</param>
        /// <returns>创建的消息。</returns>
        public static EasyMessage<TMessage1, TMessage2, TMessage3> Create(EasyFrameworkAction<TMessage1, TMessage2, TMessage3> message)
        {
            EasyMessage<TMessage1, TMessage2, TMessage3> msg = EasyReferencePool.AcquireReference<EasyMessage<TMessage1, TMessage2, TMessage3>>();
            msg.MessageList = message;
            return msg;
        }

        /// <summary>
        /// 检查消息。
        /// </summary>
        public Boolean Check() => null == MessageList || MessageList.GetInvocationList().Length <= 0;

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="message1">消息内容1。</param>
        /// <param name="message2">消息内容2。</param>
        /// <param name="message3">消息内容3。</param>
        public void Send(TMessage1 message1, TMessage2 message2, TMessage3 message3) => MessageList?.Invoke(message1, message2, message3);

        /// <summary>
        /// 清理 EasyMessage 引用。
        /// </summary>
        public void ClearReference()
        {
            MessageList = null;
        }
    }

    /// <summary>
    /// 消息。
    /// </summary>
    /// <typeparam name="TMessage1">消息信息类型 1。</typeparam>
    /// <typeparam name="TMessage2">消息信息类型 2。</typeparam>
    /// <typeparam name="TMessage3">消息信息类型 3。</typeparam>
    /// <typeparam name="TMessage4">消息信息类型 4。</typeparam>
    internal sealed class EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4> : IEasyReference, IEasyMessage
    {
        /// <summary>
        /// 消息列表。
        /// </summary>
        public event EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4> MessageList;

        /// <summary>
        /// 初始化消息的新实例。
        /// </summary>
        public EasyMessage()
        {
            MessageList = null;
        }

        /// <summary>
        /// 创建消息的新实例。
        /// </summary>
        /// <param name="message">消息。</param>
        /// <returns>创建的消息。</returns>
        public static EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4> Create(EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4> message)
        {
            EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4> msg = EasyReferencePool.AcquireReference<EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4>>();
            msg.MessageList = message;
            return msg;
        }

        /// <summary>
        /// 检查消息。
        /// </summary>
        public Boolean Check() => null == MessageList || MessageList.GetInvocationList().Length <= 0;

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="message1">消息内容1。</param>
        /// <param name="message2">消息内容2。</param>
        /// <param name="message3">消息内容3。</param>
        /// <param name="message4">消息内容4。</param>
        public void Send(TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4) => MessageList?.Invoke(message1, message2, message3, message4);

        /// <summary>
        /// 清理 EasyMessage 引用。
        /// </summary>
        public void ClearReference()
        {
            MessageList = null;
        }
    }

    /// <summary>
    /// 消息。
    /// </summary>
    /// <typeparam name="TMessage1">消息信息类型 1。</typeparam>
    /// <typeparam name="TMessage2">消息信息类型 2。</typeparam>
    /// <typeparam name="TMessage3">消息信息类型 3。</typeparam>
    /// <typeparam name="TMessage4">消息信息类型 4。</typeparam>
    /// <typeparam name="TMessage5">消息信息类型 5。</typeparam>
    internal sealed class EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> : IEasyReference, IEasyMessage
    {
        /// <summary>
        /// 消息列表。
        /// </summary>
        public event EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> MessageList;

        /// <summary>
        /// 初始化消息的新实例。
        /// </summary>
        public EasyMessage()
        {
            MessageList = null;
        }

        /// <summary>
        /// 创建消息的新实例。
        /// </summary>
        /// <param name="message">消息。</param>
        /// <returns>创建的消息。</returns>
        public static EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> Create(EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> message)
        {
            EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> msg = EasyReferencePool.AcquireReference<EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>>();
            msg.MessageList = message;
            return msg;
        }

        /// <summary>
        /// 检查消息。
        /// </summary>
        public Boolean Check() => null == MessageList || MessageList.GetInvocationList().Length <= 0;

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="message1">消息内容1。</param>
        /// <param name="message2">消息内容2。</param>
        /// <param name="message3">消息内容3。</param>
        /// <param name="message4">消息内容4。</param>
        /// <param name="message5">消息内容5。</param>
        public void Send(TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4, TMessage5 message5) => MessageList?.Invoke(message1, message2, message3, message4, message5);

        /// <summary>
        /// 清理 EasyMessage 引用。
        /// </summary>
        public void ClearReference()
        {
            MessageList = null;
        }
    }

    /// <summary>
    /// 消息。
    /// </summary>
    /// <typeparam name="TMessage1">消息信息类型 1。</typeparam>
    /// <typeparam name="TMessage2">消息信息类型 2。</typeparam>
    /// <typeparam name="TMessage3">消息信息类型 3。</typeparam>
    /// <typeparam name="TMessage4">消息信息类型 4。</typeparam>
    /// <typeparam name="TMessage5">消息信息类型 5。</typeparam>
    /// <typeparam name="TMessage6">消息信息类型 6。</typeparam>
    internal sealed class EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> : IEasyReference, IEasyMessage
    {
        /// <summary>
        /// 消息列表。
        /// </summary>
        public event EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> MessageList;

        /// <summary>
        /// 初始化消息的新实例。
        /// </summary>
        public EasyMessage()
        {
            MessageList = null;
        }

        /// <summary>
        /// 创建消息的新实例。
        /// </summary>
        /// <param name="message">消息。</param>
        /// <returns>创建的消息。</returns>
        public static EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> Create(EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> message)
        {
            EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> msg = EasyReferencePool.AcquireReference<EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>>();
            msg.MessageList = message;
            return msg;
        }

        /// <summary>
        /// 检查消息。
        /// </summary>
        public Boolean Check() => null == MessageList || MessageList.GetInvocationList().Length <= 0;

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="message1">消息内容1。</param>
        /// <param name="message2">消息内容2。</param>
        /// <param name="message3">消息内容3。</param>
        /// <param name="message4">消息内容4。</param>
        /// <param name="message5">消息内容5。</param>
        /// <param name="message6">消息内容6。</param>
        public void Send(TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4, TMessage5 message5, TMessage6 message6) => MessageList?.Invoke(message1, message2, message3, message4, message5, message6);

        /// <summary>
        /// 清理 EasyMessage 引用。
        /// </summary>
        public void ClearReference()
        {
            MessageList = null;
        }
    }

    /// <summary>
    /// 消息。
    /// </summary>
    /// <typeparam name="TMessage1">消息信息类型 1。</typeparam>
    /// <typeparam name="TMessage2">消息信息类型 2。</typeparam>
    /// <typeparam name="TMessage3">消息信息类型 3。</typeparam>
    /// <typeparam name="TMessage4">消息信息类型 4。</typeparam>
    /// <typeparam name="TMessage5">消息信息类型 5。</typeparam>
    /// <typeparam name="TMessage6">消息信息类型 6。</typeparam>
    /// <typeparam name="TMessage7">消息信息类型 7。</typeparam>
    internal sealed class EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> : IEasyReference, IEasyMessage
    {
        /// <summary>
        /// 消息列表。
        /// </summary>
        public event EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> MessageList;

        /// <summary>
        /// 初始化消息的新实例。
        /// </summary>
        public EasyMessage()
        {
            MessageList = null;
        }

        /// <summary>
        /// 创建消息的新实例。
        /// </summary>
        /// <param name="message">消息。</param>
        /// <returns>创建的消息。</returns>
        public static EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> Create(EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> message)
        {
            EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> msg = EasyReferencePool.AcquireReference<EasyMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>>();
            msg.MessageList = message;
            return msg;
        }

        /// <summary>
        /// 检查消息。
        /// </summary>
        public Boolean Check() => null == MessageList || MessageList.GetInvocationList().Length <= 0;

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="message1">消息内容1。</param>
        /// <param name="message2">消息内容2。</param>
        /// <param name="message3">消息内容3。</param>
        /// <param name="message4">消息内容4。</param>
        /// <param name="message5">消息内容5。</param>
        /// <param name="message6">消息内容6。</param>
        /// <param name="message7">消息内容7。</param>
        public void Send(TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4, TMessage5 message5, TMessage6 message6, TMessage7 message7) => MessageList?.Invoke(message1, message2, message3, message4, message5, message6, message7);

        /// <summary>
        /// 清理 EasyMessage 引用。
        /// </summary>
        public void ClearReference()
        {
            MessageList = null;
        }
    }
}