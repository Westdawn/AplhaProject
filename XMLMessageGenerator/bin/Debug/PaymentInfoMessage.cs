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
    /// 支付信息
    /// </summary>
    public class PaymentInfoMessage
    {
        
        public const string INDEX_NAME = "PaymentInfo";
        
        private const string _programException = "ProgramException";
        
        private const string _requestIsNull = "RequestIsNull";
        
        private const string _uIDIsNull = "UIDIsNull";
        
        private const string _orderListIsNull = "OrderListIsNull";
        
        private const string _orderIDLess0 = "OrderIDLess0";
        
        private const string _orderTypeIsSupport = "OrderTypeIsSupport";
        
        private const string _orderDetailIsNull = "OrderDetailIsNull";
        
        private const string _timeoutOrder = "TimeoutOrder";
        
        private const string _safeGovServiceTime = "SafeGovServiceTime";
        
        private const string _notInBranchServiceTime = "NotInBranchServiceTime";
        
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
        /// 2800 获取支付信息异常,异常信息:{0}
        /// </summary>
        public static Message ProgramException
        {
            get
            {
                return Index[_programException];
            }
        }
        
        /// <summary>
        /// 2801 获取支付请求不能为空
        /// </summary>
        public static Message RequestIsNull
        {
            get
            {
                return Index[_requestIsNull];
            }
        }
        
        /// <summary>
        /// 2802 用户名不能为空
        /// </summary>
        public static Message UIDIsNull
        {
            get
            {
                return Index[_uIDIsNull];
            }
        }
        
        /// <summary>
        /// 2803 订单列表不能为空
        /// </summary>
        public static Message OrderListIsNull
        {
            get
            {
                return Index[_orderListIsNull];
            }
        }
        
        /// <summary>
        /// 2804 订单ID不能为小于0
        /// </summary>
        public static Message OrderIDLess0
        {
            get
            {
                return Index[_orderIDLess0];
            }
        }
        
        /// <summary>
        /// 2805 暂不支持的订单类型
        /// </summary>
        public static Message OrderTypeIsSupport
        {
            get
            {
                return Index[_orderTypeIsSupport];
            }
        }
        
        /// <summary>
        /// 2806 没有可用订单信息
        /// </summary>
        public static Message OrderDetailIsNull
        {
            get
            {
                return Index[_orderDetailIsNull];
            }
        }
        
        /// <summary>
        /// 2807 订单已过最晚可支付时间
        /// </summary>
        public static Message TimeoutOrder
        {
            get
            {
                return Index[_timeoutOrder];
            }
        }
        
        /// <summary>
        /// 2808 外币兑换服务时间为{0}~{1}
        /// </summary>
        public static Message SafeGovServiceTime
        {
            get
            {
                return Index[_safeGovServiceTime];
            }
        }
        
        /// <summary>
        /// 2809 订单网点不在服务时间
        /// </summary>
        public static Message NotInBranchServiceTime
        {
            get
            {
                return Index[_notInBranchServiceTime];
            }
        }
    }
}
