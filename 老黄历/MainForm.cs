using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 老黄历
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dtEnd.Value = dtEnd.Value.AddMonths(1);

            //http://blog.csdn.net/ou_yangpengfei/article/details/6051701
            this.dgvFindResult.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvFindResult.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            LoadRules();
        }
        
        /// <summary>
        /// 加载规则集合
        /// </summary>
        private void LoadRules()
        {
            chkRuleList.DataSource = null;
            chkRuleList.Items.Clear();

            var rulesFromXML = RuleFileConfig.LoadRules();
            this.SingleRules = rulesFromXML;

            chkRuleList.DataSource = SingleRules;
            chkRuleList.DisplayMember = "Name";
        }

        private Dictionary<SingleRule, string> dictCurrentRules = new Dictionary<SingleRule, string>();
        public IList<SingleRule> SingleRules { get; set; }

        public IList<DgvViewModel> DgvViewModels { get; set; }

        private void btnRun_Click(object sender, EventArgs e)
        {
            var currentDt = dtStart.Value;

            IList<SingleRule> rules = dictCurrentRules.Keys.ToList();
            List<DgvViewModel> retEntities = new List<DgvViewModel>();

            while (currentDt <= dtEnd.Value)  //遍历每一天
            {
                var cn = new CnLunarCalendar(currentDt);
                var retEntity = new DgvViewModel();

                string goodOrBad = string.Empty;
                string desc = string.Empty;

                foreach (var rule in rules)
                {
                    ComplexRuleResolver rs = new ComplexRuleResolver(rule.SyntaxRule, cn);
                    var ret2 = rs.Start();
                    desc += ret2 == string.Empty ? "" : string.Format(rule.MessageFormat, ret2) + Environment.NewLine;
                    if (ret2 != string.Empty)
                    {
                        goodOrBad += rule.ShouldAvoid ? "宜" : "忌" + Environment.NewLine;
                    }
                    else
                    {
                        goodOrBad += "无" + Environment.NewLine;
                    }

                }

                retEntity.Status = goodOrBad;
                retEntity.Result = desc;
                retEntity.DateTime = currentDt.ToShortDateString();
                retEntity.CnDateTime = cn.ToLunarDateString();
                retEntity.DateTimeHE = cn.ToChineseCharacter();

                retEntities.Add(retEntity);

                currentDt = currentDt.AddDays(1);
            }

            this.DgvViewModels = retEntities;

            this.dgvFindResult.DataSource = DgvViewModels;

        }

        private void btnSetRules_Click(object sender, EventArgs e)
        {
            RuleCreateAndEdit createOrEdit = new RuleCreateAndEdit();
            createOrEdit.ShowDialog();

            if (createOrEdit.Save)
            {
                LoadRules();
            }
        }

        private void chkRuleList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                var rule = this.SingleRules[e.Index];
                chkCurrentRules.Items.Add(rule.Name, false);

                if (!dictCurrentRules.ContainsKey(rule))
                    dictCurrentRules.Add(rule, rule.Name);
                else
                    dictCurrentRules[rule] = rule.Name;

            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                var rule = this.SingleRules[e.Index];
                var ruleName = dictCurrentRules[rule];
                chkCurrentRules.Items.Remove(ruleName);
                dictCurrentRules.Remove(rule);
            }
        }

        private void btnEditRule_Click(object sender, EventArgs e)
        {
            if (chkRuleList.SelectedIndex >= 0)
            {
                RuleCreateAndEdit f = new RuleCreateAndEdit(this.SingleRules[chkRuleList.SelectedIndex]);
                f.ShowDialog();

                if (f.Save)
                {
                    LoadRules();
                }
            }
        }

        #region 结果过滤

        private void rdbAvoidResult_CheckedChanged(object sender, EventArgs e)
        {
            ChooseResult();
        }

        private void rdbShouldResult_CheckedChanged(object sender, EventArgs e)
        {
            ChooseResult();
        }

        private void rdbAllResult_CheckedChanged(object sender, EventArgs e)
        {
            ChooseResult();
        }

        private void ChooseResult()
        {
            if (this.DgvViewModels == null) return;

            if (rdbAvoidResult.Checked)
            {
                dgvFindResult.DataSource = this.DgvViewModels.Where(zw => zw.Status.Contains("忌")).ToList();
            }

            if (rdbAllResult.Checked)
            {
                dgvFindResult.DataSource = this.DgvViewModels;
            }

            if (rdbShouldResult.Checked)
            {
                dgvFindResult.DataSource = this.DgvViewModels.Where(zw => !zw.Status.Contains("忌")).ToList();
            }
        }

        #endregion

        private void dgvFindResult_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvFindResult.RowCount - 1 <= 0) return;

            if (e.RowIndex > dgvFindResult.Rows.Count - 1)
                return;

            DataGridViewRow dgr = dgvFindResult.Rows[e.RowIndex];
            if (dgr.Cells[3].Value.ToString().Contains("忌"))
            {
                dgr.Cells[3].Style.ForeColor = Color.Red;
                dgr.Cells[4].Style.ForeColor = Color.Red;
                //dgr.DefaultCellStyle.ForeColor = Color.Red;
            }

            if (dgr.Cells[3].Value.ToString().Contains("宜"))
            {
                dgr.DefaultCellStyle.ForeColor = Color.Green;
            }
        }

        private void dgvFindResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                万年历日期1.SetMonthCalender(System.DateTime.Parse(dgvFindResult.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
                tabControl1.SelectedIndex = 1;
            }
        }
    }
}
