using System;
using System.Xml;
using System.Collections.Generic;

namespace XMLMessageGenerator
{
   public class XmlHelper
    {
       public static List<MessageModel> GetMessageModelListByXml(string path)
       {
           List<MessageModel> result = new List<MessageModel>();

           try
           {
               XmlDocument doc = new XmlDocument();
               doc.Load(path);

               //得到上层父节点
               XmlNode xn = doc.SelectSingleNode("InformationSection");
               if (xn == null)
               {
                   return result;
               }

               //得到根节点所有子节点
               XmlNodeList indexsXnl = xn.ChildNodes;

               if (indexsXnl == null)
               {
                    return result;
               }

               XmlNodeList childXnl = indexsXnl[0].ChildNodes;
               foreach (XmlNode child in childXnl)
               {
                   MessageModel messageModel = new MessageModel();
                   XmlElement xe = (XmlElement)child;
                   messageModel.Domain = xe.GetAttribute("Name").ToString();
                   messageModel.Description = xe.GetAttribute("Description").ToString();
                   messageModel.DomainCode = Convert.ToInt32(xe.GetAttribute("ID").ToString());
                   XmlNode subNode = xe.SelectSingleNode("Informations");
                   messageModel.DetailList = new List<MessageDetail>();
                   XmlNodeList subNodeList = subNode.ChildNodes;

                   if (subNodeList == null)
                   {
                       return result;
                   }

                   foreach (XmlNode subItem in subNodeList)
                   {
                       MessageDetail detail = new MessageDetail();
                       XmlElement subXElement = (XmlElement)subItem;
                       detail.Alias = subXElement.GetAttribute("Name").ToString();
                       detail.Code = subXElement.GetAttribute("Sequence").ToString();
                       detail.Message = string.Format("{0} {1}", (Convert.ToInt32(messageModel.DomainCode) + Convert.ToInt32(detail.Code)).ToString(), subXElement.GetAttribute("Messge").ToString()); ;
                       messageModel.DetailList.Add(detail);
                   }

                   result.Add(messageModel);

               }

           }
           catch (Exception ex)
           {

               throw;
           }

           return result;
       }

       public static List<MessageModel> GetRootMessageModelListByXml(string path)
       {
           List<MessageModel> result = new List<MessageModel>();

           try
           {
               XmlDocument doc = new XmlDocument();
               doc.Load(path);

               //得到上层父节点
               XmlNode xn = doc.SelectSingleNode("ROOT");
               if (xn == null)
               {
                   return result;
               }

               //得到根节点所有子节点
               XmlNodeList indexsXnl = xn.ChildNodes;


               foreach (XmlNode child in indexsXnl)
               {
                   MessageModel messageModel = new MessageModel();
                   XmlElement xe = (XmlElement)child;
                   messageModel.Domain = xe.GetAttribute("Name").ToString();
                   messageModel.Description = xe.GetAttribute("Description").ToString();
                   messageModel.DomainCode = Convert.ToInt32(xe.GetAttribute("id").ToString());

                   messageModel.DetailList = new List<MessageDetail>();
                   XmlNodeList subNodeList = xe.ChildNodes;

                   if (subNodeList == null)
                   {
                       return result;
                   }

                   foreach (XmlNode subItem in subNodeList)
                   {
                       MessageDetail detail = new MessageDetail();
                       XmlElement subXElement = (XmlElement)subItem;
                       detail.Alias = subXElement.GetAttribute("Name").ToString();
                       detail.Code = subXElement.GetAttribute("Sequence").ToString();
                       detail.Message = string.Format("{0} {1}", (Convert.ToInt32(messageModel.DomainCode) + Convert.ToInt32(detail.Code)).ToString(), subXElement.GetAttribute("Messge").ToString()); ;
                       messageModel.DetailList.Add(detail);
                   }

                   result.Add(messageModel);

               }

           }
           catch (Exception ex)
           {

               throw;
           }

           return result;
       }
    }
}
