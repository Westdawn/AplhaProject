//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VendorMgmtSys.Information
{
    using System;
    using VendorMgmtSys.Information.Core;
    
    
    /// <summary>
    /// 订单取消
    /// </summary>
    public class AcceptCancelOrderInfoMessage
    {
        
        public const string INDEX_NAME = "AcceptCancelOrderInfo";
        
        private const string _programException = "ProgramException";
        
        private const string _invalidOrderID = "InvalidOrderID";
        
        private const string _invalidPreOrderStatus = "InvalidPreOrderStatus";
        
        private const string _orderNotExist = "OrderNotExist";
        
        private const string _invalidOrderStatus = "InvalidOrderStatus";
        
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
        /// 6000 服务异常:{0}
        /// </summary>
        public static Message ProgramException
        {
            get
            {
                return Index[_programException];
            }
        }
        
        /// <summary>
        /// 6001 传入了无效的订单ID
        /// </summary>
        public static Message InvalidOrderID
        {
            get
            {
                return Index[_invalidOrderID];
            }
        }
        
        /// <summary>
        /// 6002 传入了无效的前置订单状态:{0}
        /// </summary>
        public static Message InvalidPreOrderStatus
        {
            get
            {
                return Index[_invalidPreOrderStatus];
            }
        }
        
        /// <summary>
        /// 6003 根据订单ID未找到订单数据
        /// </summary>
        public static Message OrderNotExist
        {
            get
            {
                return Index[_orderNotExist];
            }
        }
        
        /// <summary>
        /// 6004 订单当前状态{0}不是待退款
        /// </summary>
        public static Message InvalidOrderStatus
        {
            get
            {
                return Index[_invalidOrderStatus];
            }
        }
    }
}
