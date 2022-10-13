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
    /// Easy Framework 模块基类。
    /// </summary>
    internal abstract class EasyFrameworkModule
    {
        /// <summary>
        /// Easy Framework 模块优先级。
        /// </summary>
        protected internal virtual Int32 Priority => 0;

        /// <summary>
        /// Easy Framework 模块关闭。
        /// </summary>
        protected internal abstract Void EasyModuleShutdown();
    }
}