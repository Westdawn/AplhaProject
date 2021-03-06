//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Forex.MgmtPlatform.Service.Information
{
    using System;
    using Forex.MgmtPlatform.Service.Information.Core;
    
    
    /// <summary>
    /// 历史牌价
    /// </summary>
    public class GetPlatformSalePriceHistoryListMessage
    {
        
        public const string INDEX_NAME = "GetPlatformSalePriceHistoryList";
        
        private const string _programException = "ProgramException";
        
        private const string _pageNoLess0 = "PageNoLess0";
        
        private const string _pageSizeLess0 = "PageSizeLess0";
        
        private const string _noEndTime = "NoEndTime";
        
        private const string _noStartTime = "NoStartTime";
        
        private static MessageIndex _index;
        
        /// <summary>
        /// 索引属性
        /// </summary>
        private static MessageIndex Index
        {
            get
            {
                return _index ?? (_index = MessageCache.GetIndex(INDEX_NAME));
            }
        }
        
        /// <summary>
        /// 2100 服务异常:{0}
        /// </summary>
        public static Message ProgramException
        {
            get
            {
                return Index[_programException];
            }
        }
        
        /// <summary>
        /// 2101 数据列表页码必须大于0！
        /// </summary>
        public static Message PageNoLess0
        {
            get
            {
                return Index[_pageNoLess0];
            }
        }
        
        /// <summary>
        /// 2102 数据列表页大小必须大于0！
        /// </summary>
        public static Message PageSizeLess0
        {
            get
            {
                return Index[_pageSizeLess0];
            }
        }
        
        /// <summary>
        /// 2103 没有结束时间！
        /// </summary>
        public static Message NoEndTime
        {
            get
            {
                return Index[_noEndTime];
            }
        }
        
        /// <summary>
        /// 2104 没有开始时间！
        /// </summary>
        public static Message NoStartTime
        {
            get
            {
                return Index[_noStartTime];
            }
        }
    }
}
