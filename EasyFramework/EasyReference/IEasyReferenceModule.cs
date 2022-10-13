//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;

namespace EasyFramework.EasyReference
{
    /// <summary>
    /// 引用模块接口。
    /// </summary>
    public interface IEasyReferenceModule
    {
        /// <summary>
        /// 获取指定类型引用的数量。
        /// </summary>
        /// <typeparam name="TEasyReference">引用类型。</typeparam>
        /// <returns>指定类型引用的数量。</returns>
        Int32 ReferenceCount<TEasyReference>() where TEasyReference : IEasyReference;

        /// <summary>
        /// 获取指定类型引用的数量。
        /// </summary>
        /// <param name="referenceType">引用类型。</param>
        /// <returns>指定类型引用的数量。</returns>
        Int32 ReferenceCount(Type referenceType);

        /// <summary>
        /// 检查是否存在指定类型引用。
        /// </summary>
        /// <typeparam name="TEasyReference">引用类型。</typeparam>
        /// <returns>是否存在指定类型引用。</returns>
        Boolean CheckReference<TEasyReference>() where TEasyReference : IEasyReference;

        /// <summary>
        /// 检查是否存在指定类型引用。
        /// </summary>
        /// <param name="referenceType">引用类型。</param>
        /// <returns>是否存在指定类型引用。</returns>
        Boolean CheckReference(Type referenceType);

        /// <summary>
        /// 获取指定类型引用。
        /// </summary>
        /// <typeparam name="TEasyReference">引用类型。</typeparam>
        /// <returns>要获取的引用。</returns>
        TEasyReference AcquireReference<TEasyReference>() where TEasyReference : IEasyReference;

        /// <summary>
        /// 获取指定类型引用。
        /// </summary>
        /// <param name="referenceType">引用类型。</param>
        /// <returns>要获取的引用。</returns>
        IEasyReference AcquireReference(Type referenceType);

        /// <summary>
        /// 释放指定引用。
        /// </summary>
        /// <param name="reference">引用。</param>
        void ReleaseReference(IEasyReference reference);

        /// <summary>
        /// 创建并缓存多个指定类型的引用。
        /// </summary>
        /// <typeparam name="TEasyReference">引用类型。</typeparam>
        /// <param name="count">数量。</param>
        void AddReference<TEasyReference>(Int32 count) where TEasyReference : IEasyReference;

        /// <summary>
        /// 创建并缓存多个指定类型的引用。
        /// </summary>
        /// <param name="referenceType">引用类型。</param>
        /// <param name="count">数量。</param>
        void AddReference(Type referenceType, Int32 count);

        /// <summary>
        /// 移除多个指定类型的引用。
        /// </summary>
        /// <typeparam name="TEasyReference">引用类型。</typeparam>
        /// <param name="count">数量。</param>
        void RemoveReference<TEasyReference>(Int32 count) where TEasyReference : IEasyReference;

        /// <summary>
        /// 移除多个指定类型的引用。
        /// </summary>
        /// <param name="referenceType">引用类型。</param>
        /// <param name="count">数量。</param>
        void RemoveReference(Type referenceType, Int32 count);
    }
}