namespace 老黄历
{
    partial class RuleCreateAndEdit
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConstructValue = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbAvoid = new System.Windows.Forms.RadioButton();
            this.rdbShould = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMessageFomat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSyntaxRule = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRuleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSaveRule = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConstructValue);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMessageFomat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSyntaxRule);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRuleName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rule";
            // 
            // btnConstructValue
            // 
            this.btnConstructValue.Location = new System.Drawing.Point(416, 52);
            this.btnConstructValue.Name = "btnConstructValue";
            this.btnConstructValue.Size = new System.Drawing.Size(75, 23);
            this.btnConstructValue.TabIndex = 13;
            this.btnConstructValue.Text = "构造值";
            this.btnConstructValue.UseVisualStyleBackColor = true;
            this.btnConstructValue.Click += new System.EventHandler(this.btnConstructValue_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(97, 179);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(300, 106);
            this.txtDescription.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "规则描述：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbAvoid);
            this.groupBox3.Controls.Add(this.rdbShould);
            this.groupBox3.Location = new System.Drawing.Point(98, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 39);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // rdbAvoid
            // 
            this.rdbAvoid.AutoSize = true;
            this.rdbAvoid.Location = new System.Drawing.Point(79, 17);
            this.rdbAvoid.Name = "rdbAvoid";
            this.rdbAvoid.Size = new System.Drawing.Size(35, 16);
            this.rdbAvoid.TabIndex = 1;
            this.rdbAvoid.Text = "忌";
            this.rdbAvoid.UseVisualStyleBackColor = true;
            // 
            // rdbShould
            // 
            this.rdbShould.AutoSize = true;
            this.rdbShould.Checked = true;
            this.rdbShould.Location = new System.Drawing.Point(19, 17);
            this.rdbShould.Name = "rdbShould";
            this.rdbShould.Size = new System.Drawing.Size(35, 16);
            this.rdbShould.TabIndex = 0;
            this.rdbShould.TabStop = true;
            this.rdbShould.Text = "宜";
            this.rdbShould.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "值宜忌：";
            // 
            // txtMessageFomat
            // 
            this.txtMessageFomat.Location = new System.Drawing.Point(98, 136);
            this.txtMessageFomat.Name = "txtMessageFomat";
            this.txtMessageFomat.Size = new System.Drawing.Size(299, 21);
            this.txtMessageFomat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "消息格式：";
            // 
            // txtValue
            // 
            this.txtSyntaxRule.Location = new System.Drawing.Point(98, 54);
            this.txtSyntaxRule.Name = "txtValue";
            this.txtSyntaxRule.Size = new System.Drawing.Size(300, 21);
            this.txtSyntaxRule.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "选择值：";
            // 
            // txtRuleName
            // 
            this.txtRuleName.Location = new System.Drawing.Point(98, 16);
            this.txtRuleName.Name = "txtRuleName";
            this.txtRuleName.Size = new System.Drawing.Size(299, 21);
            this.txtRuleName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "规则名称：";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(260, 327);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSaveRule
            // 
            this.btnSaveRule.Location = new System.Drawing.Point(99, 327);
            this.btnSaveRule.Name = "btnSaveRule";
            this.btnSaveRule.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRule.TabIndex = 2;
            this.btnSaveRule.Text = "保存规则";
            this.btnSaveRule.UseVisualStyleBackColor = true;
            this.btnSaveRule.Click += new System.EventHandler(this.btnSaveRule_Click);
            // 
            // RuleCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 372);
            this.Controls.Add(this.btnSaveRule);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RuleCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuleName;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSyntaxRule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMessageFomat;
        private System.Windows.Forms.Button btnSaveRule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbAvoid;
        private System.Windows.Forms.RadioButton rdbShould;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnConstructValue;
    }
}
