﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 老黄历
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }
    }
}
