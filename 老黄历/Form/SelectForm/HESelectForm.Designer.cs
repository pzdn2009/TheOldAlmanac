namespace 老黄历
{
    partial class HESelectForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHS = new System.Windows.Forms.ComboBox();
            this.cmbEB = new System.Windows.Forms.ComboBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.lsbHE = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "天干：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "地支：";
            // 
            // cmbHS
            // 
            this.cmbHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHS.FormattingEnabled = true;
            this.cmbHS.Items.AddRange(new object[] {
            "*",
            "甲",
            "乙",
            "丙",
            "丁",
            "戊",
            "己",
            "庚",
            "辛",
            "壬",
            "癸"});
            this.cmbHS.Location = new System.Drawing.Point(89, 12);
            this.cmbHS.Name = "cmbHS";
            this.cmbHS.Size = new System.Drawing.Size(121, 20);
            this.cmbHS.TabIndex = 2;
            this.cmbHS.SelectedIndexChanged += new System.EventHandler(this.cmbHS_SelectedIndexChanged);
            // 
            // cmbEB
            // 
            this.cmbEB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEB.FormattingEnabled = true;
            this.cmbEB.Items.AddRange(new object[] {
            "*",
            "子",
            "丑",
            "寅",
            "卯",
            "辰",
            "巳",
            "午",
            "未",
            "申",
            "酉",
            "戌",
            "亥"});
            this.cmbEB.Location = new System.Drawing.Point(89, 47);
            this.cmbEB.Name = "cmbEB";
            this.cmbEB.Size = new System.Drawing.Size(121, 20);
            this.cmbEB.TabIndex = 3;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(228, 47);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(75, 23);
            this.btnAddToList.TabIndex = 4;
            this.btnAddToList.Text = "添加到列表";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // lsbHE
            // 
            this.lsbHE.FormattingEnabled = true;
            this.lsbHE.ItemHeight = 12;
            this.lsbHE.Location = new System.Drawing.Point(89, 88);
            this.lsbHE.Name = "lsbHE";
            this.lsbHE.ScrollAlwaysVisible = true;
            this.lsbHE.Size = new System.Drawing.Size(121, 88);
            this.lsbHE.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(89, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "确定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "当前选择：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbHS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddToList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbEB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 82);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(228, 88);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "清空列表";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // HESelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 236);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lsbHE);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HESelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "干支选择";
            this.Load += new System.EventHandler(this.HESelectForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHS;
        private System.Windows.Forms.ComboBox cmbEB;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.ListBox lsbHE;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
    }
}