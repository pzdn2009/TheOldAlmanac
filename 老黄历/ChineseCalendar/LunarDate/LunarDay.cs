using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 老黄历
{
    /// <summary>
    /// 农历天日
    /// </summary>
    public struct LunarDay : ILunarDate
    {
        public LunarDay(int day)
            : this()
        {
            this.Number = day;
            this.LunarName = StaticTable.DAY_NAMES[this.Number];
        }

        public LunarDay(string strDay)
            : this()
        {
            this.LunarName = strDay;
            this.Number = StaticTable.GetNameIndex(strDay, NameType.Day);
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
