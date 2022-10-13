//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;
using EasyFramework.EasyCommon;

namespace EasyFramework.EasyReference
{
    /// <summary>
    /// 引用模块逻辑。
    /// </summary>
    internal sealed partial class EasyReferenceModule
    {
        /// <summary>
        /// 获取指定类型引用的数量。
        /// </summary>
        /// <typeparam name="TEasyReference">引用类型。</typeparam>
        /// <returns>指定类型引用的数量。</returns>
        public Int32 ReferenceCount<TEasyReference>() where TEasyReference : IEasyReference
        {
            return ReferenceCount(typeof(TEasyReference));
        }

        /// <summary>
        /// 获取指定类型引用的数量。
        /// </summary>
        /// <param name="referenceType">引用类型。</param>
        /// <returns>指定类型引用的数量。</returns>
        public Int32 ReferenceCount(Type referenceType)
        {
            return InternalGetReferenceCache(referenceType).ReferenceCount;
        }

        /// <summary>
        /// 检查是否存在指定类型引用。
        /// </summary>
        /// <typeparam name="TEasyReference">引用类型。</typeparam>
        /// <returns>是否存在指定类型引用。</returns>
        public Boolean CheckReference<TEasyReference>() where TEasyReference : IEasyReference
        {
            return CheckReference(typeof(TEasyReference));
        }

        /// <summary>
        /// 检查是否存在指定类型引用。
        /// </summary>
        /// <param name="referenceType">引用类型。</param>
        /// <returns>是否存在指定类型引用。</returns>
        public Boolean CheckReference(Type referenceType)
        {
            return InternalGetReferenceCache(referenceType).CheckReference();
        }

        /// <summary>
        /// 获取指定类型引用。
        /// </summary>
        /// <typeparam name="TEasyReference">引用类型。</typeparam>
        /// <returns>要获取的引用。</returns>
        public TEasyReference AcquireReference<TEasyReference>() where TEasyReference : IEasyReference
        {
            return (TEasyReference) AcquireReference(typeof(TEasyReference));
        }

        /// <summary>
        /// 获取指定类型引用。
        /// </summary>
        /// <param name="referenceType">引用类型。</param>
        /// <returns>要获取的引用。</returns>
        public IEasyReference AcquireReference(Type referenceType)
        {
            return InternalGetReferenceCache(referenceType).AcquireReference();
        }

        /// <summary>
        /// 释放指定类型引用。
        /// </summary>
        /// <param name="reference">引用。</param>
        public void ReleaseReference(IEasyReference reference)
        {
            InternalGetReferenceCache(reference.GetType()).ReleaseReference(reference);
        }

        /// <summary>
        /// 创建并缓存多个指定类型的引用。
        /// </summary>
        /// <typeparam name="TEasyReference">引用类型。</typeparam>
        /// <param name="count">数量。</param>
        public void AddReference<TEasyReference>(Int32 count) where TEasyReference : IEasyReference
        {
            AddReference(typeof(TEasyReference), count);
        }

        /// <summary>
        /// 创建并缓存多个指定类型的引用。
        /// </summary>
        /// <param name="referenceType">引用类型。</param>
        /// <param name="count">数量。</param>
        public void AddReference(Type referenceType, Int32 count)
        {
            InternalGetReferenceCache(referenceType).AddReference(count);
        }

        /// <summary>
        /// 移除多个指定类型的引用。
        /// </summary>
        /// <typeparam name="TEasyReference">引用类型。</typeparam>
        /// <param name="count">数量。</param>
        public void RemoveReference<TEasyReference>(Int32 count) where TEasyReference : IEasyReference
        {
            RemoveReference(typeof(TEasyReference), count);
        }

        /// <summary>
        /// 移除多个指定类型的引用。
        /// </summary>
        /// <param name="referenceType">引用类型。</param>
        /// <param name="count">数量。</param>
        public void RemoveReference(Type referenceType, Int32 count)
        {
            InternalGetReferenceCache(referenceType).RemoveReference(count);
        }

        /// <summary>
        /// 内部获取指定类型引用的缓存。
        /// </summary>
        /// <param name="referenceType">引用类型。</param>
        /// <returns>指定类型引用的缓存。</returns>
        private EasyReferenceCache InternalGetReferenceCache(Type referenceType)
        {
            InternalCheckReferenceType(referenceType);

            if (m_ReferenceCaches.TryGetValue(referenceType, out EasyReferenceCache referenceCache))
            {
                return referenceCache;
            }

            referenceCache = new EasyReferenceCache(referenceType);

            if (m_ReferenceCaches.ContainsKey(referenceType))
            {
                m_ReferenceCaches[referenceType] = referenceCache;
            }
            else
            {
                m_ReferenceCaches.Add(referenceType, referenceCache);
            }

            return referenceCache;
        }

        /// <summary>
        /// 内部校验引用类型。
        /// </summary>
        /// <param name="referenceType">引用类型。</param>
        private void InternalCheckReferenceType(Type referenceType)
        {
            if (referenceType == null)
            {
                throw new EasyFrameworkException("引用类型是无效的");
            }

            if (!referenceType.IsClass || referenceType.IsAbstract)
            {
                throw new EasyFrameworkException("引用类型不可以为抽象类型");
            }

            if (!typeof(IEasyReference).IsAssignableFrom(referenceType))
            {
                throw new EasyFrameworkException($"引用类型 '{referenceType.FullName}' 是无效的");
            }
        }
    }
}