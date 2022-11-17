//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using System.Collections.Generic;
using EasyFramework.EasyCommon;

namespace EasyFramework.EasyDialog
{
    /// <summary>
    /// Easy Framework 对话框模块。
    /// </summary>
    internal sealed partial class EasyDialogModule : EasyFrameworkModule, IEasyDialogModule, IEasyModuleUpdate
    {
        private readonly LinkedList<IEasyDialog> m_CacheDialogs;
        private readonly Stack<EasyDialog> m_OpenDialogs;
        private EasyDialog m_CurrentOpenDialog;
        private Boolean m_CurrentHasOpenDialog;
        private EasyFrameworkEventHandler<EasyFrameworkEventArgs> m_OpenDialogSuccess;
        private EasyFrameworkEventHandler<EasyFrameworkEventArgs> m_OpenDialogFailure;
        private EasyFrameworkEventHandler<EasyFrameworkEventArgs> m_OpenDialogComplete;

        /// <summary>
        /// 对话框模块优先级。
        /// </summary>
        public override EasyModulePriority Priority => EasyModulePriority.EasyDialogModule;

        /// <summary>
        /// 初始化对话框模块的新实例。
        /// </summary>
        public EasyDialogModule()
        {
            m_CacheDialogs = new LinkedList<IEasyDialog>();
            m_OpenDialogs = new Stack<EasyDialog>();
            m_CurrentOpenDialog = null;
            m_CurrentHasOpenDialog = false;
            m_OpenDialogSuccess = null;
            m_OpenDialogFailure = null;
            m_OpenDialogComplete = null;
        }

        /// <summary>
        /// 对话框模块关闭。
        /// </summary>
        protected internal override void EasyModuleShutdown()
        {
            m_OpenDialogSuccess = null;
            m_OpenDialogFailure = null;
            m_OpenDialogComplete = null;
            m_CurrentOpenDialog = null;
            m_CurrentHasOpenDialog = false;
            m_OpenDialogs.Clear();
            m_CacheDialogs.Clear();
        }

        /// <summary>
        /// 对话框模块轮询。
        /// </summary>
        /// <param name="logicTime">逻辑时间。</param>
        public void EasyModuleUpdate(Single logicTime)
        {
            if (m_CurrentHasOpenDialog == false)
            {
                return;
            }

            m_CurrentOpenDialog.OnUpdateDialog(logicTime);
        }
    }
}