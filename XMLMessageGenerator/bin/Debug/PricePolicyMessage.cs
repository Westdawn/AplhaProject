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
    /// 价格策略管理
    /// </summary>
    public class PricePolicyMessage
    {
        
        public const string INDEX_NAME = "PricePolicy";
        
        private const string _programException = "ProgramException";
        
        private const string _applicantNameError = "ApplicantNameError";
        
        private const string _applyUIDError = "ApplyUIDError";
        
        private const string _applyPricePolicyeListError = "ApplyPricePolicyeListError";
        
        private const string _branchIDError = "BranchIDError";
        
        private const string _currencyCodeError = "CurrencyCodeError";
        
        private const string _venderIDError = "VenderIDError";
        
        private const string _pricePolicyInfoError = "PricePolicyInfoError";
        
        private const string _applyPricePolicyError = "ApplyPricePolicyError";
        
        private const string _unitError = "UnitError";
        
        private const string _sellPricePolicyError = "SellPricePolicyError";
        
        private const string _promotionPricePolicyError = "PromotionPricePolicyError";
        
        private const string _sellPricePolicyApplyExist = "SellPricePolicyApplyExist";
        
        private const string _policyTimeMixError = "PolicyTimeMixError";
        
        private const string _getPricePolicyListError = "GetPricePolicyListError";
        
        private const string _getPricePolicyCountError = "GetPricePolicyCountError";
        
        private const string _pricePolicyTypeError = "PricePolicyTypeError";
        
        private const string _exchangeTypeError = "ExchangeTypeError";
        
        private const string _pricePolicyCalTypeError = "PricePolicyCalTypeError";
        
        private const string _auditNameError = "AuditNameError";
        
        private const string _auditUIDError = "AuditUIDError";
        
        private const string _auditStatusError = "AuditStatusError";
        
        private const string _applyIDListError = "ApplyIDListError";
        
        private const string _applyIDError = "ApplyIDError";
        
        private const string _getPricePolicyApplyListError = "GetPricePolicyApplyListError";
        
        private const string _updatePricePolicyApplyError = "UpdatePricePolicyApplyError";
        
        private const string _pricePolicyNotExist = "PricePolicyNotExist";
        
        private const string _pricePolicyStatusError = "PricePolicyStatusError";
        
        private const string _updatePricePolicyStatusError = "UpdatePricePolicyStatusError";
        
        private const string _currenTimeNotInEffectTimeSpan = "CurrenTimeNotInEffectTimeSpan";
        
        private const string _currenTimeInEffectTimeSpan = "CurrenTimeInEffectTimeSpan";
        
        private const string _pricePolicyAuditStatus = "PricePolicyAuditStatus";
        
        private const string _existSameID = "ExistSameID";
        
        private const string _noTimeSpanForSalePricePolicy = "NoTimeSpanForSalePricePolicy";
        
        private const string _operatorIsNull = "OperatorIsNull";
        
        private const string _editorUIDIsNull = "EditorUIDIsNull";
        
        private const string _policyIDError = "PolicyIDError";
        
        private const string _pricePolicyInfoIsNull = "PricePolicyInfoIsNull";
        
        private const string _getPricePolicyNotExist = "GetPricePolicyNotExist";
        
        private const string _editorNotSame = "EditorNotSame";
        
        private const string _editPricePolicyFail = "EditPricePolicyFail";
        
        private const string _coefficientAccuracyError = "CoefficientAccuracyError";
        
        private const string _thresholdAccuracyError = "ThresholdAccuracyError";
        
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
        /// 1100 服务异常:{0}
        /// </summary>
        public static Message ProgramException
        {
            get
            {
                return Index[_programException];
            }
        }
        
        /// <summary>
        /// 1101 ApplicantName不能为空
        /// </summary>
        public static Message ApplicantNameError
        {
            get
            {
                return Index[_applicantNameError];
            }
        }
        
        /// <summary>
        /// 1102 ApplyUID不能为空
        /// </summary>
        public static Message ApplyUIDError
        {
            get
            {
                return Index[_applyUIDError];
            }
        }
        
        /// <summary>
        /// 1103 ApplyPricePolicyeList为空
        /// </summary>
        public static Message ApplyPricePolicyeListError
        {
            get
            {
                return Index[_applyPricePolicyeListError];
            }
        }
        
        /// <summary>
        /// 1104 BranchID错误
        /// </summary>
        public static Message BranchIDError
        {
            get
            {
                return Index[_branchIDError];
            }
        }
        
        /// <summary>
        /// 1105 CurrencyCode为空
        /// </summary>
        public static Message CurrencyCodeError
        {
            get
            {
                return Index[_currencyCodeError];
            }
        }
        
        /// <summary>
        /// 1106 VenderID错误
        /// </summary>
        public static Message VenderIDError
        {
            get
            {
                return Index[_venderIDError];
            }
        }
        
        /// <summary>
        /// 1107 PricePolicyInfo为空
        /// </summary>
        public static Message PricePolicyInfoError
        {
            get
            {
                return Index[_pricePolicyInfoError];
            }
        }
        
        /// <summary>
        /// 1108 申请价格策略错误，错误信息：{0}
        /// </summary>
        public static Message ApplyPricePolicyError
        {
            get
            {
                return Index[_applyPricePolicyError];
            }
        }
        
        /// <summary>
        /// 1109 Unit错误
        /// </summary>
        public static Message UnitError
        {
            get
            {
                return Index[_unitError];
            }
        }
        
        /// <summary>
        /// 1110 售卖价格策略错误：{0}
        /// </summary>
        public static Message SellPricePolicyError
        {
            get
            {
                return Index[_sellPricePolicyError];
            }
        }
        
        /// <summary>
        /// 1111 优惠价格策略错误：{0}
        /// </summary>
        public static Message PromotionPricePolicyError
        {
            get
            {
                return Index[_promotionPricePolicyError];
            }
        }
        
        /// <summary>
        /// 1112 存在待处理售卖价格策略申请：{0}
        /// </summary>
        public static Message SellPricePolicyApplyExist
        {
            get
            {
                return Index[_sellPricePolicyApplyExist];
            }
        }
        
        /// <summary>
        /// 1113 优惠价格策略时间范围错误：{0}
        /// </summary>
        public static Message PolicyTimeMixError
        {
            get
            {
                return Index[_policyTimeMixError];
            }
        }
        
        /// <summary>
        /// 1114 获取价格策略列表错误：{0}
        /// </summary>
        public static Message GetPricePolicyListError
        {
            get
            {
                return Index[_getPricePolicyListError];
            }
        }
        
        /// <summary>
        /// 1115 获取价格策略数量错误：{0}
        /// </summary>
        public static Message GetPricePolicyCountError
        {
            get
            {
                return Index[_getPricePolicyCountError];
            }
        }
        
        /// <summary>
        /// 1116 价格策略类型错误
        /// </summary>
        public static Message PricePolicyTypeError
        {
            get
            {
                return Index[_pricePolicyTypeError];
            }
        }
        
        /// <summary>
        /// 1117 交易类型错误
        /// </summary>
        public static Message ExchangeTypeError
        {
            get
            {
                return Index[_exchangeTypeError];
            }
        }
        
        /// <summary>
        /// 1118 销售价格计算类型错误
        /// </summary>
        public static Message PricePolicyCalTypeError
        {
            get
            {
                return Index[_pricePolicyCalTypeError];
            }
        }
        
        /// <summary>
        /// 1119 审核人姓名错误
        /// </summary>
        public static Message AuditNameError
        {
            get
            {
                return Index[_auditNameError];
            }
        }
        
        /// <summary>
        /// 1120 审核人ID错误
        /// </summary>
        public static Message AuditUIDError
        {
            get
            {
                return Index[_auditUIDError];
            }
        }
        
        /// <summary>
        /// 1121 审核状态错误：{0}
        /// </summary>
        public static Message AuditStatusError
        {
            get
            {
                return Index[_auditStatusError];
            }
        }
        
        /// <summary>
        /// 1122 申请列表错误
        /// </summary>
        public static Message ApplyIDListError
        {
            get
            {
                return Index[_applyIDListError];
            }
        }
        
        /// <summary>
        /// 1123 申请ID错误
        /// </summary>
        public static Message ApplyIDError
        {
            get
            {
                return Index[_applyIDError];
            }
        }
        
        /// <summary>
        /// 1124 获取价格策略申请列表错误:{0}
        /// </summary>
        public static Message GetPricePolicyApplyListError
        {
            get
            {
                return Index[_getPricePolicyApplyListError];
            }
        }
        
        /// <summary>
        /// 1125 更新价格策略申请错误:{0}
        /// </summary>
        public static Message UpdatePricePolicyApplyError
        {
            get
            {
                return Index[_updatePricePolicyApplyError];
            }
        }
        
        /// <summary>
        /// 1126 价格策略不存在:{0}
        /// </summary>
        public static Message PricePolicyNotExist
        {
            get
            {
                return Index[_pricePolicyNotExist];
            }
        }
        
        /// <summary>
        /// 1127 价格策略状态错误
        /// </summary>
        public static Message PricePolicyStatusError
        {
            get
            {
                return Index[_pricePolicyStatusError];
            }
        }
        
        /// <summary>
        /// 1128 更新价格策略状态失败：{0}
        /// </summary>
        public static Message UpdatePricePolicyStatusError
        {
            get
            {
                return Index[_updatePricePolicyStatusError];
            }
        }
        
        /// <summary>
        /// 1129 当前时间不在生效时间范围内：{0}
        /// </summary>
        public static Message CurrenTimeNotInEffectTimeSpan
        {
            get
            {
                return Index[_currenTimeNotInEffectTimeSpan];
            }
        }
        
        /// <summary>
        /// 1130 当前时间在生效时间范围内：{0}
        /// </summary>
        public static Message CurrenTimeInEffectTimeSpan
        {
            get
            {
                return Index[_currenTimeInEffectTimeSpan];
            }
        }
        
        /// <summary>
        /// 1131 价格策略审核状态错误：{0}
        /// </summary>
        public static Message PricePolicyAuditStatus
        {
            get
            {
                return Index[_pricePolicyAuditStatus];
            }
        }
        
        /// <summary>
        /// 1132 存在相同的ID：{0}
        /// </summary>
        public static Message ExistSameID
        {
            get
            {
                return Index[_existSameID];
            }
        }
        
        /// <summary>
        /// 1133 售卖价格策略不存在时间范围
        /// </summary>
        public static Message NoTimeSpanForSalePricePolicy
        {
            get
            {
                return Index[_noTimeSpanForSalePricePolicy];
            }
        }
        
        /// <summary>
        /// 1134 Operator不能为空
        /// </summary>
        public static Message OperatorIsNull
        {
            get
            {
                return Index[_operatorIsNull];
            }
        }
        
        /// <summary>
        /// 1135 EditorUID不能为空
        /// </summary>
        public static Message EditorUIDIsNull
        {
            get
            {
                return Index[_editorUIDIsNull];
            }
        }
        
        /// <summary>
        /// 1136 PolicyID小于等于零
        /// </summary>
        public static Message PolicyIDError
        {
            get
            {
                return Index[_policyIDError];
            }
        }
        
        /// <summary>
        /// 1137 价格策略信息为空:{0}
        /// </summary>
        public static Message PricePolicyInfoIsNull
        {
            get
            {
                return Index[_pricePolicyInfoIsNull];
            }
        }
        
        /// <summary>
        /// 1138 价格策略不存在
        /// </summary>
        public static Message GetPricePolicyNotExist
        {
            get
            {
                return Index[_getPricePolicyNotExist];
            }
        }
        
        /// <summary>
        /// 1139 编辑者与申请者不一致
        /// </summary>
        public static Message EditorNotSame
        {
            get
            {
                return Index[_editorNotSame];
            }
        }
        
        /// <summary>
        /// 1140 编辑价格策略失败，失败信息:{0}
        /// </summary>
        public static Message EditPricePolicyFail
        {
            get
            {
                return Index[_editPricePolicyFail];
            }
        }
        
        /// <summary>
        /// 1141 系数精度错误，点差、固定值精度4位，百分比精度6位，失败信息:{0}
        /// </summary>
        public static Message CoefficientAccuracyError
        {
            get
            {
                return Index[_coefficientAccuracyError];
            }
        }
        
        /// <summary>
        /// 1142 阈值精度错误，精度6位，失败信息:{0}
        /// </summary>
        public static Message ThresholdAccuracyError
        {
            get
            {
                return Index[_thresholdAccuracyError];
            }
        }
    }
}