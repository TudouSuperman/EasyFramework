//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using EasyFramework.EasyCommon;

namespace EasyFramework.EasyMessage
{
    /// <summary>
    /// 消息模块。
    /// </summary>
    public interface IEasyMessageModule
    {
        /// <summary>
        /// 订阅消息。
        /// </summary>
        /// <param name="id">要订阅的消息编号。</param>
        /// <param name="message">要订阅的消息。</param>
        void SubscribeMessage(Int32 id, EasyFrameworkAction message);

        /// <summary>
        /// 订阅消息。
        /// </summary>
        /// <param name="id">要订阅的消息编号。</param>
        /// <param name="message">要订阅的消息。</param>
        /// <typeparam name="TMessage">要订阅的消息信息类型。</typeparam>
        void SubscribeMessage<TMessage>(Int32 id, EasyFrameworkAction<TMessage> message);

        /// <summary>
        /// 订阅消息。
        /// </summary>
        /// <param name="id">要订阅的消息编号。</param>
        /// <param name="message">要订阅的消息。</param>
        /// <typeparam name="TMessage1">要订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要订阅的消息信息类型 2。</typeparam>
        void SubscribeMessage<TMessage1, TMessage2>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2> message);

        /// <summary>
        /// 订阅消息。
        /// </summary>
        /// <param name="id">要订阅的消息编号。</param>
        /// <param name="message">要订阅的消息。</param>
        /// <typeparam name="TMessage1">要订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要订阅的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要订阅的消息信息类型 3。</typeparam>
        void SubscribeMessage<TMessage1, TMessage2, TMessage3>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3> message);

        /// <summary>
        /// 订阅消息。
        /// </summary>
        /// <param name="id">要订阅的消息编号。</param>
        /// <param name="message">要订阅的消息。</param>
        /// <typeparam name="TMessage1">要订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要订阅的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要订阅的消息信息类型 3。</typeparam>
        /// <typeparam name="TMessage4">要订阅的消息信息类型 4。</typeparam>
        void SubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4> message);

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
        void SubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> message);

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
        void SubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> message);

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
        void SubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> message);

        /// <summary>
        /// 取消订阅消息。
        /// </summary>
        /// <param name="id">要取消订阅的消息编号。</param>
        /// <param name="message">要取消订阅的消息。</param>
        void UnSubscribeMessage(Int32 id, EasyFrameworkAction message);

        /// <summary>
        /// 取消订阅消息。
        /// </summary>
        /// <param name="id">要取消订阅的消息编号。</param>
        /// <param name="message">要取消订阅的消息。</param>
        /// <typeparam name="TMessage">要取消订阅的消息信息类型。</typeparam>
        void UnSubscribeMessage<TMessage>(Int32 id, EasyFrameworkAction<TMessage> message);

        /// <summary>
        /// 取消订阅消息。
        /// </summary>
        /// <param name="id">要取消订阅的消息编号。</param>
        /// <param name="message">要取消订阅的消息。</param>
        /// <typeparam name="TMessage1">要取消订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要取消订阅的消息信息类型 2。</typeparam>
        void UnSubscribeMessage<TMessage1, TMessage2>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2> message);

        /// <summary>
        /// 取消订阅消息。
        /// </summary>
        /// <param name="id">要取消订阅的消息编号。</param>
        /// <param name="message">要取消订阅的消息。</param>
        /// <typeparam name="TMessage1">要取消订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要取消订阅的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要取消订阅的消息信息类型 3。</typeparam>
        void UnSubscribeMessage<TMessage1, TMessage2, TMessage3>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3> message);

        /// <summary>
        /// 取消订阅消息。
        /// </summary>
        /// <param name="id">要取消订阅的消息编号。</param>
        /// <param name="message">要取消订阅的消息。</param>
        /// <typeparam name="TMessage1">要取消订阅的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要取消订阅的消息信息类型 2。</typeparam>
        /// <typeparam name="TMessage3">要取消订阅的消息信息类型 3。</typeparam>
        /// <typeparam name="TMessage4">要取消订阅的消息信息类型 4。</typeparam>
        void UnSubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4> message);

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
        void UnSubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5> message);

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
        void UnSubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6> message);

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
        void UnSubscribeMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>(Int32 id, EasyFrameworkAction<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7> message);

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        void SendMessage(Int32 id);

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        /// <param name="message">要发送的信息。</param>
        /// <typeparam name="TMessage">要发送的消息信息类型。</typeparam>
        void SendMessage<TMessage>(Int32 id, TMessage message);

        /// <summary>
        /// 发送消息。
        /// </summary>
        /// <param name="id">要发送消息的编号。</param>
        /// <param name="message1">要发送的信息 1。</param>
        /// <param name="message2">要发送的信息 2。</param>
        /// <typeparam name="TMessage1">要发送的消息信息类型 1。</typeparam>
        /// <typeparam name="TMessage2">要发送的消息信息类型 2。</typeparam>
        void SendMessage<TMessage1, TMessage2>(Int32 id, TMessage1 message1, TMessage2 message2);

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
        void SendMessage<TMessage1, TMessage2, TMessage3>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3);

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
        void SendMessage<TMessage1, TMessage2, TMessage3, TMessage4>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4);

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
        void SendMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4, TMessage5 message5);

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
        void SendMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4, TMessage5 message5, TMessage6 message6);

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
        void SendMessage<TMessage1, TMessage2, TMessage3, TMessage4, TMessage5, TMessage6, TMessage7>(Int32 id, TMessage1 message1, TMessage2 message2, TMessage3 message3, TMessage4 message4, TMessage5 message5, TMessage6 message6, TMessage7 message7);
    }
}