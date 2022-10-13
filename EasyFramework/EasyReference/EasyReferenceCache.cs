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
    /// Easy Framework 引用缓存。
    /// </summary>
    internal sealed class EasyReferenceCache
    {
        /// <summary>
        /// 引用缓存类型。
        /// </summary>
        private readonly Type m_ReferenceType;

        /// <summary>
        /// 引用缓存队列。
        /// </summary>
        private readonly Queue<IEasyReference> m_References;

        /// <summary>
        /// 初始化引用缓存类的新实例。
        /// </summary>
        /// <param name="referenceType">引用缓存类型。</param>
        public EasyReferenceCache(Type referenceType)
        {
            m_ReferenceType = referenceType;
            m_References = new Queue<IEasyReference>();
        }

        /// <summary>
        /// 获取引用的数量。
        /// </summary>
        /// <returns>引用的数量。</returns>
        public Int32 ReferenceCount => m_References.Count;

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
        /// <param name="reference">引用。</param>
        public void ReleaseReference(IEasyReference reference)
        {
            reference.ClearReference();
            m_References.Enqueue(reference);
        }

        /// <summary>
        /// 创建并缓存多个引用。
        /// </summary>
        /// <param name="count">数量。</param>
        public void AddReference(Int32 count)
        {
            while (count-- > 0)
            {
                m_References.Enqueue((IEasyReference) Activator.CreateInstance(m_ReferenceType));
            }
        }

        /// <summary>
        /// 移除多个引用。
        /// </summary>
        /// <param name="count">数量。</param>
        public void RemoveReference(Int32 count)
        {
            if (m_References.Count <= count)
            {
                m_References.Clear();
            }
            else
            {
                while (count-- > 0)
                {
                    m_References.Dequeue();
                }
            }
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