using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace 老黄历
{
    public partial class RuleCreateAndEdit : Form
    {
        public RuleCreateAndEdit()
        {
            InitializeComponent();

            this.Text = "创建规则";
        }

        private SingleRule ruleData;

        public RuleCreateAndEdit(SingleRule ruleData)
        {
            InitializeComponent();

            this.ruleData = ruleData;

            txtRuleName.Text = ruleData.Name;
            txtSyntaxRule.Text = ruleData.SyntaxRule;
            txtMessageFomat.Text = ruleData.MessageFormat;
            txtDescription.Text = ruleData.Description;
            rdbShould.Checked = ruleData.ShouldAvoid;
            rdbAvoid.Checked = !ruleData.ShouldAvoid;

            this.Text = "编辑规则";
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveRule_Click(object sender, EventArgs e)
        {
            SingleRule signleRule = new SingleRule();
            signleRule.Name = txtRuleName.Text.Trim();
            signleRule.Description = txtDescription.Text.Trim();
            signleRule.MessageFormat = txtMessageFomat.Text.Trim();
            signleRule.SyntaxRule = txtSyntaxRule.Text.Trim();

            signleRule.ShouldAvoid = rdbShould.Checked ? true : false;

            //基本验证
            if (signleRule.Name == string.Empty)
            {
                MessageBox.Show("请输入一个规则名称！如:‘大明吉日’");
                return;
            }

            if (signleRule.SyntaxRule == string.Empty)
            {
                MessageBox.Show("请选择值！如:‘(月:正|四|七|十)’");
                return;
            }

            if (signleRule.MessageFormat == string.Empty)
            {
                MessageBox.Show("请输入消息格式！如:‘{0}是天皇銮驾’");
                return;
            }

            if (ruleData != null)
            {
                RuleFileConfig.EidtRule(signleRule, ruleData.Name);
            }
            else
            {
                RuleFileConfig.AddRule(signleRule);
            }

            this.Save = true;

            this.Close();
        }

        public bool Save { get; private set; }

        private void btnConstructValue_Click(object sender, EventArgs e)
        {
            ComplexRuleForm f = new ComplexRuleForm();
            f.ShowDialog();

            txtSyntaxRule.Text = f.RuleString;
        }
    }
}
