//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;

namespace EasyFramework.EasyCommon
{
    /// <summary>
    /// Easy Framework 模块轮询。
    /// </summary>
    internal interface IEasyModuleUpdate
    {
        /// <summary>
        /// Easy Framework 模块轮询。
        /// </summary>
        /// <param name="logicTime">逻辑时间。</param>
        Void EasyModuleUpdate(Single logicTime);
    }
}