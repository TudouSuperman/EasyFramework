//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

namespace EasyFramework.EasyCommon
{
    /// <summary>
    /// Easy Framework 事件处理者。
    /// </summary>
    /// <typeparam name="TEasyFrameworkEventArgs">事件参数类型。</typeparam>
    /// <param name="sender">事件发送者。</param>
    /// <param name="e">事件参数。</param>
    public delegate void EasyFrameworkEventHandler<in TEasyFrameworkEventArgs>(object sender, TEasyFrameworkEventArgs e) where TEasyFrameworkEventArgs : EasyFrameworkEventArgs;

    /// <summary>
    /// Easy Framework 事件处理者 - 允许附带一个奇怪的参数。
    /// </summary>
    /// <typeparam name="TEasyFrameworkEventArgs">事件参数类型。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs">奇怪的参数类型。</typeparam>
    /// <param name="sender">事件发送者。</param>
    /// <param name="e">事件参数。</param>
    /// <param name="args">奇怪的参数。</param>
    public delegate void EasyFrameworkEventHandler<in TEasyFrameworkEventArgs, in TEasyFrameworkArgs>(object sender, TEasyFrameworkEventArgs e, object args) where TEasyFrameworkEventArgs : EasyFrameworkEventArgs where TEasyFrameworkArgs : class, new();
}