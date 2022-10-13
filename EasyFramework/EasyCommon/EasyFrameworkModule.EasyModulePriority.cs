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
    /// Easy Framework 模块优先级。
    /// </summary>
    internal enum EasyModulePriority : Byte
    {
        Unknown = 0,
        EasyEventModule,
        EasyMessageModule,
        EasyProcedureModule,
        EasyStateMachineModule,
        EasyReferenceModule,
    }
}