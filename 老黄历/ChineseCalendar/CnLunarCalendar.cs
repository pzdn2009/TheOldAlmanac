using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 老黄历
{
    /// <summary>
    /// 中国农历的类
    /// </summary>
    public class CnLunarCalendar
    {
        public CnLunarCalendar(DateTime dt)
            : this(LunarCommon.公历转农历(dt), dt)
        {
        }

        //2015年1月11日20时
        public CnLunarCalendar(string chineseString, DateTime dt)
        {
            if (string.IsNullOrEmpty(chineseString))
            {
                throw new ArgumentNullException("chineseString");
            }

            var splits = chineseString.Split(new string[] { "/", "年", "月", "日", "时" }, StringSplitOptions.RemoveEmptyEntries);

            this.LunarYear = new LunarYear(int.Parse(splits[0]));
            splits[1] = splits[1].Replace("腊", "12").Replace("冬", "11").Replace("正", "1");
            this.LunarMonth = new LunarMonth(splits[1].StartsWith("闰") ? int.Parse(splits[1].Remove(0, 1)) : int.Parse(splits[1]));
            this.LunarDay = new LunarDay(int.Parse(splits[2]));
            this.LunarHour = new LunarHour(int.Parse(splits[3]));

            int tmpYearGan = HEMathHelper.HeavenlyStemsOfYear(this.LunarYear.Number);
            int tmpYearZhi = HEMathHelper.EarthlyBranchesOfYear(this.LunarYear.Number);
            this.YearHE = new HE(tmpYearGan, tmpYearZhi, HEType.Year);

            int tmpMonthsGan = HEMathHelper.HeavenlyStemsOfMonth(tmpYearGan, this.LunarMonth.Number);
            int tmpMonthsZhi = HEMathHelper.EarthlyBranchesOfMonth(this.LunarMonth.Number);
            this.MonthHE = new HE(tmpMonthsGan, tmpMonthsZhi, HEType.Month);

            //基数
            int baseNumber = HEMathHelper.DayHEBaseNumber(this.LunarYear.Number);
            var cal = new System.Globalization.ChineseLunisolarCalendar();
            var tmpDt = cal.ToDateTime(this.LunarYear.Number, this.LunarMonth.Number, this.LunarDay.Number, this.LunarHour.Number, 0, 0, 0);
            var tmpDt2 = new DateTime(this.LunarYear.Number, 1, 1, 0, 0, 0);

            var number = (baseNumber + (tmpDt - tmpDt2).Days + 1) % 60;
            if (number == 0) number = 60;

            this.DayHE = new HE((number % 10 == 0 ? 10 : (number % 10)), (number % 12 == 0 ? 12 : (number % 12)), HEType.Day);

            this.HourHE = new HE(
                HEMathHelper.HourHeavenlyStems(number % 10, number % 12),
                HEMathHelper.HourEarthlyBranches(this.LunarHour.Number),
                HEType.Hour);

            this.TwentyEightLunarMansions = new TwentyEightLunarMansions(this.DayHE.EarthlyBranches, dt.DayOfWeek);

            this.DateTime = dt;
        }

        public LunarYear LunarYear { get; private set; }
        public LunarMonth LunarMonth { get; private set; }
        public LunarDay LunarDay { get; private set; }
        public LunarHour LunarHour { get; private set; }

        public HE YearHE { get; private set; }
        public HE MonthHE { get; private set; }
        public HE DayHE { get; private set; }
        public HE HourHE { get; private set; }

        public DateTime DateTime { get; private set; }

        public TwentyEightLunarMansions TwentyEightLunarMansions { get; private set; }

        public string ToChineseCharacter()
        {
            return YearHE.ChineseCharacter + MonthHE.ChineseCharacter + DayHE.ChineseCharacter + HourHE.ChineseCharacter;
        }

        public string ToLunarDateString()
        {
            return LunarYear.Number + "年" + LunarMonth.Number + "月" + LunarDay.Number + "日" + LunarHour.Number + "时";
        }
    }
}

