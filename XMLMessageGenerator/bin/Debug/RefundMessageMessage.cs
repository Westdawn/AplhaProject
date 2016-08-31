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
    /// 退款
    /// </summary>
    public class RefundMessageMessage
    {
        
        public const string INDEX_NAME = "RefundMessage";
        
        private const string _refundException = "RefundException";
        
        private const string _serviceResponseNull = "ServiceResponseNull";
        
        private const string _paymentBillResponseNull = "PaymentBillResponseNull";
        
        private const string _refundAuditWithInvalidOrderInfo = "RefundAuditWithInvalidOrderInfo";
        
        private const string _refundAuditWithInvalidOrderState = "RefundAuditWithInvalidOrderState";
        
        private const string _refundAuditWithInvalidOperateUser = "RefundAuditWithInvalidOperateUser";
        
        private const string _refundAuditSubmitFailed = "RefundAuditSubmitFailed";
        
        private const string _refundAuditSubmitWithException = "RefundAuditSubmitWithException";
        
        private const string _refundAuditWithInvalidRefundReason = "RefundAuditWithInvalidRefundReason";
        
        private const string _refundAuditException = "RefundAuditException";
        
        private const string _invalidParameters = "InvalidParameters";
        
        private const string _orderRefundAuditEntityIsNull = "OrderRefundAuditEntityIsNull";
        
        private const string _auditStatusInvalid = "AuditStatusInvalid";
        
        private const string _orderAlreadyRefund = "OrderAlreadyRefund";
        
        private const string _updateRefundAuditFailedWhenRefundAudit = "UpdateRefundAuditFailedWhenRefundAudit";
        
        private const string _syncRefundAmountFailedWhenRefundAudit = "SyncRefundAmountFailedWhenRefundAudit";
        
        private const string _insertRefundResultFailedWhenRefundAudit = "InsertRefundResultFailedWhenRefundAudit";
        
        private const string _updateOrderStatusFailedWhenRefundAudit = "UpdateOrderStatusFailedWhenRefundAudit";
        
        private const string _insertTimelineFailedWhenRefundAudit = "InsertTimelineFailedWhenRefundAudit";
        
        private const string _getRefundAuditListWithInValidStatus = "GetRefundAuditListWithInValidStatus";
        
        private const string _refundAuditDataIsNull = "RefundAuditDataIsNull";
        
        private const string _getRefundAuditListPageNoLess0 = "GetRefundAuditListPageNoLess0";
        
        private const string _getRefundAuditListPageSizeLess0 = "GetRefundAuditListPageSizeLess0";
        
        private const string _getRefundAuditListException = "GetRefundAuditListException";
        
        private const string _invalidReferenceNo = "InvalidReferenceNo";
        
        private const string _invalidCurrency = "InvalidCurrency";
        
        private const string _invalidPaymentUid = "InvalidPaymentUid";
        
        private const string _invalidEid = "InvalidEid";
        
        private const string _alreadyRefund = "AlreadyRefund";
        
        private const string _getRefundRateError = "GetRefundRateError";
        
        private const string _cannotGetRefundRate = "CannotGetRefundRate";
        
        private const string _cannotRefundByAuditing = "CannotRefundByAuditing";
        
        private const string _refundRateGetTypeInValid = "RefundRateGetTypeInValid";
        
        private const string _refundRateInValid = "RefundRateInValid";
        
        private const string _refundFeeInValid = "RefundFeeInValid";
        
        private const string _platForm_GetCurrentPricePolicyListException = "PlatForm_GetCurrentPricePolicyListException";
        
        private const string _platForm_GetBranchInfoByBranchID = "PlatForm_GetBranchInfoByBranchID";
        
        private const string _syncConfirmRefundRateWhenRefundAudit = "SyncConfirmRefundRateWhenRefundAudit";
        
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
        /// 2600 退款过程中发生异常: {0}
        /// </summary>
        public static Message RefundException
        {
            get
            {
                return Index[_refundException];
            }
        }
        
        /// <summary>
        /// 2601 调用退款服务返回Response为空
        /// </summary>
        public static Message ServiceResponseNull
        {
            get
            {
                return Index[_serviceResponseNull];
            }
        }
        
        /// <summary>
        /// 2602 调用退款服务返回ResponseBody(具体类型是PaymentBillResponse)为空
        /// </summary>
        public static Message PaymentBillResponseNull
        {
            get
            {
                return Index[_paymentBillResponseNull];
            }
        }
        
        /// <summary>
        /// 2603 退款申请对应的订单信息不正确
        /// </summary>
        public static Message RefundAuditWithInvalidOrderInfo
        {
            get
            {
                return Index[_refundAuditWithInvalidOrderInfo];
            }
        }
        
        /// <summary>
        /// 2604 该订单当前的状态无法进行退款
        /// </summary>
        public static Message RefundAuditWithInvalidOrderState
        {
            get
            {
                return Index[_refundAuditWithInvalidOrderState];
            }
        }
        
        /// <summary>
        /// 2606 退款申请对应的操作人不能为空
        /// </summary>
        public static Message RefundAuditWithInvalidOperateUser
        {
            get
            {
                return Index[_refundAuditWithInvalidOperateUser];
            }
        }
        
        /// <summary>
        /// 2607 退款申请提交失败
        /// </summary>
        public static Message RefundAuditSubmitFailed
        {
            get
            {
                return Index[_refundAuditSubmitFailed];
            }
        }
        
        /// <summary>
        /// 2608 退款申请提交发生异常：{0}
        /// </summary>
        public static Message RefundAuditSubmitWithException
        {
            get
            {
                return Index[_refundAuditSubmitWithException];
            }
        }
        
        /// <summary>
        /// 2609 订单退款申请的退款原因不正确
        /// </summary>
        public static Message RefundAuditWithInvalidRefundReason
        {
            get
            {
                return Index[_refundAuditWithInvalidRefundReason];
            }
        }
        
        /// <summary>
        /// 2610 审核人工退款申请发生异常: {0}
        /// </summary>
        public static Message RefundAuditException
        {
            get
            {
                return Index[_refundAuditException];
            }
        }
        
        /// <summary>
        /// 2611 传入了无效参数
        /// </summary>
        public static Message InvalidParameters
        {
            get
            {
                return Index[_invalidParameters];
            }
        }
        
        /// <summary>
        /// 2612 根据传入RefundAuditID找不到相应的退款审核记录
        /// </summary>
        public static Message OrderRefundAuditEntityIsNull
        {
            get
            {
                return Index[_orderRefundAuditEntityIsNull];
            }
        }
        
        /// <summary>
        /// 2613 订单当前审核状态有误, 必须为审核中
        /// </summary>
        public static Message AuditStatusInvalid
        {
            get
            {
                return Index[_auditStatusInvalid];
            }
        }
        
        /// <summary>
        /// 2614 审核人工退款请求错误:订单已有退款
        /// </summary>
        public static Message OrderAlreadyRefund
        {
            get
            {
                return Index[_orderAlreadyRefund];
            }
        }
        
        /// <summary>
        /// 2615 审核人工退款请求时更新退款审核表失败
        /// </summary>
        public static Message UpdateRefundAuditFailedWhenRefundAudit
        {
            get
            {
                return Index[_updateRefundAuditFailedWhenRefundAudit];
            }
        }
        
        /// <summary>
        /// 2616 审核人工退款请求时同步到Order表失败
        /// </summary>
        public static Message SyncRefundAmountFailedWhenRefundAudit
        {
            get
            {
                return Index[_syncRefundAmountFailedWhenRefundAudit];
            }
        }
        
        /// <summary>
        /// 2617 审核人工退款请求时新增退款结果失败
        /// </summary>
        public static Message InsertRefundResultFailedWhenRefundAudit
        {
            get
            {
                return Index[_insertRefundResultFailedWhenRefundAudit];
            }
        }
        
        /// <summary>
        /// 2618 审核人工退款请求时更新订单状态失败
        /// </summary>
        public static Message UpdateOrderStatusFailedWhenRefundAudit
        {
            get
            {
                return Index[_updateOrderStatusFailedWhenRefundAudit];
            }
        }
        
        /// <summary>
        /// 2619 审核人工退款请求时新增OrderProcessTimeline失败
        /// </summary>
        public static Message InsertTimelineFailedWhenRefundAudit
        {
            get
            {
                return Index[_insertTimelineFailedWhenRefundAudit];
            }
        }
        
        /// <summary>
        /// 2620 获取分页订单退款审核列表时，传入的审核状态不正确
        /// </summary>
        public static Message GetRefundAuditListWithInValidStatus
        {
            get
            {
                return Index[_getRefundAuditListWithInValidStatus];
            }
        }
        
        /// <summary>
        /// 2621 没有查询到订单退款审核信息
        /// </summary>
        public static Message RefundAuditDataIsNull
        {
            get
            {
                return Index[_refundAuditDataIsNull];
            }
        }
        
        /// <summary>
        /// 2622 订单退款审核列表页码必须大于0
        /// </summary>
        public static Message GetRefundAuditListPageNoLess0
        {
            get
            {
                return Index[_getRefundAuditListPageNoLess0];
            }
        }
        
        /// <summary>
        /// 2623 订单退款审核列表每页大小必须大于0
        /// </summary>
        public static Message GetRefundAuditListPageSizeLess0
        {
            get
            {
                return Index[_getRefundAuditListPageSizeLess0];
            }
        }
        
        /// <summary>
        /// 2624 获取订单退款审核列表时发生异常: {0}
        /// </summary>
        public static Message GetRefundAuditListException
        {
            get
            {
                return Index[_getRefundAuditListException];
            }
        }
        
        /// <summary>
        /// 2625 退款时传入了空的客户端请求流水编号
        /// </summary>
        public static Message InvalidReferenceNo
        {
            get
            {
                return Index[_invalidReferenceNo];
            }
        }
        
        /// <summary>
        /// 2626 退款时传入了空的币种
        /// </summary>
        public static Message InvalidCurrency
        {
            get
            {
                return Index[_invalidCurrency];
            }
        }
        
        /// <summary>
        /// 2627 退款时传入了空的支付用户
        /// </summary>
        public static Message InvalidPaymentUid
        {
            get
            {
                return Index[_invalidPaymentUid];
            }
        }
        
        /// <summary>
        /// 2628 退款时传入了空的操作人
        /// </summary>
        public static Message InvalidEid
        {
            get
            {
                return Index[_invalidEid];
            }
        }
        
        /// <summary>
        /// 2629 此订单已经做退款处理
        /// </summary>
        public static Message AlreadyRefund
        {
            get
            {
                return Index[_alreadyRefund];
            }
        }
        
        /// <summary>
        /// 2630 从平台系统获取成本汇率出错（GetCurrentPricePolicyList）
        /// </summary>
        public static Message GetRefundRateError
        {
            get
            {
                return Index[_getRefundRateError];
            }
        }
        
        /// <summary>
        /// 2631 根据branchid:{0},currenycode:{1}从平台系统未获取到成本汇率
        /// </summary>
        public static Message CannotGetRefundRate
        {
            get
            {
                return Index[_cannotGetRefundRate];
            }
        }
        
        /// <summary>
        /// 2632 退款审核中，无法再次发起退款
        /// </summary>
        public static Message CannotRefundByAuditing
        {
            get
            {
                return Index[_cannotRefundByAuditing];
            }
        }
        
        /// <summary>
        /// 2633 退款汇率获取类型不合法
        /// </summary>
        public static Message RefundRateGetTypeInValid
        {
            get
            {
                return Index[_refundRateGetTypeInValid];
            }
        }
        
        /// <summary>
        /// 2634 手动获取退款汇率是必须输入退款汇率
        /// </summary>
        public static Message RefundRateInValid
        {
            get
            {
                return Index[_refundRateInValid];
            }
        }
        
        /// <summary>
        /// 2635 退款手续费不合法
        /// </summary>
        public static Message RefundFeeInValid
        {
            get
            {
                return Index[_refundFeeInValid];
            }
        }
        
        /// <summary>
        /// 2636 访问平台系统ForexMgmtPlatformClient.GetCurrentPricePolicyList异常
        /// </summary>
        public static Message PlatForm_GetCurrentPricePolicyListException
        {
            get
            {
                return Index[_platForm_GetCurrentPricePolicyListException];
            }
        }
        
        /// <summary>
        /// 2637 访问平台系统ForexStoreRateClient.GetBranchInfoByBranchID异常
        /// </summary>
        public static Message PlatForm_GetBranchInfoByBranchID
        {
            get
            {
                return Index[_platForm_GetBranchInfoByBranchID];
            }
        }
        
        /// <summary>
        /// 2638 审核人工退款请求时同步到Order_queue_confirm_refundrate表失败
        /// </summary>
        public static Message SyncConfirmRefundRateWhenRefundAudit
        {
            get
            {
                return Index[_syncConfirmRefundRateWhenRefundAudit];
            }
        }
    }
}
