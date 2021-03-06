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
    /// 配送
    /// </summary>
    public class VendorDeliveryMessage
    {
        
        public const string INDEX_NAME = "VendorDelivery";
        
        private const string _programException = "ProgramException";
        
        private const string _vendorOrderIdUnValid = "VendorOrderIdUnValid";
        
        private const string _vendorCodeIsNullOrEmpty = "VendorCodeIsNullOrEmpty";
        
        private const string _insertVendorDeliveryFailed = "InsertVendorDeliveryFailed";
        
        private const string _deliveryStatusUnValid = "DeliveryStatusUnValid";
        
        private const string _updateVendorDeliveryFailed = "UpdateVendorDeliveryFailed";
        
        private const string _vendorDeliveryIdListIsNullOrEmpty = "VendorDeliveryIdListIsNullOrEmpty";
        
        private const string _loginIdIsNullOrEmpty = "LoginIdIsNullOrEmpty";
        
        private const string _operatorIsNullOrEmpty = "OperatorIsNullOrEmpty";
        
        private const string _queryCountNotEqualParamCount = "QueryCountNotEqualParamCount";
        
        private const string _notEqualVendorCode = "NotEqualVendorCode";
        
        private const string _notEqualDeliveryStatus = "NotEqualDeliveryStatus";
        
        private const string _batchUpdateOrderStatusFailed = "BatchUpdateOrderStatusFailed";
        
        private const string _batchInsertOperationLogFailed = "BatchInsertOperationLogFailed";
        
        private const string _batchInsertOrderProcessTimelineFailed = "BatchInsertOrderProcessTimelineFailed";
        
        private const string _cancelCashPreparationFailed = "CancelCashPreparationFailed";
        
        private const string _notEqualOperatingResult = "NotEqualOperatingResult";
        
        private const string _operatingResultUnValid = "OperatingResultUnValid";
        
        private const string _branchNoPermission = "BranchNoPermission";
        
        private const string _pageInfoUnValid = "PageInfoUnValid";
        
        private const string _slipNumberUnValid = "SlipNumberUnValid";
        
        private const string _takeDateUnValid = "TakeDateUnValid";
        
        private const string _withDrawalInsertFailed = "WithDrawalInsertFailed";
        
        private const string _batchInsertVendorOrderStatusSyncFailed = "BatchInsertVendorOrderStatusSyncFailed";
        
        private const string _vendorBranchCodeInvalid = "VendorBranchCodeInvalid";
        
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
        /// 7000 服务异常:{0}
        /// </summary>
        public static Message ProgramException
        {
            get
            {
                return Index[_programException];
            }
        }
        
        /// <summary>
        /// 7001 VendorOrderId无效
        /// </summary>
        public static Message VendorOrderIdUnValid
        {
            get
            {
                return Index[_vendorOrderIdUnValid];
            }
        }
        
        /// <summary>
        /// 7002 VendorCode不能为空
        /// </summary>
        public static Message VendorCodeIsNullOrEmpty
        {
            get
            {
                return Index[_vendorCodeIsNullOrEmpty];
            }
        }
        
        /// <summary>
        /// 7003 插入供应商配送信息失败
        /// </summary>
        public static Message InsertVendorDeliveryFailed
        {
            get
            {
                return Index[_insertVendorDeliveryFailed];
            }
        }
        
        /// <summary>
        /// 7004 DeliveryStatus状态无效
        /// </summary>
        public static Message DeliveryStatusUnValid
        {
            get
            {
                return Index[_deliveryStatusUnValid];
            }
        }
        
        /// <summary>
        /// 7005 更新供应商配送信息失败
        /// </summary>
        public static Message UpdateVendorDeliveryFailed
        {
            get
            {
                return Index[_updateVendorDeliveryFailed];
            }
        }
        
        /// <summary>
        /// 7006 VendorDeliveryIdList不能为空
        /// </summary>
        public static Message VendorDeliveryIdListIsNullOrEmpty
        {
            get
            {
                return Index[_vendorDeliveryIdListIsNullOrEmpty];
            }
        }
        
        /// <summary>
        /// 7007 LoginId不能为空
        /// </summary>
        public static Message LoginIdIsNullOrEmpty
        {
            get
            {
                return Index[_loginIdIsNullOrEmpty];
            }
        }
        
        /// <summary>
        /// 7008 Operator不能为空
        /// </summary>
        public static Message OperatorIsNullOrEmpty
        {
            get
            {
                return Index[_operatorIsNullOrEmpty];
            }
        }
        
        /// <summary>
        /// 7009 查询结果与VendorDeliveryIdList参数的数量不一致
        /// </summary>
        public static Message QueryCountNotEqualParamCount
        {
            get
            {
                return Index[_queryCountNotEqualParamCount];
            }
        }
        
        /// <summary>
        /// 7010 VendorCode不匹配
        /// </summary>
        public static Message NotEqualVendorCode
        {
            get
            {
                return Index[_notEqualVendorCode];
            }
        }
        
        /// <summary>
        /// 7011 DeliveryStatus不匹配
        /// </summary>
        public static Message NotEqualDeliveryStatus
        {
            get
            {
                return Index[_notEqualDeliveryStatus];
            }
        }
        
        /// <summary>
        /// 7012 批量更新订单状态失败
        /// </summary>
        public static Message BatchUpdateOrderStatusFailed
        {
            get
            {
                return Index[_batchUpdateOrderStatusFailed];
            }
        }
        
        /// <summary>
        /// 7013 批量插入操作日志失败
        /// </summary>
        public static Message BatchInsertOperationLogFailed
        {
            get
            {
                return Index[_batchInsertOperationLogFailed];
            }
        }
        
        /// <summary>
        /// 7014 批量插入OrderProcessTimeline失败
        /// </summary>
        public static Message BatchInsertOrderProcessTimelineFailed
        {
            get
            {
                return Index[_batchInsertOrderProcessTimelineFailed];
            }
        }
        
        /// <summary>
        /// 7015 调用撤销备钞方法失败
        /// </summary>
        public static Message CancelCashPreparationFailed
        {
            get
            {
                return Index[_cancelCashPreparationFailed];
            }
        }
        
        /// <summary>
        /// 7016 OperatingResult不匹配
        /// </summary>
        public static Message NotEqualOperatingResult
        {
            get
            {
                return Index[_notEqualOperatingResult];
            }
        }
        
        /// <summary>
        /// 7017 OperatingResult无效
        /// </summary>
        public static Message OperatingResultUnValid
        {
            get
            {
                return Index[_operatingResultUnValid];
            }
        }
        
        /// <summary>
        /// 7018 网点无权限
        /// </summary>
        public static Message BranchNoPermission
        {
            get
            {
                return Index[_branchNoPermission];
            }
        }
        
        /// <summary>
        /// 7019 分页信息无效
        /// </summary>
        public static Message PageInfoUnValid
        {
            get
            {
                return Index[_pageInfoUnValid];
            }
        }
        
        /// <summary>
        /// 7020 水单号无效
        /// </summary>
        public static Message SlipNumberUnValid
        {
            get
            {
                return Index[_slipNumberUnValid];
            }
        }
        
        /// <summary>
        /// 7021 取钞日期无效
        /// </summary>
        public static Message TakeDateUnValid
        {
            get
            {
                return Index[_takeDateUnValid];
            }
        }
        
        /// <summary>
        /// 7022 调用取钞方法失败
        /// </summary>
        public static Message WithDrawalInsertFailed
        {
            get
            {
                return Index[_withDrawalInsertFailed];
            }
        }
        
        /// <summary>
        /// 7023 批量插入订单状态同步失败
        /// </summary>
        public static Message BatchInsertVendorOrderStatusSyncFailed
        {
            get
            {
                return Index[_batchInsertVendorOrderStatusSyncFailed];
            }
        }
        
        /// <summary>
        /// 7022 网点代码和供应商代码不能同时为空
        /// </summary>
        public static Message VendorBranchCodeInvalid
        {
            get
            {
                return Index[_vendorBranchCodeInvalid];
            }
        }
    }
}
