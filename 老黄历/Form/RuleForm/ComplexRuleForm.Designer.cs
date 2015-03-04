namespace 老黄历
{
    partial class ComplexRuleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbSeason = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddToResultList = new System.Windows.Forms.Button();
            this.rdbHour = new System.Windows.Forms.RadioButton();
            this.rdbDay = new System.Windows.Forms.RadioButton();
            this.rdbMonth = new System.Windows.Forms.RadioButton();
            this.rdbYear = new System.Windows.Forms.RadioButton();
            this.rdbHourHE = new System.Windows.Forms.RadioButton();
            this.rdbDayHE = new System.Windows.Forms.RadioButton();
            this.rdbMonthHE = new System.Windows.Forms.RadioButton();
            this.btnChooseValue = new System.Windows.Forms.Button();
            this.txtFieldValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdb28 = new System.Windows.Forms.RadioButton();
            this.rdbYearHE = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOperators = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExpressionResult = new System.Windows.Forms.TextBox();
            this.btnSure = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择字段：";
            // 
            // rdbSeason
            // 
            this.rdbSeason.AutoSize = true;
            this.rdbSeason.Location = new System.Drawing.Point(89, 20);
            this.rdbSeason.Name = "rdbSeason";
            this.rdbSeason.Size = new System.Drawing.Size(107, 16);
            this.rdbSeason.TabIndex = 1;
            this.rdbSeason.TabStop = true;
            this.rdbSeason.Text = "四季（按节气）";
            this.rdbSeason.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddToResultList);
            this.groupBox1.Controls.Add(this.rdbHour);
            this.groupBox1.Controls.Add(this.rdbDay);
            this.groupBox1.Controls.Add(this.rdbMonth);
            this.groupBox1.Controls.Add(this.rdbYear);
            this.groupBox1.Controls.Add(this.rdbHourHE);
            this.groupBox1.Controls.Add(this.rdbDayHE);
            this.groupBox1.Controls.Add(this.rdbMonthHE);
            this.groupBox1.Controls.Add(this.btnChooseValue);
            this.groupBox1.Controls.Add(this.txtFieldValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdb28);
            this.groupBox1.Controls.Add(this.rdbYearHE);
            this.groupBox1.Controls.Add(this.rdbSeason);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnAddToResultList
            // 
            this.btnAddToResultList.Location = new System.Drawing.Point(321, 151);
            this.btnAddToResultList.Name = "btnAddToResultList";
            this.btnAddToResultList.Size = new System.Drawing.Size(75, 23);
            this.btnAddToResultList.TabIndex = 13;
            this.btnAddToResultList.Text = "加入到结果";
            this.btnAddToResultList.UseVisualStyleBackColor = true;
            this.btnAddToResultList.Click += new System.EventHandler(this.btnAddToResultList_Click);
            // 
            // rdbHour
            // 
            this.rdbHour.AutoSize = true;
            this.rdbHour.Location = new System.Drawing.Point(287, 89);
            this.rdbHour.Name = "rdbHour";
            this.rdbHour.Size = new System.Drawing.Size(35, 16);
            this.rdbHour.TabIndex = 12;
            this.rdbHour.TabStop = true;
            this.rdbHour.Text = "时";
            this.rdbHour.UseVisualStyleBackColor = true;
            // 
            // rdbDay
            // 
            this.rdbDay.AutoSize = true;
            this.rdbDay.Location = new System.Drawing.Point(222, 89);
            this.rdbDay.Name = "rdbDay";
            this.rdbDay.Size = new System.Drawing.Size(35, 16);
            this.rdbDay.TabIndex = 11;
            this.rdbDay.TabStop = true;
            this.rdbDay.Text = "日";
            this.rdbDay.UseVisualStyleBackColor = true;
            // 
            // rdbMonth
            // 
            this.rdbMonth.AutoSize = true;
            this.rdbMonth.Location = new System.Drawing.Point(157, 89);
            this.rdbMonth.Name = "rdbMonth";
            this.rdbMonth.Size = new System.Drawing.Size(35, 16);
            this.rdbMonth.TabIndex = 10;
            this.rdbMonth.TabStop = true;
            this.rdbMonth.Text = "月";
            this.rdbMonth.UseVisualStyleBackColor = true;
            // 
            // rdbYear
            // 
            this.rdbYear.AutoSize = true;
            this.rdbYear.Location = new System.Drawing.Point(89, 89);
            this.rdbYear.Name = "rdbYear";
            this.rdbYear.Size = new System.Drawing.Size(35, 16);
            this.rdbYear.TabIndex = 9;
            this.rdbYear.TabStop = true;
            this.rdbYear.Text = "年";
            this.rdbYear.UseVisualStyleBackColor = true;
            // 
            // rdbHourHE
            // 
            this.rdbHourHE.AutoSize = true;
            this.rdbHourHE.Location = new System.Drawing.Point(287, 58);
            this.rdbHourHE.Name = "rdbHourHE";
            this.rdbHourHE.Size = new System.Drawing.Size(59, 16);
            this.rdbHourHE.TabIndex = 8;
            this.rdbHourHE.TabStop = true;
            this.rdbHourHE.Text = "时甲子";
            this.rdbHourHE.UseVisualStyleBackColor = true;
            // 
            // rdbDayHE
            // 
            this.rdbDayHE.AutoSize = true;
            this.rdbDayHE.Checked = true;
            this.rdbDayHE.Location = new System.Drawing.Point(222, 58);
            this.rdbDayHE.Name = "rdbDayHE";
            this.rdbDayHE.Size = new System.Drawing.Size(59, 16);
            this.rdbDayHE.TabIndex = 7;
            this.rdbDayHE.TabStop = true;
            this.rdbDayHE.Text = "日甲子";
            this.rdbDayHE.UseVisualStyleBackColor = true;
            // 
            // rdbMonthHE
            // 
            this.rdbMonthHE.AutoSize = true;
            this.rdbMonthHE.Location = new System.Drawing.Point(157, 58);
            this.rdbMonthHE.Name = "rdbMonthHE";
            this.rdbMonthHE.Size = new System.Drawing.Size(59, 16);
            this.rdbMonthHE.TabIndex = 6;
            this.rdbMonthHE.TabStop = true;
            this.rdbMonthHE.Text = "月甲子";
            this.rdbMonthHE.UseVisualStyleBackColor = true;
            // 
            // btnChooseValue
            // 
            this.btnChooseValue.Location = new System.Drawing.Point(327, 122);
            this.btnChooseValue.Name = "btnChooseValue";
            this.btnChooseValue.Size = new System.Drawing.Size(69, 23);
            this.btnChooseValue.TabIndex = 5;
            this.btnChooseValue.Text = "选择值";
            this.btnChooseValue.UseVisualStyleBackColor = true;
            this.btnChooseValue.Click += new System.EventHandler(this.btnChooseValue_Click);
            // 
            // txtFieldValue
            // 
            this.txtFieldValue.Location = new System.Drawing.Point(89, 124);
            this.txtFieldValue.Name = "txtFieldValue";
            this.txtFieldValue.Size = new System.Drawing.Size(220, 21);
            this.txtFieldValue.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "字段值：";
            // 
            // rdb28
            // 
            this.rdb28.AutoSize = true;
            this.rdb28.Location = new System.Drawing.Point(202, 22);
            this.rdb28.Name = "rdb28";
            this.rdb28.Size = new System.Drawing.Size(59, 16);
            this.rdb28.TabIndex = 3;
            this.rdb28.TabStop = true;
            this.rdb28.Text = "28星宿";
            this.rdb28.UseVisualStyleBackColor = true;
            // 
            // rdbYearHE
            // 
            this.rdbYearHE.AutoSize = true;
            this.rdbYearHE.Location = new System.Drawing.Point(89, 58);
            this.rdbYearHE.Name = "rdbYearHE";
            this.rdbYearHE.Size = new System.Drawing.Size(59, 16);
            this.rdbYearHE.TabIndex = 2;
            this.rdbYearHE.TabStop = true;
            this.rdbYearHE.Text = "年甲子";
            this.rdbYearHE.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "运算符：";
            // 
            // cmbOperators
            // 
            this.cmbOperators.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperators.FormattingEnabled = true;
            this.cmbOperators.Items.AddRange(new object[] {
            "无",
            "或者",
            "而且",
            "排除"});
            this.cmbOperators.Location = new System.Drawing.Point(89, 185);
            this.cmbOperators.Name = "cmbOperators";
            this.cmbOperators.Size = new System.Drawing.Size(220, 20);
            this.cmbOperators.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "结果：";
            // 
            // txtExpressionResult
            // 
            this.txtExpressionResult.Location = new System.Drawing.Point(89, 227);
            this.txtExpressionResult.Multiline = true;
            this.txtExpressionResult.Name = "txtExpressionResult";
            this.txtExpressionResult.Size = new System.Drawing.Size(233, 100);
            this.txtExpressionResult.TabIndex = 6;
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(157, 347);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 23);
            this.btnSure.TabIndex = 7;
            this.btnSure.Text = "确定";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // AllRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 382);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.txtExpressionResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbOperators);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AllRuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "复制规则构造";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbSeason;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdb28;
        private System.Windows.Forms.RadioButton rdbYearHE;
        private System.Windows.Forms.TextBox txtFieldValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOperators;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExpressionResult;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Button btnChooseValue;
        private System.Windows.Forms.RadioButton rdbHourHE;
        private System.Windows.Forms.RadioButton rdbDayHE;
        private System.Windows.Forms.RadioButton rdbMonthHE;
        private System.Windows.Forms.RadioButton rdbHour;
        private System.Windows.Forms.RadioButton rdbDay;
        private System.Windows.Forms.RadioButton rdbMonth;
        private System.Windows.Forms.RadioButton rdbYear;
        private System.Windows.Forms.Button btnAddToResultList;
    }
}