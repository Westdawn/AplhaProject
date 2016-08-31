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
    /// 现钞库存
    /// </summary>
    public class CashStockMessage
    {
        
        public const string INDEX_NAME = "CashStock";
        
        private const string _programException = "ProgramException";
        
        private const string _orgIdUnValid = "OrgIdUnValid";
        
        private const string _auditStatusUnValid = "AuditStatusUnValid";
        
        private const string _isOverLimitUnValid = "IsOverLimitUnValid";
        
        private const string _cashStockIdUnValid = "CashStockIdUnValid";
        
        private const string _auditorUnValid = "AuditorUnValid";
        
        private const string _auditorNameUnValid = "AuditorNameUnValid";
        
        private const string _cashStockApplyIdListUnValid = "CashStockApplyIdListUnValid";
        
        private const string _currencyCodeUnValid = "CurrencyCodeUnValid";
        
        private const string _cashStockNameUnValid = "CashStockNameUnValid";
        
        private const string _costRateUnValid = "CostRateUnValid";
        
        private const string _availableStockUnValid = "AvailableStockUnValid";
        
        private const string _unitUnValid = "UnitUnValid";
        
        private const string _userIdUnValid = "UserIdUnValid";
        
        private const string _maxLimitUnValid = "MaxLimitUnValid";
        
        private const string _minLimitUnValid = "MinLimitUnValid";
        
        private const string _warnLimitUnValid = "WarnLimitUnValid";
        
        private const string _warnLimitMoreMaxLimit = "WarnLimitMoreMaxLimit";
        
        private const string _minLimitMoreWarnLimit = "MinLimitMoreWarnLimit";
        
        private const string _currencyCodeNotExist = "CurrencyCodeNotExist";
        
        private const string _orgIdNotExist = "OrgIdNotExist";
        
        private const string _cashStockNameExsit = "CashStockNameExsit";
        
        private const string _currencyCodeExsit = "CurrencyCodeExsit";
        
        private const string _insertCashStockFail = "InsertCashStockFail";
        
        private const string _insertCashStockApplyFail = "InsertCashStockApplyFail";
        
        private const string _insertRiskRecordFail = "InsertRiskRecordFail";
        
        private const string _cashStockNoExist = "CashStockNoExist";
        
        private const string _auditStatusNotReject = "AuditStatusNotReject";
        
        private const string _updateCashStockFail = "UpdateCashStockFail";
        
        private const string _updateRiskRecordFail = "UpdateRiskRecordFail";
        
        private const string _rejectRiskRecordNotExsit = "RejectRiskRecordNotExsit";
        
        private const string _updateAuditStatusFailed = "UpdateAuditStatusFailed";
        
        private const string _userNameUnValid = "UserNameUnValid";
        
        private const string _queryActiveApplyIsNotEqualWithInParam = "QueryActiveApplyIsNotEqualWithInParam";
        
        private const string _auditStatusNotApprove = "AuditStatusNotApprove";
        
        private const string _cashStockApplyNotExsitByCashStockId = "CashStockApplyNotExsitByCashStockId";
        
        private const string _updateCashStockApplyFailed = "UpdateCashStockApplyFailed";
        
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
        /// 11000 服务异常:{0}
        /// </summary>
        public static Message ProgramException
        {
            get
            {
                return Index[_programException];
            }
        }
        
        /// <summary>
        /// 11001 OrgId参数错误
        /// </summary>
        public static Message OrgIdUnValid
        {
            get
            {
                return Index[_orgIdUnValid];
            }
        }
        
        /// <summary>
        /// 11002 AuditStatus参数错误
        /// </summary>
        public static Message AuditStatusUnValid
        {
            get
            {
                return Index[_auditStatusUnValid];
            }
        }
        
        /// <summary>
        /// 11003 IsOverLimit参数错误
        /// </summary>
        public static Message IsOverLimitUnValid
        {
            get
            {
                return Index[_isOverLimitUnValid];
            }
        }
        
        /// <summary>
        /// 11004 CashStockId参数错误
        /// </summary>
        public static Message CashStockIdUnValid
        {
            get
            {
                return Index[_cashStockIdUnValid];
            }
        }
        
        /// <summary>
        /// 11005 审核人UID参数错误
        /// </summary>
        public static Message AuditorUnValid
        {
            get
            {
                return Index[_auditorUnValid];
            }
        }
        
        /// <summary>
        /// 11006 审核人中文名称参数错误
        /// </summary>
        public static Message AuditorNameUnValid
        {
            get
            {
                return Index[_auditorNameUnValid];
            }
        }
        
        /// <summary>
        /// 11007 现钞库存申请Id列表参数错误
        /// </summary>
        public static Message CashStockApplyIdListUnValid
        {
            get
            {
                return Index[_cashStockApplyIdListUnValid];
            }
        }
        
        /// <summary>
        /// 11008 CurrencyCode参数错误
        /// </summary>
        public static Message CurrencyCodeUnValid
        {
            get
            {
                return Index[_currencyCodeUnValid];
            }
        }
        
        /// <summary>
        /// 11009 CashStockName参数错误
        /// </summary>
        public static Message CashStockNameUnValid
        {
            get
            {
                return Index[_cashStockNameUnValid];
            }
        }
        
        /// <summary>
        /// 11010 CostRate参数错误
        /// </summary>
        public static Message CostRateUnValid
        {
            get
            {
                return Index[_costRateUnValid];
            }
        }
        
        /// <summary>
        /// 11011 AvailableStock参数错误
        /// </summary>
        public static Message AvailableStockUnValid
        {
            get
            {
                return Index[_availableStockUnValid];
            }
        }
        
        /// <summary>
        /// 11012 Unit参数错误
        /// </summary>
        public static Message UnitUnValid
        {
            get
            {
                return Index[_unitUnValid];
            }
        }
        
        /// <summary>
        /// 11013 UserId参数错误
        /// </summary>
        public static Message UserIdUnValid
        {
            get
            {
                return Index[_userIdUnValid];
            }
        }
        
        /// <summary>
        /// 11014 MaxLimit参数错误
        /// </summary>
        public static Message MaxLimitUnValid
        {
            get
            {
                return Index[_maxLimitUnValid];
            }
        }
        
        /// <summary>
        /// 11015 MinLimit参数错误
        /// </summary>
        public static Message MinLimitUnValid
        {
            get
            {
                return Index[_minLimitUnValid];
            }
        }
        
        /// <summary>
        /// 11016 WarnLimit参数错误
        /// </summary>
        public static Message WarnLimitUnValid
        {
            get
            {
                return Index[_warnLimitUnValid];
            }
        }
        
        /// <summary>
        /// 11017 WarnLimit大于MaxLimit
        /// </summary>
        public static Message WarnLimitMoreMaxLimit
        {
            get
            {
                return Index[_warnLimitMoreMaxLimit];
            }
        }
        
        /// <summary>
        /// 11018 MinLimit大于WarnLimit
        /// </summary>
        public static Message MinLimitMoreWarnLimit
        {
            get
            {
                return Index[_minLimitMoreWarnLimit];
            }
        }
        
        /// <summary>
        /// 11019 币种不存在
        /// </summary>
        public static Message CurrencyCodeNotExist
        {
            get
            {
                return Index[_currencyCodeNotExist];
            }
        }
        
        /// <summary>
        /// 11020 机构不存在
        /// </summary>
        public static Message OrgIdNotExist
        {
            get
            {
                return Index[_orgIdNotExist];
            }
        }
        
        /// <summary>
        /// 11021 现钞库存名称已存在
        /// </summary>
        public static Message CashStockNameExsit
        {
            get
            {
                return Index[_cashStockNameExsit];
            }
        }
        
        /// <summary>
        /// 11022 同一机构 同一币种 只可设置一个现钞库存
        /// </summary>
        public static Message CurrencyCodeExsit
        {
            get
            {
                return Index[_currencyCodeExsit];
            }
        }
        
        /// <summary>
        /// 11023 插入现钞库存失败
        /// </summary>
        public static Message InsertCashStockFail
        {
            get
            {
                return Index[_insertCashStockFail];
            }
        }
        
        /// <summary>
        /// 11024 插入现钞库存申请失败
        /// </summary>
        public static Message InsertCashStockApplyFail
        {
            get
            {
                return Index[_insertCashStockApplyFail];
            }
        }
        
        /// <summary>
        /// 11025 插入风险管理记录失败
        /// </summary>
        public static Message InsertRiskRecordFail
        {
            get
            {
                return Index[_insertRiskRecordFail];
            }
        }
        
        /// <summary>
        /// 11026 现钞库存不存在
        /// </summary>
        public static Message CashStockNoExist
        {
            get
            {
                return Index[_cashStockNoExist];
            }
        }
        
        /// <summary>
        /// 11027 现钞库存状态非驳回
        /// </summary>
        public static Message AuditStatusNotReject
        {
            get
            {
                return Index[_auditStatusNotReject];
            }
        }
        
        /// <summary>
        /// 11028 更新现钞库存失败
        /// </summary>
        public static Message UpdateCashStockFail
        {
            get
            {
                return Index[_updateCashStockFail];
            }
        }
        
        /// <summary>
        /// 11029 更新现钞库存风险管理记录失败
        /// </summary>
        public static Message UpdateRiskRecordFail
        {
            get
            {
                return Index[_updateRiskRecordFail];
            }
        }
        
        /// <summary>
        /// 11030 驳回的现钞库存风险管理不存在
        /// </summary>
        public static Message RejectRiskRecordNotExsit
        {
            get
            {
                return Index[_rejectRiskRecordNotExsit];
            }
        }
        
        /// <summary>
        /// 11031 更新现钞库存申请状态失败
        /// </summary>
        public static Message UpdateAuditStatusFailed
        {
            get
            {
                return Index[_updateAuditStatusFailed];
            }
        }
        
        /// <summary>
        /// 11032 UserName参数错误
        /// </summary>
        public static Message UserNameUnValid
        {
            get
            {
                return Index[_userNameUnValid];
            }
        }
        
        /// <summary>
        /// 11033 查询的有效现钞库存申请与输入参数不一致
        /// </summary>
        public static Message QueryActiveApplyIsNotEqualWithInParam
        {
            get
            {
                return Index[_queryActiveApplyIsNotEqualWithInParam];
            }
        }
        
        /// <summary>
        /// 11034 审核不通过的现钞库存不能编辑风险管理
        /// </summary>
        public static Message AuditStatusNotApprove
        {
            get
            {
                return Index[_auditStatusNotApprove];
            }
        }
        
        /// <summary>
        /// 11035 现钞库存下的申请信息不存在
        /// </summary>
        public static Message CashStockApplyNotExsitByCashStockId
        {
            get
            {
                return Index[_cashStockApplyNotExsitByCashStockId];
            }
        }
        
        /// <summary>
        /// 11036 更新现钞库存申请失败
        /// </summary>
        public static Message UpdateCashStockApplyFailed
        {
            get
            {
                return Index[_updateCashStockApplyFailed];
            }
        }
    }
}
