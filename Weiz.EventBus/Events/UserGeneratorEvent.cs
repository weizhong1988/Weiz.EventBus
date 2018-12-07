/****************************************************************
** 文件名:   UserGenerator.cs
** 主要类:   UserGenerator类  
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
using System;
using Weiz.EventBus.Core;

namespace Weiz.EventBus.Events
{
    
    /// <summary>
    /// 模型对象
    /// </summary>
    public class UserGeneratorEvent : IEvent
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public Guid UserId { get; set; }
    }
}
