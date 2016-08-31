using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Xml;

namespace XMLMessageGenerator
{
    public class CodeGenerator
    {
        public static bool MessageCodeGenerator(string path, string nameSpace, bool isRoot)
        {
            List<MessageModel> result = null;
            if (isRoot)
            {
                result = XmlHelper.GetRootMessageModelListByXml(path);
            }
            else
                result = XmlHelper.GetMessageModelListByXml(path);

            if (result == null || result.Count == 0)
            {
                return false;
            }

            try
            {
                string messageIndexName = "MessageIndex";
                string messsageName = "Message";
                string infomationNameSpace = "Information";
                if (!string.IsNullOrWhiteSpace(nameSpace))
                {
                    infomationNameSpace = string.Format("{0}.{1}", nameSpace, infomationNameSpace);
                }

                #region  foreach generator

                foreach (var item in result)
                {
                    #region 初始化
                    //准备一个代码编译器单元
                    CodeCompileUnit unit = new CodeCompileUnit();

                    //准备必要的命名空间（这个是指要生成的类的空间）
                    CodeNamespace sampleNamespace = new CodeNamespace(infomationNameSpace);

                    //导入必要的命名空间
                    sampleNamespace.Imports.Add(new CodeNamespaceImport("System"));
                    if (!string.IsNullOrWhiteSpace(nameSpace))
                    {
                        sampleNamespace.Imports.Add(new CodeNamespaceImport(nameSpace + ".Information.Core"));
                    }


                    //准备要生成的类的定义
                    string name = item.Domain.ToString() + "Message";
                    CodeTypeDeclaration MesssageClass = new CodeTypeDeclaration(name);

                    //指定这是一个Class

                    MesssageClass.IsClass = true;

                    MesssageClass.TypeAttributes = TypeAttributes.Public;
                    MesssageClass.Comments.Add(new CodeCommentStatement("<summary>",true));
                    MesssageClass.Comments.Add(new CodeCommentStatement(item.Description, true));
                    MesssageClass.Comments.Add(new CodeCommentStatement("</summary>", true));

                    //把这个类放在这个命名空间下

                    sampleNamespace.Types.Add(MesssageClass);

                    //把该命名空间加入到编译器单元的命名空间集合中

                    unit.Namespaces.Add(sampleNamespace);

                    //这是输出文件

                    string outputFile = string.Format("{0}.cs", name);

                    #endregion

                    #region IndexName

                    CodeMemberField indexField = new CodeMemberField(typeof(String), "INDEX_NAME");

                    indexField.Attributes = MemberAttributes.Public | MemberAttributes.Const;


                    indexField.InitExpression = new CodePrimitiveExpression(item.Domain);

                    MesssageClass.Members.Add(indexField);


                    #endregion

                    #region 依次新增MessageDetail

                    foreach (var detail in item.DetailList)
                    {
                        CodeMemberField detailMember = new CodeMemberField(typeof(String), GetPropertyAliasName(detail.Alias));

                        detailMember.Attributes = MemberAttributes.Private | MemberAttributes.Const;

                        detailMember.InitExpression = new CodePrimitiveExpression(detail.Alias);

                        MesssageClass.Members.Add(detailMember);

                    }
                    #endregion

                    #region Index属性

                    //添加字段

                    CodeMemberField field = new CodeMemberField(messageIndexName, "_index");

                    field.Attributes = MemberAttributes.Private | MemberAttributes.Static;

                    MesssageClass.Members.Add(field);

                    //添加属性

                    CodeMemberProperty property = new CodeMemberProperty();

                    property.Attributes = MemberAttributes.Private | MemberAttributes.Static;

                    property.Name = "Index";

                    property.HasGet = true;

                    property.HasSet = false;

                    property.Type = new CodeTypeReference(messageIndexName);

                    property.Comments.Add(new CodeCommentStatement("<summary>", true));
                    property.Comments.Add(new CodeCommentStatement("索引属性", true));
                    property.Comments.Add(new CodeCommentStatement("</summary>", true));

                    property.GetStatements.Add(new CodeMethodReturnStatement(new CodeSnippetExpression("_index ?? (_index = MessageCache.GetIndex(INDEX_NAME))")));

                    //base.XXXX
                    //property.GetStatements.Add(new CodeMethodReturnStatement(new CodeFieldReferenceExpression(new CodeBaseReferenceExpression(), "_index ?? (_index = MessageCache.GetIndex(INDEX_NAME))")));

                    //this.XXXX
                    // property.SetStatements.Add(new CodeAssignStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "_Id"), new CodePropertySetValueReferenceExpression()));

                    MesssageClass.Members.Add(property);

                    //添加方法（使用CodeMemberMethod)--此处略

                    //添加构造器(使用CodeConstructor) --此处略

                    //添加程序入口点（使用CodeEntryPointMethod） --此处略

                    //添加事件（使用CodeMemberEvent) --此处略

                    //添加特征(使用 CodeAttributeDeclaration)

                    //MesssageClass.CustomAttributes.Add(new CodeAttributeDeclaration(new CodeTypeReference(typeof(SerializableAttribute))));

                    #endregion

                    #region 依次新增MessageProperty

                    foreach (var detail in item.DetailList)
                    {

                        CodeMemberProperty detailProperty = new CodeMemberProperty();

                        detailProperty.Attributes = MemberAttributes.Public | MemberAttributes.Static;

                        detailProperty.Name = detail.Alias;

                        detailProperty.HasGet = true;

                        detailProperty.HasSet = false;

                        detailProperty.Type = new CodeTypeReference(messsageName);

                        detailProperty.Comments.Add(new CodeCommentStatement("<summary>", true));
                        detailProperty.Comments.Add(new CodeCommentStatement(detail.Message, true));
                        detailProperty.Comments.Add(new CodeCommentStatement("</summary>", true));

                        detailProperty.GetStatements.Add(new CodeMethodReturnStatement(new CodeSnippetExpression(string.Format("Index[{0}]", GetPropertyAliasName(detail.Alias)))));

                        MesssageClass.Members.Add(detailProperty);
                    }

                    #endregion

                    #region 生成代码

                    //生成代码

                    CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");

                    CodeGeneratorOptions options = new CodeGeneratorOptions();

                    options.BracingStyle = "C";

                    options.BlankLinesBetweenMembers = true;

                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(outputFile))
                    {

                        provider.GenerateCodeFromCompileUnit(unit, sw, options);

                    }
                    #endregion
                }
                #endregion
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static string GetPropertyAliasName(string name)
        {
            return "_" + name.Substring(0, 1).ToLower() + name.Substring(1, name.Length - 1);
        }
    }
}
