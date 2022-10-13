//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;

namespace EasyFramework.EasyMessage
{
    /// <summary>
    /// 消息接口。
    /// </summary>
    public interface IEasyMessage
    {
        /// <summary>
        /// 获取消息列表信息。
        /// </summary>
        Delegate MessageListInfo { get; }
    }
}