namespace XMLMessageGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CodeGeneratorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nameSpaceTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.xmlLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rootCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CodeGeneratorBtn
            // 
            this.CodeGeneratorBtn.Location = new System.Drawing.Point(309, 205);
            this.CodeGeneratorBtn.Name = "CodeGeneratorBtn";
            this.CodeGeneratorBtn.Size = new System.Drawing.Size(75, 23);
            this.CodeGeneratorBtn.TabIndex = 0;
            this.CodeGeneratorBtn.Text = "代码生成";
            this.CodeGeneratorBtn.UseVisualStyleBackColor = true;
            this.CodeGeneratorBtn.Click += new System.EventHandler(this.CodeGeneratorBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "项目命名空间";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // nameSpaceTxt
            // 
            this.nameSpaceTxt.Location = new System.Drawing.Point(145, 40);
            this.nameSpaceTxt.Name = "nameSpaceTxt";
            this.nameSpaceTxt.Size = new System.Drawing.Size(239, 21);
            this.nameSpaceTxt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "添加XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "XML地址";
            // 
            // xmlLabel
            // 
            this.xmlLabel.AutoSize = true;
            this.xmlLabel.Location = new System.Drawing.Point(145, 95);
            this.xmlLabel.Name = "xmlLabel";
            this.xmlLabel.Size = new System.Drawing.Size(0, 12);
            this.xmlLabel.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(33, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 16);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "引入项目命名空间";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rootCheckBox
            // 
            this.rootCheckBox.AutoSize = true;
            this.rootCheckBox.Location = new System.Drawing.Point(264, 144);
            this.rootCheckBox.Name = "rootCheckBox";
            this.rootCheckBox.Size = new System.Drawing.Size(108, 16);
            this.rootCheckBox.TabIndex = 8;
            this.rootCheckBox.Text = "是否Root根节点";
            this.rootCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 262);
            this.Controls.Add(this.rootCheckBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.xmlLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameSpaceTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodeGeneratorBtn);
            this.Name = "Form1";
            this.Text = "MessageCodeGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CodeGeneratorBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox nameSpaceTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label xmlLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox rootCheckBox;
    }
}

