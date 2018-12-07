/****************************************************************
** 文件名:   OrderGeneratorEvent.cs
** 主要类:   OrderGeneratorEvent类  
** Copyright (c) 中科虹霸有限公司
** 创建人:   gaoqy
** 日  期:   2017.3.10
** 修改人:   
** 日  期:   
** 修改内容： 
** 描  述:  虹膜数据的数据库操作
** 版  本:   
** 备  注:   
****************************************************************/
using System;
using Weiz.EventBus.Core;

namespace Weiz.EventBus.Events
{
    public class OrderGeneratorEvent:IEvent
    {
        /// <summary>
        /// 订单Id
        /// </summary>
        public Guid OrderId { get; set; }
    }
}
