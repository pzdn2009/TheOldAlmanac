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
    public partial class SelectFormBase : Form
    {
        public SelectFormBase()
        {
            //InitializeComponent();
        }

        public virtual string GetSelectValue()
        {
            return string.Empty;
        }
    }
}
