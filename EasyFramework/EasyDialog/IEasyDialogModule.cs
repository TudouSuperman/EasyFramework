//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using EasyFramework.EasyCommon;

namespace EasyFramework.EasyDialog
{
    /// <summary>
    /// Easy Framework 对话框模块。
    /// </summary>
    public interface IEasyDialogModule
    {
        /// <summary>
        /// 打开对话框。
        /// </summary>
        /// <param name="dialogName">要打开的对话框名称。</param>
        void OpenDialog(String dialogName);

        /// <summary>
        /// 打开对话框。
        /// </summary>
        /// <param name="dialogName">要打开的对话框名称。</param>
        /// <param name="userData">用户自定义数据。</param>
        void OpenDialog(String dialogName, Object userData);

        /// <summary>
        /// 关闭对话框。
        /// </summary>
        /// <param name="dialogName">要关闭的对话框名称。</param>
        void CloseDialog(String dialogName);

        /// <summary>
        /// 关闭对话框。
        /// </summary>
        /// <param name="dialogName">要关闭的对话框名称。</param>
        /// <param name="userData">用户自定义数据。</param>
        void CloseDialog(String dialogName, Object userData);
    }
}