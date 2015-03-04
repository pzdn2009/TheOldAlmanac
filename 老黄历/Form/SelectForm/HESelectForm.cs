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
    public partial class HESelectForm : SelectFormBase
    {
        public HESelectForm()
        {
            InitializeComponent();
        }

        private List<string> ret = new List<string>();

        public List<string> HEList { get { return ret; } }

        private void HESelectForm_Load(object sender, EventArgs e)
        {
            cmbHS.SelectedIndex = 0;
            cmbEB.SelectedIndex = 0;
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            lsbHE.Items.Add(cmbHS.Text + cmbEB.Text);
            ret.Add(cmbHS.Text + cmbEB.Text);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool HasChoose { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HasChoose = true;
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lsbHE.Items.Clear();
            ret.Clear();
        }

        public override string GetSelectValue()
        {
            return string.Join("|", HEList);
        }

        private void cmbHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            int first = cmbHS.SelectedIndex;

            cmbEB.Items.Clear();
            cmbEB.Items.Add("*");

            int number = first == 0 ? 12 : 6;

            for (int ii = 1; ii <= number; ii++)
            {
                if(number == 12)
                {
                    cmbEB.Items.Add(StaticTable.Earthly_Branches[ii]);
                }
                else
                {
                    cmbEB.Items.Add(StaticTable.Earthly_Branches[first]);
                    first += 10;
                    first %= 12;
                    if (first == 0)
                        first = 12;
                }
                
            }
        }
    }
}
