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
    /// 接收结算结果
    /// </summary>
    public class ReceiveSettlementResultMessageMessage
    {
        
        public const string INDEX_NAME = "ReceiveSettlementResultMessage";
        
        private const string _programException = "ProgramException";
        
        private const string _invalidOrderID = "InvalidOrderID";
        
        private const string _invalidSettlementType = "InvalidSettlementType";
        
        private const string _orderNotFound = "OrderNotFound";
        
        private const string _refundOrderNotFound = "RefundOrderNotFound";
        
        private const string _getVendorInfoFailed = "GetVendorInfoFailed";
        
        private const string _updateOrderFailed = "UpdateOrderFailed";
        
        private const string _createOrderOperationLogFailed = "CreateOrderOperationLogFailed";
        
        private const string _createOrderProcesstTimelineFailed = "CreateOrderProcesstTimelineFailed";
        
        private const string _invalidOrderStatus = "InvalidOrderStatus";
        
        private const string _invalidRefundOrderStatus = "InvalidRefundOrderStatus";
        
        private const string _orderAlreadySettled = "OrderAlreadySettled";
        
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
        /// 3800 接收结算结果异常,异常信息:{0}
        /// </summary>
        public static Message ProgramException
        {
            get
            {
                return Index[_programException];
            }
        }
        
        /// <summary>
        /// 3801 OrderID必须大于0
        /// </summary>
        public static Message InvalidOrderID
        {
            get
            {
                return Index[_invalidOrderID];
            }
        }
        
        /// <summary>
        /// 3802 结算类型不正确, 1=售汇 2=结汇
        /// </summary>
        public static Message InvalidSettlementType
        {
            get
            {
                return Index[_invalidSettlementType];
            }
        }
        
        /// <summary>
        /// 3803 售汇订单不存在, 请检查OrderID是否正确
        /// </summary>
        public static Message OrderNotFound
        {
            get
            {
                return Index[_orderNotFound];
            }
        }
        
        /// <summary>
        /// 3804 结汇订单不存在, 请检查OrderID是否正确
        /// </summary>
        public static Message RefundOrderNotFound
        {
            get
            {
                return Index[_refundOrderNotFound];
            }
        }
        
        /// <summary>
        /// 3805 获取Vendor信息失败, 错误原因为{0}
        /// </summary>
        public static Message GetVendorInfoFailed
        {
            get
            {
                return Index[_getVendorInfoFailed];
            }
        }
        
        /// <summary>
        /// 3806 更新订单信息失败
        /// </summary>
        public static Message UpdateOrderFailed
        {
            get
            {
                return Index[_updateOrderFailed];
            }
        }
        
        /// <summary>
        /// 3807 插入订单操作日志失败, 原因为:{0}
        /// </summary>
        public static Message CreateOrderOperationLogFailed
        {
            get
            {
                return Index[_createOrderOperationLogFailed];
            }
        }
        
        /// <summary>
        /// 3808 插入订单Timeline失败
        /// </summary>
        public static Message CreateOrderProcesstTimelineFailed
        {
            get
            {
                return Index[_createOrderProcesstTimelineFailed];
            }
        }
        
        /// <summary>
        /// 3809 更新售汇订单结算状态时, 售汇订单状态必须是供应商已确认后
        /// </summary>
        public static Message InvalidOrderStatus
        {
            get
            {
                return Index[_invalidOrderStatus];
            }
        }
        
        /// <summary>
        /// 3810 更新结汇订单结算状态时, 结汇订单状态必须是供应商已确认
        /// </summary>
        public static Message InvalidRefundOrderStatus
        {
            get
            {
                return Index[_invalidRefundOrderStatus];
            }
        }
        
        /// <summary>
        /// 3811 订单已经结算过, 请不要重复调用
        /// </summary>
        public static Message OrderAlreadySettled
        {
            get
            {
                return Index[_orderAlreadySettled];
            }
        }
    }
}
