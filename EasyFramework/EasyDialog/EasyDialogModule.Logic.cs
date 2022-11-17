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
    internal sealed partial class EasyDialogModule
    {
        /// <summary>
        /// 获取当前对话框。
        /// </summary>
        public IEasyDialog CurrentOpenDialog => m_CurrentOpenDialog;

        /// <summary>
        /// 打开对话框成功事件。
        /// </summary>
        public event EasyFrameworkEventHandler<EasyFrameworkEventArgs> OpenDialogSuccess
        {
            add => m_OpenDialogSuccess += value;
            remove => m_OpenDialogSuccess -= value;
        }

        /// <summary>
        /// 打开对话框失败事件。
        /// </summary>
        public event EasyFrameworkEventHandler<EasyFrameworkEventArgs> OpenDialogFailure
        {
            add => m_OpenDialogFailure += value;
            remove => m_OpenDialogFailure -= value;
        }

        /// <summary>
        /// 关闭对话框完成事件。
        /// </summary>
        public event EasyFrameworkEventHandler<EasyFrameworkEventArgs> OpenDialogComplete
        {
            add => m_OpenDialogComplete += value;
            remove => m_OpenDialogComplete -= value;
        }

        /// <summary>
        /// 是否存在打开的对话框。
        /// </summary>
        /// <param name="dialogId">对话框编号。</param>
        public Boolean HasOpenDialog(Int32 dialogId)
        {
            if (m_OpenDialogs == null || m_OpenDialogs.Count <= 0)
            {
                return false;
            }

            foreach (EasyDialog itemEasyDialog in m_OpenDialogs)
            {
                if (((IEasyDialog) itemEasyDialog).DialogId == dialogId)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 是否存在打开的对话框。
        /// </summary>
        /// <param name="dialogName">对话框名称。</param>
        public Boolean HasOpenDialog(String dialogName)
        {
            if (m_OpenDialogs == null || m_OpenDialogs.Count <= 0)
            {
                return false;
            }

            foreach (EasyDialog itemEasyDialog in m_OpenDialogs)
            {
                if (((IEasyDialog) itemEasyDialog).DialogAssetName == dialogName)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 打开对话框。
        /// </summary>
        /// <param name="dialogId">要打开的对话框编号。</param>
        public void OpenDialog(Int32 dialogId)
        {
        }

        /// <summary>
        /// 打开对话框。
        /// </summary>
        /// <param name="dialogName">要打开的对话框名称。</param>
        public void OpenDialog(String dialogName)
        {
        }

        /// <summary>
        /// 打开多个对话框。
        /// </summary>
        /// <param name="dialogIds">要打开的多个对话框编号。</param>
        public void OpenDialogs(HashSet<Int32> dialogIds)
        {
        }

        /// <summary>
        /// 打开多个对话框。
        /// </summary>
        /// <param name="dialogNames">要打开的多个对话框名称。</param>
        public void OpenDialogs(HashSet<String> dialogNames)
        {
        }

        /// <summary>
        /// 打开对话框。
        /// </summary>
        /// <param name="dialogId">要打开的对话框编号。</param>
        /// <param name="userData">用户自定义数据。</param>
        public void OpenDialog(Int32 dialogId, Object userData)
        {
        }

        /// <summary>
        /// 打开对话框。
        /// </summary>
        /// <param name="dialogName">要打开的对话框名称。</param>
        /// <param name="userData">用户自定义数据。</param>
        public void OpenDialog(String dialogName, Object userData)
        {
        }

        /// <summary>
        /// 打开多个对话框。
        /// </summary>
        /// <param name="dialogIds">要打开的多个对话框编号。</param>
        /// <param name="userData">用户自定义数据。</param>
        public void OpenDialogs(HashSet<Int32> dialogIds, Object userData)
        {
        }

        /// <summary>
        /// 打开多个对话框。
        /// </summary>
        /// <param name="dialogNames">要打开的多个对话框名称。</param>
        /// <param name="userData">用户自定义数据。</param>
        public void OpenDialogs(HashSet<String> dialogNames, Object userData)
        {
        }

        /// <summary>
        /// 打开对话框。
        /// </summary>
        /// <param name="dialogId">要打开的对话框编号。</param>
        /// <param name="userData">用户自定义数据。</param>
        /// <param name="isOpenComplete">是否打开完成。</param>
        public void OpenDialog(Int32 dialogId, Object userData, EasyFrameworkAction<Boolean> isOpenComplete)
        {
        }

        /// <summary>
        /// 打开对话框。
        /// </summary>
        /// <param name="dialogName">要打开的对话框名称。</param>
        /// <param name="userData">用户自定义数据。</param>
        /// <param name="isOpenComplete">是否打开完成。</param>
        public void OpenDialog(String dialogName, Object userData, EasyFrameworkAction<Boolean> isOpenComplete)
        {
        }

        /// <summary>
        /// 打开多个对话框。
        /// </summary>
        /// <param name="dialogIds">要打开的多个对话框编号。</param>
        /// <param name="userData">用户自定义数据。</param>
        /// <param name="isOpenComplete">是否打开完成。</param>
        public void OpenDialogs(HashSet<Int32> dialogIds, Object userData, EasyFrameworkAction<Boolean> isOpenComplete)
        {
        }

        /// <summary>
        /// 打开多个对话框。
        /// </summary>
        /// <param name="dialogNames">要打开的多个对话框名称。</param>
        /// <param name="userData">用户自定义数据。</param>
        /// <param name="isOpenComplete">是否打开完成。</param>
        public void OpenDialogs(HashSet<String> dialogNames, Object userData, EasyFrameworkAction<Boolean> isOpenComplete)
        {
        }

        /// <summary>
        /// 关闭对话框。
        /// </summary>
        /// <param name="dialogId">要关闭的对话框编号。</param>
        public void CloseDialog(Int32 dialogId)
        {
        }

        /// <summary>
        /// 关闭对话框。
        /// </summary>
        /// <param name="dialogName">要关闭的对话框名称。</param>
        public void CloseDialog(String dialogName)
        {
        }

        /// <summary>
        /// 关闭多个对话框。
        /// </summary>
        /// <param name="dialogIds">要关闭的对话框编号。</param>
        public void CloseDialog(HashSet<Int32> dialogIds)
        {
        }

        /// <summary>
        /// 关闭多个对话框。
        /// </summary>
        /// <param name="dialogNames">要关闭的对话框名称。</param>
        public void CloseDialog(HashSet<String> dialogNames)
        {
        }

        /// <summary>
        /// 关闭对话框。
        /// </summary>
        /// <param name="dialogId">要关闭的对话框编号。</param>
        /// <param name="userData">用户自定义数据。</param>
        public void CloseDialog(Int32 dialogId, Object userData)
        {
        }

        /// <summary>
        /// 关闭对话框。
        /// </summary>
        /// <param name="dialogName">要关闭的对话框名称。</param>
        /// <param name="userData">用户自定义数据。</param>
        public void CloseDialog(String dialogName, Object userData)
        {
        }

        /// <summary>
        /// 关闭多个对话框。
        /// </summary>
        /// <param name="dialogIds">要关闭的对话框编号。</param>
        /// <param name="userData">用户自定义数据。</param>
        public void CloseDialogs(HashSet<Int32> dialogIds, Object userData)
        {
        }

        /// <summary>
        /// 关闭多个对话框。
        /// </summary>
        /// <param name="dialogNames">要关闭的对话框名称。</param>
        /// <param name="userData">用户自定义数据。</param>
        public void CloseDialogs(HashSet<String> dialogNames, Object userData)
        {
        }

        /// <summary>
        /// 关闭对话框。
        /// </summary>
        /// <param name="dialogId">要关闭的对话框编号。</param>
        /// <param name="userData">用户自定义数据。</param>
        /// <param name="isCloseComplete">是否关闭完成。</param>
        public void CloseDialog(Int32 dialogId, Object userData, EasyFrameworkAction<Boolean> isCloseComplete)
        {
        }

        /// <summary>
        /// 关闭对话框。
        /// </summary>
        /// <param name="dialogName">要关闭的对话框名称。</param>
        /// <param name="userData">用户自定义数据。</param>
        /// <param name="isCloseComplete">是否关闭完成。</param>
        public void CloseDialog(String dialogName, Object userData, EasyFrameworkAction<Boolean> isCloseComplete)
        {
        }

        /// <summary>
        /// 关闭多个对话框。
        /// </summary>
        /// <param name="dialogIds">要关闭的对话框编号。</param>
        /// <param name="userData">用户自定义数据。</param>
        /// <param name="isCloseComplete">是否关闭完成。</param>
        public void CloseDialogs(HashSet<Int32> dialogIds, Object userData, EasyFrameworkAction<Boolean> isCloseComplete)
        {
        }

        /// <summary>
        /// 关闭多个对话框。
        /// </summary>
        /// <param name="dialogNames">要关闭的对话框名称。</param>
        /// <param name="userData">用户自定义数据。</param>
        /// <param name="isCloseComplete">是否关闭完成。</param>
        public void CloseDialogs(HashSet<String> dialogNames, Object userData, EasyFrameworkAction<Boolean> isCloseComplete)
        {
        }
    }
}