# EasyFramework
 ![](https://img.shields.io/github/license/JomiXedYu/JxCode.CoreLib?style=for-the-badge)

Unity 开发库，每个模块可独立使用。

## Content
- [EasyFramework](#EasyFramework)
  - [EasyCommon](#EasyCommon)
  - [EasyEvent](#EasyEvent)
  - [EasyMessage](#EasyMessage)
  - [EasyStateMachine](#EasyStateMachine)
  - [EasyProcedure](#EasyProcedure)
  - [EasyReference](#EasyReference)
  - [EasyDialog](#EasyDialog)

## EasyCommon
框架常用核心功能，方法、事件处理者、事件参数、异常类、框架模块基类、框架模块优先级与循环接口。

## EasyStateMachine
状态机模块，底层为状态模式作为驱动，下推状态机，底层为栈结构可以实现状态的下推与回滚。

## EasyProcedure
流程模块，使用有限状态机扩展出来的模块，包含了状态持有者等功能，可用于替代游戏生命周期消息。

## EasyMessage
消息模块，多元事件中心，可最高支持七种不同类型组合的事件发送。消息仅作为一个通知。

## EasyEvent
事件模块，触发会把事件源一起发送过来，底层是一个事件队列，事件仅作为一个动作，事件发生了才有通知。

## EasyReference
引用模块，降低内存碎片，重复回收利用类对象。

## EasyDialog
对话框模块，有打开成功、失败、完成等事件接口，底层为栈结构处理打开的对话框，并用列表缓存。
