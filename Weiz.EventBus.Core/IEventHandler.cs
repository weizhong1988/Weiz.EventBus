/****************************************************************
** 文件名:   IEventHandler.cs
** 主要类:   IEventHandler  
** Copyright (c) 章为忠
** 创建人:   
** 日  期:   2017.3.10
** 修改人:   
** 日  期:   
** 修改内容： 
** 描  述:  
** 版  本:   
** 备  注:   
****************************************************************/

namespace Weiz.EventBus.Core
{
    /// <summary>
    /// 事件处理接口
    /// </summary>
    /// <typeparam name="TEvent">继承IEvent对象的事件源对象</typeparam>
    public interface IEventHandler<TEvent> where TEvent : IEvent
    {
        /// <summary>
        /// 处理程序
        /// </summary>
        /// <param name="evt"></param>
        void Handle(TEvent evt);

    }
}