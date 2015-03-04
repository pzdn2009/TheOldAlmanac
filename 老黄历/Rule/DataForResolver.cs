using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 老黄历
{
    /// <summary>
    /// 为解析器存放数据
    /// </summary>
    public class DataForResolver
    {
        public DataForResolver()
        {
            this.LunarYears = new List<LunarYear>();
            this.LunarMonths = new List<LunarMonth>();
            this.LunarDays = new List<LunarDay>();
            this.LunarHours = new List<LunarHour>();

            this.YearHEs = new List<HE>();
            this.MonthHEs = new List<HE>();
            this.DayHEs = new List<HE>();
            this.HourHEs = new List<HE>();

            this.TwentyEightLunarMansions = new List<TwentyEightLunarMansions>();
        }

        public List<LunarYear> LunarYears { get; private set; }
        public List<LunarMonth> LunarMonths { get; private set; }
        public List<LunarDay> LunarDays { get; private set; }
        public List<LunarHour> LunarHours { get; private set; }

        public List<HE> YearHEs { get; private set; }
        public List<HE> MonthHEs { get; private set; }
        public List<HE> DayHEs { get; private set; }
        public List<HE> HourHEs { get; private set; }

        public List<TwentyEightLunarMansions> TwentyEightLunarMansions { get; private set; }
    }
}
