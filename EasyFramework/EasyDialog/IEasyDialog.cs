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
    /// Easy Framework 对话框接口。
    /// </summary>
    public interface IEasyDialog
    {
        /// <summary>
        /// 获取对话框编号。
        /// </summary>
        Int32 DialogId { get; }

        /// <summary>
        /// 获取对话框资源名称。
        /// </summary>
        String DialogAssetName { get; }

        /// <summary>
        /// 获取对话框实例。
        /// </summary>
        Object DialogHandle { get; }

        /// <summary>
        /// 获取对话框深度。
        /// </summary>
        Int32 DialogDepth { get; }

        /// <summary>
        /// 获取是否是暂停被覆盖的对话框。
        /// </summary>
        Boolean PauseCoveredDialog { get; }
    }
}