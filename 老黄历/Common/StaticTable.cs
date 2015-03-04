using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 老黄历
{
    public enum NameType
    {
        Day,
        Month,
        HeavenlyStems,
        EarthlyBranches,
        Week
    }

    public class StaticTable
    {
        //天日
        public static readonly string[] DAY_NAMES = {"*","初一","初二","初三","初四","初五",
                                                  "初六","初七","初八","初九","初十",
                                                 "十一","十二","十三","十四","十五",
                                                 "十六","十七","十八","十九","二十",
                                                 "廿一","廿二","廿三","廿四","廿五",
                                                 "廿六","廿七","廿八","廿九","三十"};
        //月份
        public static readonly string[] MONTHS_NAMES = { "*", "正", "二", "三", "四", "五", "六", "七", "八", "九", "十", "冬", "腊" };

        //天干
        public static readonly string[] Heavenly_Stems = { "*", "甲", "乙", "丙", "丁", "戊", "己", "庚", "辛", "壬", "癸" };

        //地支
        public static readonly string[] Earthly_Branches = { "*", "子", "丑", "寅", "卯", "辰", "巳", "午", "未", "申", "酉", "戌", "亥" };

        //生肖
        public static readonly string[] TwelveYears_OfAnimals = { "*", "鼠", "牛", "虎", "兔", "龙", "蛇", "马", "羊", "猴", "鸡", "狗", "猪" };

        public static readonly string[] WEEK = new string[] { "日", "一", "二", "三", "四", "五", "六"};

        //28星宿
        public static readonly string[][] TwentyEight_LunarMansions = {
                                                    new string[]{"*","四","五","六","日","一","二","三"},
                                                    new string[]{"*","角","亢","氐","房","心","尾","萁"  },
                                                    new string[]{"*","斗","牛","女","虚","危","室","壁"  },
                                                    new string[]{"*","奎","娄","胃","昂","毕","嘴","参"  },
                                                    new string[]{"*","井","鬼","柳","星","张","翼","轸"  },
                                                    new string[]{"*","木","金","土","日","月","火","水"}
                                                };

        //节气
        public static readonly string[] SolarTerm = new string[] { "小寒", "大寒", "立春", "雨水", "惊蛰", "春分", "清明", "谷雨", "立夏", "小满", "芒种", "夏至", "小暑", "大暑", "立秋", "处暑", "白露", "秋分", "寒露", "霜降", "立冬", "小雪", "大雪", "冬至" };

        public static int GetNameIndex(string name, NameType nameType)
        {
            if (nameType == NameType.Day)
            {
                return FindIndex(DAY_NAMES, name);
            }
            else if (nameType == NameType.Month)
            {
                return FindIndex(MONTHS_NAMES, name);
            }
            else if (nameType == NameType.HeavenlyStems)
            {
                return FindIndex(Heavenly_Stems, name);
            }
            else if (nameType == NameType.EarthlyBranches)
            {
                return FindIndex(Earthly_Branches, name);
            }
            else if (nameType == NameType.Week)
            {
                return FindIndex(WEEK, name);
            }

            return -1;
        }

        private static int FindIndex(string[] array, string name)
        {
            for (int ii = 0; ii < array.Length; ii++)
            {
                if (array[ii] == name) return ii;
            }

            return -1;
        }
    }
}
