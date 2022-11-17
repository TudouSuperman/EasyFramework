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
    /// Easy Framework 对话框基类。
    /// </summary>
    internal abstract class EasyDialog : IEasyDialog
    {
        /// <summary>
        /// 获取对话框编号。
        /// </summary>
        public Int32 DialogId { get; set; }

        /// <summary>
        /// 获取对话框资源名称。
        /// </summary>
        public String DialogAssetName { get; set; }

        /// <summary>
        /// 获取对话框实例。
        /// </summary>
        public Object DialogHandle { get; set; }

        /// <summary>
        /// 获取对话框深度。
        /// </summary>
        public Int32 DialogDepth { get; set; }

        /// <summary>
        /// 获取是否是暂停被覆盖的对话框。
        /// </summary>
        public Boolean PauseCoveredDialog { get; set; }

        /// <summary>
        /// 初始化对话框。
        /// </summary>
        /// <param name="dialogId">对话框编号。</param>
        /// <param name="dialogAssetName">对话框资源名称。</param>
        /// <param name="dialogHandle">对话框实例。</param>
        /// <param name="dialogDepth">对话框深度。</param>
        /// <param name="pauseCoveredDialog">是否是暂停被覆盖的对话框。</param>
        /// <param name="userData">用户自定义数据。</param>
        protected internal abstract void OnInitDialog(Int32 dialogId, String dialogAssetName, Object dialogHandle, Int32 dialogDepth, Boolean pauseCoveredDialog, Object userData);

        /// <summary>
        /// 对话框打开。
        /// </summary>
        /// <param name="userData">用户自定义数据。</param>
        protected internal abstract void OnOpenDialog(Object userData);

        /// <summary>
        /// 对话框轮询。
        /// </summary>
        /// <param name="logicTime">逻辑时间。</param>
        protected internal abstract void OnUpdateDialog(Single logicTime);

        /// <summary>
        /// 对话框关闭。
        /// </summary>
        /// <param name="userData">用户自定义数据。</param>
        protected internal abstract void OnCloseDialog(Object userData);

        /// <summary>
        /// 对话框销毁。
        /// </summary>
        protected internal abstract void OnDestroyDialog();

        /// <summary>
        /// 对话框暂停。
        /// </summary>
        protected internal abstract void OnPauseDialog();

        /// <summary>
        /// 对话框暂停恢复。
        /// </summary>
        protected internal abstract void OnResumeDialog();

        /// <summary>
        /// 对话框深度改变。
        /// </summary>
        /// <param name="dialogDepth">对话框深度。</param>
        protected internal abstract void OnDepthChanged(Int32 dialogDepth);
    }
}