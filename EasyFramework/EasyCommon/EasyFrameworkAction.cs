//------------------------------------------------------------
// Easy Framework ??? ...最垃圾的框架...Fuck..!
// Copyright © 2022-2035 Shi Qi. All rights reserved.
// GitHub : https://github.com/ShiQi2022/EasyFramework
// E-mail : www.shiqi.com@gmail.com
//------------------------------------------------------------

using System;

namespace EasyFramework.EasyCommon
{
    /// <summary>
    /// Easy Framework 封装一个方法 - 该方法没有参数。
    /// </summary>
    public delegate Void EasyFrameworkAction();

    /// <summary>
    /// Easy Framework 封装一个方法 - 该方法具有一个参数。
    /// </summary>
    /// <typeparam name="TEasyFrameworkArgs">参数类型。</typeparam>
    /// <param name="args">参数。</param>
    public delegate Void EasyFrameworkAction<in TEasyFrameworkArgs>(TEasyFrameworkArgs args);

    /// <summary>
    /// Easy Framework 封装一个方法 - 该方法具有两个个参数。
    /// </summary>
    /// <typeparam name="TEasyFrameworkArgs1">参数类型1。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs2">参数类型2。</typeparam>
    /// <param name="args1">参数1。</param>
    /// <param name="args2">参数2。</param>
    public delegate Void EasyFrameworkAction<in TEasyFrameworkArgs1, in TEasyFrameworkArgs2>(TEasyFrameworkArgs1 args1, TEasyFrameworkArgs2 args2);

    /// <summary>
    /// Easy Framework 封装一个方法 - 该方法具有三个个参数。
    /// </summary>
    /// <typeparam name="TEasyFrameworkArgs1">参数类型1。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs2">参数类型2。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs3">参数类型3。</typeparam>
    /// <param name="args1">参数1。</param>
    /// <param name="args2">参数2。</param>
    /// <param name="args3">参数3。</param>
    public delegate Void EasyFrameworkAction<in TEasyFrameworkArgs1, in TEasyFrameworkArgs2, in TEasyFrameworkArgs3>(TEasyFrameworkArgs1 args1, TEasyFrameworkArgs2 args2, TEasyFrameworkArgs3 args3);

    /// <summary>
    /// Easy Framework 封装一个方法 - 该方法具有四个个参数。
    /// </summary>
    /// <typeparam name="TEasyFrameworkArgs1">参数类型1。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs2">参数类型2。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs3">参数类型3。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs4">参数类型4。</typeparam>
    /// <param name="args1">参数1。</param>
    /// <param name="args2">参数2。</param>
    /// <param name="args3">参数3。</param>
    /// <param name="args4">参数4。</param>
    public delegate Void EasyFrameworkAction<in TEasyFrameworkArgs1, in TEasyFrameworkArgs2, in TEasyFrameworkArgs3, in TEasyFrameworkArgs4>(TEasyFrameworkArgs1 args1, TEasyFrameworkArgs2 args2, TEasyFrameworkArgs3 args3, TEasyFrameworkArgs4 args4);

    /// <summary>
    /// Easy Framework 封装一个方法 - 该方法具有五个个参数。
    /// </summary>
    /// <typeparam name="TEasyFrameworkArgs1">参数类型1。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs2">参数类型2。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs3">参数类型3。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs4">参数类型4。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs5">参数类型5。</typeparam>
    /// <param name="args1">参数1。</param>
    /// <param name="args2">参数2。</param>
    /// <param name="args3">参数3。</param>
    /// <param name="args4">参数4。</param>
    /// <param name="args5">参数5。</param>
    public delegate Void EasyFrameworkAction<in TEasyFrameworkArgs1, in TEasyFrameworkArgs2, in TEasyFrameworkArgs3, in TEasyFrameworkArgs4, in TEasyFrameworkArgs5>(TEasyFrameworkArgs1 args1, TEasyFrameworkArgs2 args2, TEasyFrameworkArgs3 args3, TEasyFrameworkArgs4 args4, TEasyFrameworkArgs5 args5);

    /// <summary>
    /// Easy Framework 封装一个方法 - 该方法具有六个个参数。
    /// </summary>
    /// <typeparam name="TEasyFrameworkArgs1">参数类型1。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs2">参数类型2。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs3">参数类型3。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs4">参数类型4。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs5">参数类型5。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs6">参数类型6。</typeparam>
    /// <param name="args1">参数1。</param>
    /// <param name="args2">参数2。</param>
    /// <param name="args3">参数3。</param>
    /// <param name="args4">参数4。</param>
    /// <param name="args5">参数5。</param>
    /// <param name="args6">参数6。</param>
    public delegate Void EasyFrameworkAction<in TEasyFrameworkArgs1, in TEasyFrameworkArgs2, in TEasyFrameworkArgs3, in TEasyFrameworkArgs4, in TEasyFrameworkArgs5, in TEasyFrameworkArgs6>(TEasyFrameworkArgs1 args1, TEasyFrameworkArgs2 args2, TEasyFrameworkArgs3 args3, TEasyFrameworkArgs4 args4, TEasyFrameworkArgs5 args5, TEasyFrameworkArgs6 args6);

    /// <summary>
    /// Easy Framework 封装一个方法 - 该方法具有七个个参数。
    /// </summary>
    /// <typeparam name="TEasyFrameworkArgs1">参数类型1。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs2">参数类型2。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs3">参数类型3。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs4">参数类型4。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs5">参数类型5。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs6">参数类型6。</typeparam>
    /// <typeparam name="TEasyFrameworkArgs7">参数类型7。</typeparam>
    /// <param name="args1">参数1。</param>
    /// <param name="args2">参数2。</param>
    /// <param name="args3">参数3。</param>
    /// <param name="args4">参数4。</param>
    /// <param name="args5">参数5。</param>
    /// <param name="args6">参数6。</param>
    /// <param name="args7">参数7。</param>
    public delegate Void EasyFrameworkAction<in TEasyFrameworkArgs1, in TEasyFrameworkArgs2, in TEasyFrameworkArgs3, in TEasyFrameworkArgs4, in TEasyFrameworkArgs5, in TEasyFrameworkArgs6, in TEasyFrameworkArgs7>(TEasyFrameworkArgs1 args1, TEasyFrameworkArgs2 args2, TEasyFrameworkArgs3 args3, TEasyFrameworkArgs4 args4, TEasyFrameworkArgs5 args5, TEasyFrameworkArgs6 args6, TEasyFrameworkArgs7 args7);
}