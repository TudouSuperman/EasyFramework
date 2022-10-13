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
    /// Easy Framework 引用池。
    /// </summary>
    internal static class EasyReferencePool
    {
        private static readonly IDictionary<Type, EasyReferencePoolCache> References = new Dictionary<Type, EasyReferencePoolCache>();

        /// <summary>
        /// 检查是否存在指定类型引用。
        /// </summary>
        /// <typeparam name="TEasyReference">引用类型。</typeparam>
        /// <returns>是否存在指定类型引用。</returns>
        public static Boolean CheckReference<TEasyReference>() where TEasyReference : IEasyReference
        {
            return CheckReference(typeof(TEasyReference));
        }

        /// <summary>
        /// 检查是否存在指定类型引用。
        /// </summary>
        /// <param name="referenceType">引用类型。</param>
        /// <returns>是否存在指定类型引用。</returns>
        public static Boolean CheckReference(Type referenceType)
        {
            return InternalGetReferenceCache(referenceType).CheckReference();
        }

        /// <summary>
        /// 获取指定类型引用。
        /// </summary>
        /// <typeparam name="TEasyReference">引用类型。</typeparam>
        /// <returns>要获取的引用。</returns>
        public static TEasyReference AcquireReference<TEasyReference>() where TEasyReference : IEasyReference
        {
            return (TEasyReference) AcquireReference(typeof(TEasyReference));
        }

        /// <summary>
        /// 获取指定类型引用。
        /// </summary>
        /// <param name="referenceType">引用类型。</param>
        /// <returns>要获取的引用。</returns>
        public static IEasyReference AcquireReference(Type referenceType)
        {
            return InternalGetReferenceCache(referenceType).AcquireReference();
        }

        /// <summary>
        /// 释放指定类型引用。
        /// </summary>
        /// <param name="reference">引用。</param>
        public static void ReleaseReference(IEasyReference reference)
        {
            InternalGetReferenceCache(reference.GetType()).ReleaseReference(reference);
        }

        /// <summary>
        /// 清理所有引用。
        /// </summary>
        public static void ClearReferences()
        {
            foreach (KeyValuePair<Type, EasyReferencePoolCache> itemEasyReferencePoolCache in References)
            {
                itemEasyReferencePoolCache.Value.RemoveReferences();
            }

            References.Clear();
        }

        /// <summary>
        /// 内部获取指定类型引用的缓存。
        /// </summary>
        /// <param name="referenceType">引用类型。</param>
        /// <returns>指定类型引用的缓存。</returns>
        private static EasyReferencePoolCache InternalGetReferenceCache(Type referenceType)
        {
            if (References.TryGetValue(referenceType, out EasyReferencePoolCache referencePoolCache))
            {
                return referencePoolCache;
            }

            referencePoolCache = new EasyReferencePoolCache(referenceType);

            if (References.ContainsKey(referenceType))
            {
                References[referenceType] = referencePoolCache;
            }
            else
            {
                References.Add(referenceType, referencePoolCache);
            }

            return referencePoolCache;
        }
    }
}