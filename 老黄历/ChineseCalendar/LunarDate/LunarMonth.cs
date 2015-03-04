using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 老黄历
{
    /// <summary>
    /// 农历月份
    /// </summary>
    public struct LunarMonth : ILunarDate
    {
        public LunarMonth(int month)
            : this()
        {
            this.Number = month;
            this.LunarName = StaticTable.MONTHS_NAMES[Number];
        }

        public LunarMonth(string strMonth)
            : this()
        {
            this.LunarName = strMonth;
            this.Number = StaticTable.GetNameIndex(strMonth, NameType.Month);
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
