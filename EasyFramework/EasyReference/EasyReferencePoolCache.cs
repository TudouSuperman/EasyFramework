//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace EasyFramework.EasyReference
{
    /// <summary>
    /// Easy Framework 引用池缓存。
    /// </summary>
    internal sealed class EasyReferencePoolCache
    {
        private readonly Type m_ReferenceType;
        private readonly Queue<IEasyReference> m_References;

        /// <summary>
        /// 初始化引用池缓存的新实例。
        /// </summary>
        /// <param name="referenceType">引用缓存类型。</param>
        public EasyReferencePoolCache(Type referenceType)
        {
            m_ReferenceType = referenceType;
            m_References = new Queue<IEasyReference>();
        }

        /// <summary>
        /// 检查是否存在引用。
        /// </summary>
        /// <returns>是否存在引用。</returns>
        public Boolean CheckReference()
        {
            return m_References != null && m_References.Count > 0;
        }

        /// <summary>
        /// 获取引用。
        /// </summary>
        /// <returns>要获取的引用。</returns>
        public IEasyReference AcquireReference()
        {
            IEasyReference reference;

            if (CheckReference())
            {
                reference = m_References.Dequeue();
            }
            else
            {
                reference = (IEasyReference) Activator.CreateInstance(m_ReferenceType);
            }

            return reference;
        }

        /// <summary>
        /// 释放引用。
        /// </summary>
        /// <param name="reference">要释放的引用。</param>
        public void ReleaseReference(IEasyReference reference)
        {
            reference.ClearReference();
            m_References.Enqueue(reference);
        }

        /// <summary>
        /// 移除所有引用。
        /// </summary>
        public void RemoveReferences()
        {
            m_References.Clear();
        }
    }
}