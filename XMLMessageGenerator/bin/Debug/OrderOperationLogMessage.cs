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
    /// 订单业务操作日志
    /// </summary>
    public class OrderOperationLogMessage
    {
        
        public const string INDEX_NAME = "OrderOperationLog";
        
        private const string _programException = "ProgramException";
        
        private const string _orderOperationLogOrderIdNoLess0 = "OrderOperationLogOrderIdNoLess0";
        
        private const string _orderOperationLogStatusInValid = "OrderOperationLogStatusInValid";
        
        private const string _getOrderOperationLogListWithInValidOperationType = "GetOrderOperationLogListWithInValidOperationType";
        
        private const string _getOrderOperationLogListPageNoLess0 = "GetOrderOperationLogListPageNoLess0";
        
        private const string _getOrderOperationLogListPageSizeLess0 = "GetOrderOperationLogListPageSizeLess0";
        
        private const string _getOrderOperationLogListException = "GetOrderOperationLogListException";
        
        private const string _orderOperationLogDataIsNull = "OrderOperationLogDataIsNull";
        
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
        /// 2200 服务异常:{0}
        /// </summary>
        public static Message ProgramException
        {
            get
            {
                return Index[_programException];
            }
        }
        
        /// <summary>
        /// 2201 订单业务操作的订单编号必须大于0！
        /// </summary>
        public static Message OrderOperationLogOrderIdNoLess0
        {
            get
            {
                return Index[_orderOperationLogOrderIdNoLess0];
            }
        }
        
        /// <summary>
        /// 2202 订单业务操作状态不正确！
        /// </summary>
        public static Message OrderOperationLogStatusInValid
        {
            get
            {
                return Index[_orderOperationLogStatusInValid];
            }
        }
        
        /// <summary>
        /// 2203 获取订单操作日志列表时，BusinessOperation输入不正确的值！
        /// </summary>
        public static Message GetOrderOperationLogListWithInValidOperationType
        {
            get
            {
                return Index[_getOrderOperationLogListWithInValidOperationType];
            }
        }
        
        /// <summary>
        /// 2204 获取订单操作日志列表页码必须大于0
        /// </summary>
        public static Message GetOrderOperationLogListPageNoLess0
        {
            get
            {
                return Index[_getOrderOperationLogListPageNoLess0];
            }
        }
        
        /// <summary>
        /// 2205 获取订单操作日志列表每页大小必须大于0
        /// </summary>
        public static Message GetOrderOperationLogListPageSizeLess0
        {
            get
            {
                return Index[_getOrderOperationLogListPageSizeLess0];
            }
        }
        
        /// <summary>
        /// 2206 获取订单操作日志列表时发生异常: {0}
        /// </summary>
        public static Message GetOrderOperationLogListException
        {
            get
            {
                return Index[_getOrderOperationLogListException];
            }
        }
        
        /// <summary>
        /// 2207 没有查询到订单操作日志数据
        /// </summary>
        public static Message OrderOperationLogDataIsNull
        {
            get
            {
                return Index[_orderOperationLogDataIsNull];
            }
        }
    }
}
