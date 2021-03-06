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
    /// 验证Token是否有效
    /// </summary>
    public class VerifyTokenMessage
    {
        
        public const string INDEX_NAME = "VerifyToken";
        
        private const string _programException = "ProgramException";
        
        private const string _tokenIsEmpty = "TokenIsEmpty";
        
        private const string _invalidToken = "InvalidToken";
        
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
        /// 1101 Token不能为空
        /// </summary>
        public static Message TokenIsEmpty
        {
            get
            {
                return Index[_tokenIsEmpty];
            }
        }
        
        /// <summary>
        /// 1102 Token无效
        /// </summary>
        public static Message InvalidToken
        {
            get
            {
                return Index[_invalidToken];
            }
        }
    }
}
