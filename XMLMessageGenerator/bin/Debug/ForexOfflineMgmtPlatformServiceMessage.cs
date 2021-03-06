//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ForexASOneService.Information
{
    using System;
    using ForexASOneService.Information.Core;
    
    
    /// <summary>
    /// 线下管理系统服务
    /// </summary>
    public class ForexOfflineMgmtPlatformServiceMessage
    {
        
        public const string INDEX_NAME = "ForexOfflineMgmtPlatformService";
        
        private const string _programException = "ProgramException";
        
        private const string _queryBranchInfoFail = "QueryBranchInfoFail";
        
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
        /// 7001 线下管理系统服务，程序异常！{0}
        /// </summary>
        public static Message ProgramException
        {
            get
            {
                return Index[_programException];
            }
        }
        
        /// <summary>
        /// 7002 查询网点失败！{0}
        /// </summary>
        public static Message QueryBranchInfoFail
        {
            get
            {
                return Index[_queryBranchInfoFail];
            }
        }
    }
}
