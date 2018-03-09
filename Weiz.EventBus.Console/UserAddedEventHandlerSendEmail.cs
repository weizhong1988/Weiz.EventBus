/****************************************************************
** 文件名:   UserAddedEventHandlerSendEmail.cs
** 主要类:   UserAddedEventHandlerSendEmail类  
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

using Weiz.EventBus.Core;

namespace Weiz.EventBus.Console
{
    /// <summary>
    /// send email
    /// </summary>
    public class UserAddedEventHandlerSendEmail : IEventHandler<UserGeneratorEvent>
    {

        public void Handle(UserGeneratorEvent tEvent)
        {
            System.Console.WriteLine(string.Format("{0}的邮件已发送", tEvent.UserId));
        }
    }

    /// <summary>
    /// send message.
    /// </summary>
    public class UserAddedEventHandlerSendMessage : IEventHandler<UserGeneratorEvent>
    {

        public void Handle(UserGeneratorEvent tEvent)
        {
            System.Console.WriteLine(string.Format("{0}的短信已发送", tEvent.UserId));
        }
    }

    /// <summary>
    /// red bags.
    /// </summary>
    public class UserAddedEventHandlerSendRedbags : IEventHandler<UserGeneratorEvent>,IEventHandler<OrderGeneratorEvent>
    {
        public void Handle(OrderGeneratorEvent tEvent)
        {
            System.Console.WriteLine(string.Format("{0}的下单红包已发送", tEvent.OrderId));
        }

        public void Handle(UserGeneratorEvent tEvent)
        {
            System.Console.WriteLine(string.Format("{0}的注册红包已发送", tEvent.UserId));
        }
    }
}
