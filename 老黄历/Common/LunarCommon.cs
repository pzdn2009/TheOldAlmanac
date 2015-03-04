using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 老黄历
{
    public class LunarCommon
    {
        #region 公共API
        public static string 公历转农历(DateTime dt)
        {
            var ret = SolarToChineseLunisolarDate(dt);
            return ret;
        }

        private static string SolarToChineseLunisolarDate(DateTime solarDateTime)
        {
            //微软的ChineseLunisolarCalendar 方法支持时间范围是[1901－2-19,2101-1-28]
            var cal = new ChineseLunisolarCalendar();

            //农历年份
            int year = cal.GetYear(solarDateTime);

            //有闰月时该值可能为13，即leapMonth <= month ? month - 1 : month表示实际农历月份
            int month = cal.GetMonth(solarDateTime);

            //农历天数
            int day = cal.GetDayOfMonth(solarDateTime);

            //此年份闰几月，闰n月则返回n+1,如闰4月返回值为5；没有闰月返回0
            int leapMonth = cal.GetLeapMonth(year);

            String leapMonthStr = leapMonth > 0 ? "(闰" + (leapMonth - 1).ToString() + "月)" : "";//闰月份

            //把闰月计算进去之后真正的农历月份
            int monthtrue = leapMonth > 0 && leapMonth <= month ? month - 1 : month;

            String month2 = String.Format("{0}{1}", month == leapMonth ? "闰" : ""
                                , StaticTable.MONTHS_NAMES[monthtrue]
                                );
            String day2 = string.Format("{0}{1}", "初十廿三"[day == 10 ? 0 : day / 10]
                        , "十一二三四五六七八九"[day % 10]
                        );
            String date = year + "年" +
                         month + "月" + day + "日" + solarDateTime.Hour + "时";
            return date;
        }

        public static DateTime 农历转公历(CnLunarCalendar dt)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region 计算28星宿

        private static string[] Shenzichen = new string[] { "虚日鼠", "毕月乌", "翼火蛇", "箕水豹", "奎木狼", "鬼金羊", "氐土貉" };
        private static string[] Siyouchou = new string[] { "房日兔", "危月燕", "觜火猴", "轸水蚓", "斗木獬", "娄金狗", "柳土獐" };
        private static string[] Yinwuxu = new string[] { "星日马", "心月狐", "室火猪", "参水猿", "角木蛟", "牛金牛", "胃土雉" };
        private static string[] Haimaowei = new string[] { "昴日鸡", "张月鹿", "尾火虎", "壁水狳", "井木犴", "亢金龙", "女土蝠" };
        public static string GetTwentyEightLunarMansionsName(string dayEarthlyBranches, DayOfWeek dayOfWeek)
        {
            if ("申子辰".Contains(dayEarthlyBranches))
            {
                return Shenzichen[(int)dayOfWeek];
            }
            else if ("巳酉丑".Contains(dayEarthlyBranches))
            {
                return Siyouchou[(int)dayOfWeek];
            }
            else if ("寅午戌".Contains(dayEarthlyBranches))
            {
                return Yinwuxu[(int)dayOfWeek];
            }
            else if ("亥卯未".Contains(dayEarthlyBranches))
            {
                return Haimaowei[(int)dayOfWeek];
            }
            throw new Exception("找不到了！");
        }

        #endregion

        #region 计算24节气

        private static int[] sTermInfo = new int[] { 0, 21208, 42467, 63836, 85337, 107014, 128867, 150921, 173149, 195551, 218072, 240693, 263343, 285989, 308563, 331033, 353350, 375494, 397447, 419210, 440795, 462224, 483532, 504758 };

        public static string ChineseTwentyFourDay(DateTime _date)
        {
            DateTime baseDateAndTime = new DateTime(1900, 1, 6, 2, 5, 0); //#1/6/1900 2:05:00 AM#
            DateTime newDate;
            double num;
            int y;
            string tempStr = "";

            y = _date.Year;

            for (int i = 1; i <= 24; i++)
            {
                num = 525948.76 * (y - 1900) + sTermInfo[i - 1];

                newDate = baseDateAndTime.AddMinutes(num);//按分钟计算
                if (newDate.DayOfYear == _date.DayOfYear)
                {
                    tempStr = StaticTable.SolarTerm[i - 1];
                    break;
                }
            }
            return tempStr;
        }

        //当前日期前一个最近节气
        public static string ChineseTwentyFourPrevDay(DateTime _date)
        {
            DateTime baseDateAndTime = new DateTime(1900, 1, 6, 2, 5, 0); //#1/6/1900 2:05:00 AM#
            DateTime newDate;
            double num;
            int y;
            string tempStr = "";

            y = _date.Year;

            for (int i = 24; i >= 1; i--)
            {
                num = 525948.76 * (y - 1900) + sTermInfo[i - 1];

                newDate = baseDateAndTime.AddMinutes(num);//按分钟计算

                if (newDate.DayOfYear < _date.DayOfYear)
                {
                    tempStr = string.Format("{0}[{1}]", StaticTable.SolarTerm[i - 1], newDate.ToString("yyyy/MM/dd HH:mm:ss"));
                    break;
                }
            }

            return tempStr;
        }

        public void Test()
        {
            DateTime dt = new DateTime(2015, 3, 6, 5, 55, 0);
            ChineseTwentyFourPrevDay(dt);
        }

        //当前日期后一个最近节气
        public static string ChineseTwentyFourNextDay(DateTime _date)
        {
            DateTime baseDateAndTime = new DateTime(1900, 1, 6, 2, 5, 0); //#1/6/1900 2:05:00 AM#
            DateTime newDate;
            double num;
            int y;
            string tempStr = "";

            y = _date.Year;

            for (int i = 1; i <= 24; i++)
            {
                num = 525948.76 * (y - 1900) + sTermInfo[i - 1];

                newDate = baseDateAndTime.AddMinutes(num);//按分钟计算

                if (newDate.DayOfYear > _date.DayOfYear)
                {
                    tempStr = string.Format("{0}[{1}]", StaticTable.SolarTerm[i - 1], newDate.ToString("yyyy-MM-dd"));
                    break;
                }
            }
            return tempStr;
        }

        #endregion
    }
}
