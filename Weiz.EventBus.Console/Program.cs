using System;
using Weiz.EventBus;

namespace Weiz.EventBus.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sendEmailHandler = new UserAddedEventHandlerSendEmail();
            //var sendMessageHandler = new UserAddedEventHandlerSendMessage();
            //var sendRedbagsHandler = new UserAddedEventHandlerSendRedbags();
            //Weiz.EventBus.Core.EventBus.Instance.Subscribe(sendEmailHandler);
            //Weiz.EventBus.Core.EventBus.Instance.Subscribe(sendMessageHandler);
            ////Weiz.EventBus.Core.EventBus.Instance.Subscribe<UserGeneratorEvent>(sendRedbagsHandler);
            //Weiz.EventBus.Core.EventBus.Instance.Subscribe<OrderGeneratorEvent>(sendRedbagsHandler);

            //var userGeneratorEvent = new UserGeneratorEvent { UserId = Guid.NewGuid() };

            //System.Console.WriteLine("{0}注册成功", userGeneratorEvent.UserId);

            //Weiz.EventBus.Core.EventBus.Instance.Publish(userGeneratorEvent, CallBack);

            //var orderGeneratorEvent = new OrderGeneratorEvent { OrderId = Guid.NewGuid() };

            //System.Console.WriteLine("{0}下单成功", orderGeneratorEvent.OrderId);

            //Weiz.EventBus.Core.EventBus.Instance.Publish(orderGeneratorEvent, CallBack);


            Core.EventBus.InstanceForXml();
            Core.EventBus.Instance.Publish(new Events.UserGeneratorEvent { UserId = Guid.NewGuid() }, CallBack);

            System.Console.ReadKey();
        }

        private static void CallBack(Events.OrderGeneratorEvent orderGeneratorEvent, bool result, Exception ex)
        {
            System.Console.WriteLine("用户下单订阅事件执行成功");
        }

        public static void CallBack(Events.UserGeneratorEvent userGenerator, bool result, Exception ex)
        {
            System.Console.WriteLine("用户注册订阅事件执行成功");
        }
    }
}
