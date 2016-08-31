using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLMessageGenerator
{
   public class MessageModel
    {
        public string Domain { get; set; }

        public int DomainCode { get; set; }

        public string Description { get; set; }

        public List<MessageDetail> DetailList { get; set; }
    }

   public class MessageDetail
   {
       public string Message { get; set; }

       public string Code { get; set; }

       public string Alias { get; set; }
   }
}
