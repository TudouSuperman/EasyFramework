//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;

namespace EasyFramework.EasyDialog
{
    /// <summary>
    /// 对话框辅助器接口。
    /// </summary>
    public interface IEasyDialogHelper
    {
        /// <summary>
        /// 实例化对话框。
        /// </summary>
        /// <param name="dialogAsset">要实例化的对话框资源。</param>
        /// <returns>实例化后的对话框。</returns>
        Object InstantiateDialog(Object dialogAsset);

        /// <summary>
        /// 创建对话框。
        /// </summary>
        /// <param name="dialogInstance">对话框实例。</param>
        /// <param name="userData">用户自定义数据。</param>
        /// <returns></returns>
        IEasyDialog CreateDialog(Object dialogInstance, Object userData);

        /// <summary>
        /// 释放对话框。
        /// </summary>
        /// <param name="dialogAsset">要释放的对话框资源。</param>
        /// <param name="dialogInstance">要释放的对话框实例。</param>
        void ReleaseDialog(Object dialogAsset, Object dialogInstance);
    }
}