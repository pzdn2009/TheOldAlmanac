using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 老黄历
{
    /// <summary>
    /// 农历时辰
    /// </summary>
    public struct LunarHour : ILunarDate
    {
        public LunarHour(int hour)
            : this()
        {
            Number = hour;

            this.LunarName = StaticTable.Earthly_Branches[HEMathHelper.HourEarthlyBranches(Number)];
        }

        public LunarHour(string strHour)
            : this()
        {
            LunarName = strHour;
        }

        public string LunarName
        {
            get;
            private set;
        }

        public int Number
        {
            get;
            private set;
        }
    }
}
