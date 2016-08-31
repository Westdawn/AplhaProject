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
    /// 扣款通知回调
    /// </summary>
    public class GatheringCallbackMessage
    {
        
        public const string INDEX_NAME = "GatheringCallback";
        
        private const string _programException = "ProgramException";
        
        private const string _getBranchByBranchIDAndCurrencyException = "GetBranchByBranchIDAndCurrencyException";
        
        private const string _requestIsNull = "RequestIsNull";
        
        private const string _gatheringSubListIsNull = "GatheringSubListIsNull";
        
        private const string _merchantIDIsZero = "MerchantIDIsZero";
        
        private const string _orderIDIsZero = "OrderIDIsZero";
        
        private const string _billNoIsZero = "BillNoIsZero";
        
        private const string _outBillNoIsNull = "OutBillNoIsNull";
        
        private const string _gatheringTypeIsNull = "GatheringTypeIsNull";
        
        private const string _prepayTypeIsNull = "PrepayTypeIsNull";
        
        private const string _canNotFindOrder = "CanNotFindOrder";
        
        private const string _billNoNotEqual = "BillNoNotEqual";
        
        private const string _totalPaidAmountNotEqual = "TotalPaidAmountNotEqual";
        
        private const string _orderStateNotPaying = "OrderStateNotPaying";
        
        private const string _gatheringTypeError = "GatheringTypeError";
        
        private const string _gatheringTypeIsG = "GatheringTypeIsG";
        
        private const string _statusError = "StatusError";
        
        private const string _updateOrderTableFail = "UpdateOrderTableFail";
        
        private const string _insertOrderProcessTimeLineFail = "InsertOrderProcessTimeLineFail";
        
        private const string _orderStateNotRefunding = "OrderStateNotRefunding";
        
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
        /// 2100 程序未知的异常
        /// </summary>
        public static Message ProgramException
        {
            get
            {
                return Index[_programException];
            }
        }
        
        /// <summary>
        /// 2101 调用ForexStoreRateServices的GetBranchByBranchIDAndCurrency接口发生未知的异常
        /// </summary>
        public static Message GetBranchByBranchIDAndCurrencyException
        {
            get
            {
                return Index[_getBranchByBranchIDAndCurrencyException];
            }
        }
        
        /// <summary>
        /// 2102 GatheringCallbackStatusRequest错误
        /// </summary>
        public static Message RequestIsNull
        {
            get
            {
                return Index[_requestIsNull];
            }
        }
        
        /// <summary>
        /// 2103 GatheringCallbackStatusRequest.GatheringSubList错误
        /// </summary>
        public static Message GatheringSubListIsNull
        {
            get
            {
                return Index[_gatheringSubListIsNull];
            }
        }
        
        /// <summary>
        /// 2104 GatheringCallbackStatusRequest.MerchantID错误
        /// </summary>
        public static Message MerchantIDIsZero
        {
            get
            {
                return Index[_merchantIDIsZero];
            }
        }
        
        /// <summary>
        /// 2105 GatheringCallbackStatusRequest.OrderID错误
        /// </summary>
        public static Message OrderIDIsZero
        {
            get
            {
                return Index[_orderIDIsZero];
            }
        }
        
        /// <summary>
        /// 2106 GatheringCallbackStatusRequest.BillNo错误
        /// </summary>
        public static Message BillNoIsZero
        {
            get
            {
                return Index[_billNoIsZero];
            }
        }
        
        /// <summary>
        /// 2107 GatheringCallbackStatusRequest.OutBillNo错误
        /// </summary>
        public static Message OutBillNoIsNull
        {
            get
            {
                return Index[_outBillNoIsNull];
            }
        }
        
        /// <summary>
        /// 2108 GatheringCallbackStatusRequest.GatheringType为空
        /// </summary>
        public static Message GatheringTypeIsNull
        {
            get
            {
                return Index[_gatheringTypeIsNull];
            }
        }
        
        /// <summary>
        /// 2109 GatheringCallbackStatusRequest.PrepayType错误
        /// </summary>
        public static Message PrepayTypeIsNull
        {
            get
            {
                return Index[_prepayTypeIsNull];
            }
        }
        
        /// <summary>
        /// 2110 通过orderid:{0},无法找到对应的order
        /// </summary>
        public static Message CanNotFindOrder
        {
            get
            {
                return Index[_canNotFindOrder];
            }
        }
        
        /// <summary>
        /// 2111 BillNo不一致
        /// </summary>
        public static Message BillNoNotEqual
        {
            get
            {
                return Index[_billNoNotEqual];
            }
        }
        
        /// <summary>
        /// 2112 TotalPaidAmount不一致
        /// </summary>
        public static Message TotalPaidAmountNotEqual
        {
            get
            {
                return Index[_totalPaidAmountNotEqual];
            }
        }
        
        /// <summary>
        /// 2113 订单状态不是支付中
        /// </summary>
        public static Message OrderStateNotPaying
        {
            get
            {
                return Index[_orderStateNotPaying];
            }
        }
        
        /// <summary>
        /// 2114 GatheringCallbackStatusRequest.GatheringType错误
        /// </summary>
        public static Message GatheringTypeError
        {
            get
            {
                return Index[_gatheringTypeError];
            }
        }
        
        /// <summary>
        /// 2115 GatheringCallbackStatusRequest.GatheringType为G（担保）,本项目目前不支持担保类型
        /// </summary>
        public static Message GatheringTypeIsG
        {
            get
            {
                return Index[_gatheringTypeIsG];
            }
        }
        
        /// <summary>
        /// 2116 GatheringCallbackStatusRequest.Status错误,Status需为SUCCESS或者FAIL
        /// </summary>
        public static Message StatusError
        {
            get
            {
                return Index[_statusError];
            }
        }
        
        /// <summary>
        /// 2117 更新Order表失败
        /// </summary>
        public static Message UpdateOrderTableFail
        {
            get
            {
                return Index[_updateOrderTableFail];
            }
        }
        
        /// <summary>
        /// 2118 插入order_process_timeline失败
        /// </summary>
        public static Message InsertOrderProcessTimeLineFail
        {
            get
            {
                return Index[_insertOrderProcessTimeLineFail];
            }
        }
        
        /// <summary>
        /// 2119 订单状态不是退款中
        /// </summary>
        public static Message OrderStateNotRefunding
        {
            get
            {
                return Index[_orderStateNotRefunding];
            }
        }
    }
}