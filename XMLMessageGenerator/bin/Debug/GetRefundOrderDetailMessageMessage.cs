//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ForexOrderService.Information
{
    using System;
    using ForexOrderService.Information.Core;
    
    
    /// <summary>
    /// 查询退款订单详情
    /// </summary>
    public class GetRefundOrderDetailMessageMessage
    {
        
        public const string INDEX_NAME = "GetRefundOrderDetailMessage";
        
        private const string _programException = "ProgramException";
        
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
        /// 4000 查询退款订单详情异常,异常信息:{0}
        /// </summary>
        public static Message ProgramException
        {
            get
            {
                return Index[_programException];
            }
        }
    }
}