using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 老黄历
{
    public partial class PermanentCalendar : UserControl
    {
        public PermanentCalendar()
        {
            InitializeComponent();
            this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }

        public void SetMonthCalender(DateTime dt)
        {
            this.monthCalendar1.SelectionStart = dt;
            Set(dt);
        }

        private void Set(DateTime dt)
        {
            //农历日期
            var str = LunarCommon.公历转农历(dt);
            labYearMonthDay.Text = "农历:" + str;

            //判断月大月小
            var cal = new System.Globalization.ChineseLunisolarCalendar();
            var cn = new CnLunarCalendar(str, dt);
            var big = cal.GetDaysInMonth(cn.LunarYear.Number, cn.LunarMonth.Number) == 30;

            labMonthBigSmall.Text = "月" + (big ? "大" : "小");

            //星期
            labDayOfWeek.Text = "星期" + StaticTable.WEEK[(int)cn.DateTime.DayOfWeek];

            //今日八字
            labBazi.Text = cn.ToChineseCharacter();

            //28宿
            lab28.Text = cn.TwentyEightLunarMansions.ToString();

            //24节气
            lab24Prev.Text = "前：" + LunarCommon.ChineseTwentyFourPrevDay(cn.DateTime);
            lab24Next.Text = "后：" + LunarCommon.ChineseTwentyFourNextDay(cn.DateTime);
            var current24 = LunarCommon.ChineseTwentyFourDay(cn.DateTime);
            lab24Current.Text = "今：" + current24;
            lab24Current.Visible = current24 != "";
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            var dt = e.Start;
            var tmp = new DateTime(dt.Year, dt.Month, dt.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            Set(tmp);
        }
    }
}
