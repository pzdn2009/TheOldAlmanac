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
    public partial class TwentyEightMansionsSelectForm : SelectFormBase
    {
        public TwentyEightMansionsSelectForm()
        {
            InitializeComponent();
        }

        private List<string> ret;

        private void btnSure_Click(object sender, EventArgs e)
        {
            ret = new List<string>();

            foreach (var item in checkedListBox1.CheckedItems)
            {
                ret.Add(item.ToString());
            }

            foreach (var item in checkedListBox2.CheckedItems)
            {
                ret.Add(item.ToString());
            }

            foreach (var item in checkedListBox3.CheckedItems)
            {
                ret.Add(item.ToString());
            }

            foreach (var item in checkedListBox4.CheckedItems)
            {
                ret.Add(item.ToString());
            }

            this.Close();
        }

        public override string GetSelectValue()
        {
            if (ret == null) return string.Empty;

            return string.Join("|", ret);
        }
    }
}
