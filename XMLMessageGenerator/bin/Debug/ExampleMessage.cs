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
    /// 例子
    /// </summary>
    public class ExampleMessage
    {
        
        public const string INDEX_NAME = "Example";
        
        private const string _nonPara = "NonPara";
        
        private const string _withOnePara = "WithOnePara";
        
        private const string _withMorePara = "WithMorePara";
        
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
        /// 10000001 无参数的Message！
        /// </summary>
        public static Message NonPara
        {
            get
            {
                return Index[_nonPara];
            }
        }
        
        /// <summary>
        /// 10000002 有一个参数的Message,参数={0}！
        /// </summary>
        public static Message WithOnePara
        {
            get
            {
                return Index[_withOnePara];
            }
        }
        
        /// <summary>
        /// 10000003 有多个参数的Message,第一个参数是={0}，第二个参数是={1}，第三个参数是={2}！
        /// </summary>
        public static Message WithMorePara
        {
            get
            {
                return Index[_withMorePara];
            }
        }
    }
}
