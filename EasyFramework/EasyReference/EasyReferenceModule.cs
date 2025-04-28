//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/TudouSuperman/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using System.Collections.Generic;
using EasyFramework.EasyCommon;

namespace EasyFramework.EasyReference
{
    /// <summary>
    /// Easy Framework 引用模块。
    /// </summary>
    internal sealed partial class EasyReferenceModule : EasyFrameworkModule, IEasyReferenceModule
    {
        private readonly IDictionary<Type, EasyReferenceCache> m_ReferenceCacheDic;

        /// <summary>
        /// 引用模块优先级。
        /// </summary>
        public override EasyModulePriority Priority => EasyModulePriority.EasyReferenceModule;

        /// <summary>
        /// 初始化引用模块的新实例。
        /// </summary>
        public EasyReferenceModule()
        {
            m_ReferenceCacheDic = new Dictionary<Type, EasyReferenceCache>();
        }

        /// <summary>
        /// 引用模块关闭。
        /// </summary>
        protected internal override void EasyModuleShutdown()
        {
            foreach (KeyValuePair<Type, EasyReferenceCache> itemReferenceCache in m_ReferenceCacheDic)
            {
                itemReferenceCache.Value.RemoveReferences();
            }

            m_ReferenceCacheDic.Clear();
        }
    }
}