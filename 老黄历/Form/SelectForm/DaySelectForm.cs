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
    public partial class DaySelectForm : SelectFormBase
    {
        public DaySelectForm()
        {
            InitializeComponent();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            List<string> ret = new List<string>();
            
            foreach (var item in checkedListBox1.CheckedItems)
            {
                ret.Add(item.ToString());
            }

            foreach (var item in checkedListBox2.CheckedItems)
            {
                ret.Add(item.ToString());
            }

            this.Days = ret;

            this.Close();
        }

        public List<string> Days { get; set; }

        public override string GetSelectValue()
        {
            return string.Join("|", Days);
        }
    }
}
