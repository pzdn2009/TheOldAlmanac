using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 老黄历
{
    /// <summary>
    /// 28星宿
    /// </summary>
    public struct TwentyEightLunarMansions
    {
        public TwentyEightLunarMansions(string name)
            : this()
        {
            this.Name = name;
            var arrays = StaticTable.TwentyEight_LunarMansions;
            for (int ii = 1; ii < arrays.Length; ii++)
            {
                var arr = arrays[ii];
                var index = arr.ToList().IndexOf(name);
                if (index != -1)
                {
                    this.DayOfWeek = (System.DayOfWeek)StaticTable.GetNameIndex(arrays[0][index], NameType.Week);
                    this.Property = arrays[5][index];
                    break;
                }
            }
        }

        public TwentyEightLunarMansions(string dayEarthlyBranches, DayOfWeek dayOfWeek)
            : this()
        {
            this.DayOfWeek = dayOfWeek;
            var tmp = LunarCommon.GetTwentyEightLunarMansionsName(dayEarthlyBranches, dayOfWeek);

            this.Name = tmp[0].ToString();
            this.Property = tmp[1].ToString();
            //this.AnimalName = tmp[2].ToString();
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 属性
        /// </summary>
        public string Property { get; private set; }

        ///// <summary>
        ///// 动物名称
        ///// </summary>
        //public string AnimalName { get; private set; }

        public DayOfWeek DayOfWeek { get; set; }

        public override string ToString()
        {
            return Name + Property;//+ AnimalName;
        }
    }
}
