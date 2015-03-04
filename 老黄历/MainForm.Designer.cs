namespace 老黄历
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnEditRule = new System.Windows.Forms.Button();
            this.chkRuleList = new System.Windows.Forms.CheckedListBox();
            this.btnSetRules = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbAvoidResult = new System.Windows.Forms.RadioButton();
            this.rdbShouldResult = new System.Windows.Forms.RadioButton();
            this.rdbAllResult = new System.Windows.Forms.RadioButton();
            this.dgvFindResult = new System.Windows.Forms.DataGridView();
            this.DateTime = new System.Windows.Forms.DataGridViewLinkColumn();
            this.农历日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CnDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结果 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkCurrentRules = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.万年历日期1 = new 老黄历.PermanentCalendar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 512);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "规则和查找";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnEditRule);
            this.splitContainer1.Panel1.Controls.Add(this.chkRuleList);
            this.splitContainer1.Panel1.Controls.Add(this.btnSetRules);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.dgvFindResult);
            this.splitContainer1.Panel2.Controls.Add(this.chkCurrentRules);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.btnFind);
            this.splitContainer1.Size = new System.Drawing.Size(779, 480);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnEditRule
            // 
            this.btnEditRule.Location = new System.Drawing.Point(14, 12);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(74, 23);
            this.btnEditRule.TabIndex = 17;
            this.btnEditRule.Text = "编辑规则";
            this.btnEditRule.UseVisualStyleBackColor = true;
            this.btnEditRule.Click += new System.EventHandler(this.btnEditRule_Click);
            // 
            // chkRuleList
            // 
            this.chkRuleList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkRuleList.FormattingEnabled = true;
            this.chkRuleList.Location = new System.Drawing.Point(0, 44);
            this.chkRuleList.Name = "chkRuleList";
            this.chkRuleList.Size = new System.Drawing.Size(172, 436);
            this.chkRuleList.TabIndex = 16;
            this.chkRuleList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkRuleList_ItemCheck);
            // 
            // btnSetRules
            // 
            this.btnSetRules.Location = new System.Drawing.Point(94, 12);
            this.btnSetRules.Name = "btnSetRules";
            this.btnSetRules.Size = new System.Drawing.Size(62, 23);
            this.btnSetRules.TabIndex = 15;
            this.btnSetRules.Text = "添加规则";
            this.btnSetRules.UseVisualStyleBackColor = true;
            this.btnSetRules.Click += new System.EventHandler(this.btnSetRules_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbAvoidResult);
            this.groupBox2.Controls.Add(this.rdbShouldResult);
            this.groupBox2.Controls.Add(this.rdbAllResult);
            this.groupBox2.Location = new System.Drawing.Point(3, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 35);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // rdbAvoidResult
            // 
            this.rdbAvoidResult.AutoSize = true;
            this.rdbAvoidResult.Location = new System.Drawing.Point(315, 13);
            this.rdbAvoidResult.Name = "rdbAvoidResult";
            this.rdbAvoidResult.Size = new System.Drawing.Size(35, 16);
            this.rdbAvoidResult.TabIndex = 2;
            this.rdbAvoidResult.Text = "忌";
            this.rdbAvoidResult.UseVisualStyleBackColor = true;
            this.rdbAvoidResult.CheckedChanged += new System.EventHandler(this.rdbAvoidResult_CheckedChanged);
            // 
            // rdbShouldResult
            // 
            this.rdbShouldResult.AutoSize = true;
            this.rdbShouldResult.Location = new System.Drawing.Point(244, 13);
            this.rdbShouldResult.Name = "rdbShouldResult";
            this.rdbShouldResult.Size = new System.Drawing.Size(35, 16);
            this.rdbShouldResult.TabIndex = 1;
            this.rdbShouldResult.Text = "宜";
            this.rdbShouldResult.UseVisualStyleBackColor = true;
            this.rdbShouldResult.CheckedChanged += new System.EventHandler(this.rdbShouldResult_CheckedChanged);
            // 
            // rdbAllResult
            // 
            this.rdbAllResult.AutoSize = true;
            this.rdbAllResult.Checked = true;
            this.rdbAllResult.Location = new System.Drawing.Point(172, 13);
            this.rdbAllResult.Name = "rdbAllResult";
            this.rdbAllResult.Size = new System.Drawing.Size(47, 16);
            this.rdbAllResult.TabIndex = 0;
            this.rdbAllResult.TabStop = true;
            this.rdbAllResult.Text = "全部";
            this.rdbAllResult.UseVisualStyleBackColor = true;
            this.rdbAllResult.CheckedChanged += new System.EventHandler(this.rdbAllResult_CheckedChanged);
            // 
            // dgvFindResult
            // 
            this.dgvFindResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFindResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFindResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTime,
            this.农历日期,
            this.CnDateTime,
            this.Column1,
            this.结果});
            this.dgvFindResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFindResult.Location = new System.Drawing.Point(0, 210);
            this.dgvFindResult.Name = "dgvFindResult";
            this.dgvFindResult.RowTemplate.Height = 23;
            this.dgvFindResult.Size = new System.Drawing.Size(603, 270);
            this.dgvFindResult.TabIndex = 16;
            this.dgvFindResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFindResult_CellContentClick);
            this.dgvFindResult.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvFindResult_RowPrePaint);
            // 
            // DateTime
            // 
            this.DateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DateTime.DataPropertyName = "DateTime";
            this.DateTime.Frozen = true;
            this.DateTime.HeaderText = "日期";
            this.DateTime.Name = "DateTime";
            this.DateTime.Width = 112;
            // 
            // 农历日期
            // 
            this.农历日期.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.农历日期.DataPropertyName = "CnDateTime";
            this.农历日期.Frozen = true;
            this.农历日期.HeaderText = "农历日期";
            this.农历日期.Name = "农历日期";
            this.农历日期.Width = 112;
            // 
            // CnDateTime
            // 
            this.CnDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CnDateTime.DataPropertyName = "DateTimeHE";
            this.CnDateTime.Frozen = true;
            this.CnDateTime.HeaderText = "八字";
            this.CnDateTime.Name = "CnDateTime";
            this.CnDateTime.Width = 112;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Status";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "状态";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 112;
            // 
            // 结果
            // 
            this.结果.DataPropertyName = "Result";
            this.结果.HeaderText = "结果";
            this.结果.Name = "结果";
            // 
            // chkCurrentRules
            // 
            this.chkCurrentRules.ColumnWidth = 50;
            this.chkCurrentRules.FormattingEnabled = true;
            this.chkCurrentRules.Location = new System.Drawing.Point(16, 77);
            this.chkCurrentRules.Name = "chkCurrentRules";
            this.chkCurrentRules.Size = new System.Drawing.Size(440, 84);
            this.chkCurrentRules.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 53);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(79, 20);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(141, 21);
            this.dtStart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "起始日期：";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(320, 19);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(141, 21);
            this.dtEnd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "结束日期：";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(478, 93);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(109, 39);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "找期辰";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.万年历日期1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "万年历页面";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // 万年历日期1
            // 
            this.万年历日期1.Location = new System.Drawing.Point(61, 18);
            this.万年历日期1.Name = "万年历日期1";
            this.万年历日期1.Size = new System.Drawing.Size(592, 448);
            this.万年历日期1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 512);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "老黄历 Version 1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.TabPage tabPage2;
        private PermanentCalendar 万年历日期1;
        private System.Windows.Forms.Button btnSetRules;
        private System.Windows.Forms.CheckedListBox chkCurrentRules;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFindResult;
        private System.Windows.Forms.CheckedListBox chkRuleList;
        private System.Windows.Forms.Button btnEditRule;
        private System.Windows.Forms.DataGridViewLinkColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn 农历日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn CnDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结果;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbAllResult;
        private System.Windows.Forms.RadioButton rdbAvoidResult;
        private System.Windows.Forms.RadioButton rdbShouldResult;

    }
}