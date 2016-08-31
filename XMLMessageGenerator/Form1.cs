using System;
using System.Windows.Forms;

namespace XMLMessageGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CodeGeneratorBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.xmlLabel.Text))
            {
                MessageBox.Show("先选择xml路径地址");
                return;
            }
            if (checkBox1.Checked)
            {
                if (string.IsNullOrWhiteSpace(this.nameSpaceTxt.Text))
                {
                    MessageBox.Show("请填写项目命名空间");
                    return;
                }
            }

            var result = CodeGenerator.MessageCodeGenerator(this.xmlLabel.Text, this.nameSpaceTxt.Text, rootCheckBox.Checked);


            if (result == false)
            {
                MessageBox.Show("代码生成失败，请验证XML是否满足格式");
                return;
            }
            else
            {
                MessageBox.Show("代码生成成功!");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileName = new OpenFileDialog();
            fileName.InitialDirectory = Application.StartupPath;
            fileName.Filter = "XML文件|*.xml";
            fileName.RestoreDirectory = true;
            if (fileName.ShowDialog() == DialogResult.OK)
            {
                string path = fileName.FileName.ToString();
                string name = path.Substring(path.LastIndexOf("\\") + 1);
                //MessageBox.Show("文件目录:" + path);
                //MessageBox.Show("文件名:" + name);
                this.xmlLabel.Text = path;
                MessageBox.Show("XML加载成功!");
            }
        }
    }
}
