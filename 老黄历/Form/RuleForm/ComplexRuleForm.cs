using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 老黄历
{
    public partial class ComplexRuleForm : Form
    {
        public ComplexRuleForm()
        {
            InitializeComponent();
        }

        private FieldTypeName ChooseFieldTypeName { get; set; }

        private void btnChooseValue_Click(object sender, EventArgs e)
        {
            SelectFormBase f = null;

            if (rdbDayHE.Checked || rdbHourHE.Checked || rdbMonthHE.Checked || rdbYearHE.Checked)
            {
                if (rdbDayHE.Checked)
                    ChooseFieldTypeName = FieldTypeName.日甲子;
                if (rdbHourHE.Checked)
                    ChooseFieldTypeName = FieldTypeName.时甲子;
                if (rdbMonthHE.Checked)
                    ChooseFieldTypeName = FieldTypeName.月甲子;
                if (rdbYearHE.Checked)
                    ChooseFieldTypeName = FieldTypeName.年甲子;

                f = new HESelectForm();
            }

            if (rdbDay.Checked)
            {
                ChooseFieldTypeName = FieldTypeName.日;
                f = new DaySelectForm();
            }

            if (rdbYear.Checked)
            {
                ChooseFieldTypeName = 老黄历.FieldTypeName.年;
                MessageBox.Show("请直接输入年数值");
                return;
            }

            if (rdbMonth.Checked)
            {
                ChooseFieldTypeName = FieldTypeName.月;
                f = new MonthSelectForm();
            }

            if (rdb28.Checked)
            {
                ChooseFieldTypeName = FieldTypeName.星宿;
                f = new TwentyEightMansionsSelectForm();
            }

            if (rdbSeason.Checked)
            {
                ChooseFieldTypeName = FieldTypeName.四季;
                f = new SeasonSelectForm();
            }

            if (rdbHour.Checked)
            {
                ChooseFieldTypeName = FieldTypeName.时;
                MessageBox.Show("还没有做小时的！");
                return;
            }

            f.ShowDialog();

            txtFieldValue.Text = f.GetSelectValue();

        }

        private string format = "({0}:{1})";

        private void btnAddToResultList_Click(object sender, EventArgs e)
        {
            var current = string.Format(format, ChooseFieldTypeName.ToString(), txtFieldValue.Text);

            if (cmbOperators.Text != "无")
            {
                if (txtExpressionResult.Text != string.Empty)
                {
                    current = cmbOperators.Text + current;
                }
                else
                {
                    current += cmbOperators.Text;
                }
            }

            txtExpressionResult.Text += current;
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            this.RuleString = txtExpressionResult.Text;
            this.Close();
        }

        public string RuleString { get; private set; }
    }

    
}
