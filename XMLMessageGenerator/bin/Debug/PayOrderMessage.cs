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
    /// 去支付（我携）
    /// </summary>
    public class PayOrderMessage
    {
        
        public const string INDEX_NAME = "PayOrder";
        
        private const string _programException = "ProgramException";
        
        private const string _orderIDIsNull = "OrderIDIsNull";
        
        private const string _uidIsNull = "UidIsNull";
        
        private const string _mustBePreparePay = "MustBePreparePay";
        
        private const string _timeoutOrder = "TimeoutOrder";
        
        private const string _canNotFindOrder = "CanNotFindOrder";
        
        private const string _canNotFindPayInfo = "CanNotFindPayInfo";
        
        private const string _platFormIsNotExist = "PlatFormIsNotExist";
        
        private const string _canNotOrderProcess = "CanNotOrderProcess";
        
        private const string _currentProcessMustBeCreated = "CurrentProcessMustBeCreated";
        
        private const string _operatorInValidate = "OperatorInValidate";
        
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
        /// 2500 程序未知的异常:{0}
        /// </summary>
        public static Message ProgramException
        {
            get
            {
                return Index[_programException];
            }
        }
        
        /// <summary>
        /// 2501 订单号为空
        /// </summary>
        public static Message OrderIDIsNull
        {
            get
            {
                return Index[_orderIDIsNull];
            }
        }
        
        /// <summary>
        /// 2502 用户ID为空
        /// </summary>
        public static Message UidIsNull
        {
            get
            {
                return Index[_uidIsNull];
            }
        }
        
        /// <summary>
        /// 2503 必须是待支付状态
        /// </summary>
        public static Message MustBePreparePay
        {
            get
            {
                return Index[_mustBePreparePay];
            }
        }
        
        /// <summary>
        /// 2504 订单已过最晚可支付时间
        /// </summary>
        public static Message TimeoutOrder
        {
            get
            {
                return Index[_timeoutOrder];
            }
        }
        
        /// <summary>
        /// 2505 订单信息为空
        /// </summary>
        public static Message CanNotFindOrder
        {
            get
            {
                return Index[_canNotFindOrder];
            }
        }
        
        /// <summary>
        /// 2506 无法获取支付信息
        /// </summary>
        public static Message CanNotFindPayInfo
        {
            get
            {
                return Index[_canNotFindPayInfo];
            }
        }
        
        /// <summary>
        /// 2507 参数(Platform)应为 H5 or Hybrid
        /// </summary>
        public static Message PlatFormIsNotExist
        {
            get
            {
                return Index[_platFormIsNotExist];
            }
        }
        
        /// <summary>
        /// 2508 没有找到订单处理节点
        /// </summary>
        public static Message CanNotOrderProcess
        {
            get
            {
                return Index[_canNotOrderProcess];
            }
        }
        
        /// <summary>
        /// 2509 订单必须为创建节点
        /// </summary>
        public static Message CurrentProcessMustBeCreated
        {
            get
            {
                return Index[_currentProcessMustBeCreated];
            }
        }
        
        /// <summary>
        /// 2510 订单操作人与订单创建人不匹配
        /// </summary>
        public static Message OperatorInValidate
        {
            get
            {
                return Index[_operatorInValidate];
            }
        }
        
        /// <summary>
        /// 2511 外币兑换服务时间为{0}~{1}
        /// </summary>
        public static Message SafeGovServiceTime
        {
            get
            {
                return Index[_safeGovServiceTime];
            }
        }
        
        /// <summary>
        /// 2512 不在供应商网点的服务时间
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
