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
    /// 同步订单状态
    /// </summary>
    public class ReceiveOrderDeliveryMessageMessage
    {
        
        public const string INDEX_NAME = "ReceiveOrderDeliveryMessage";
        
        private const string _programException = "ProgramException";
        
        private const string _invalidOrderID = "InvalidOrderID";
        
        private const string _invalidType = "InvalidType";
        
        private const string _failed = "Failed";
        
        private const string _orderNotFound = "OrderNotFound";
        
        private const string _orderStatusSaveFail = "OrderStatusSaveFail";
        
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
        /// 3000 同步订单状态异常,异常信息:{0}
        /// </summary>
        public static Message ProgramException
        {
            get
            {
                return Index[_programException];
            }
        }
        
        /// <summary>
        /// 3001 OrderID必须大于0
        /// </summary>
        public static Message InvalidOrderID
        {
            get
            {
                return Index[_invalidOrderID];
            }
        }
        
        /// <summary>
        /// 3002 DeliveryType不合法
        /// </summary>
        public static Message InvalidType
        {
            get
            {
                return Index[_invalidType];
            }
        }
        
        /// <summary>
        /// 3003 订单状态不合法同步失败,订单:{0},当前订单状态:{1},DeliveryType:{2}
        /// </summary>
        public static Message Failed
        {
            get
            {
                return Index[_failed];
            }
        }
        
        /// <summary>
        /// 3004 订单未找到, 请确认订单号是否正确
        /// </summary>
        public static Message OrderNotFound
        {
            get
            {
                return Index[_orderNotFound];
            }
        }
        
        /// <summary>
        /// 3005 订单状态信息保存失败,订单:{0},当前状态:{1},同步状态码:{2}
        /// </summary>
        public static Message OrderStatusSaveFail
        {
            get
            {
                return Index[_orderStatusSaveFail];
            }
        }
    }
}
