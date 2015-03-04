using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 老黄历
{
    /// <summary>
    /// 农历年份
    /// </summary>
    public struct LunarYear : ILunarDate
    {
        public LunarYear(int year)
            : this()
        {
            this.Number = year;

            int h = HEMathHelper.HeavenlyStemsOfYear(Number);
            int e = HEMathHelper.EarthlyBranchesOfYear(Number);

            this.LunarName = HEMathHelper.GetYearHEByOrder(HEMathHelper.GetYearOrderByHE(h, e));
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
