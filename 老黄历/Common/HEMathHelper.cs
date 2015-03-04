using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 老黄历
{
    /// <summary>
    /// Heavenly Stems and Earthly Branches
    /// </summary>
    public class HEMathHelper
    {
        #region 年的干支计算方法

        /// <summary>
        /// 天干计算：年号的个位数-3即为天干序号
        /// </summary>
        /// <param name="year">农历年份</param>
        /// <returns></returns>
        public static int HeavenlyStemsOfYear(int year)
        {
            var index = (year % 10 - 3) % 10;
            if (index <= 0) index += 10;
            return index;
        }

        /// <summary>
        /// 地支计算：年号-3除以12地支数的余数则为地支序号数
        /// </summary>
        /// <param name="year">农历年份</param>
        /// <returns></returns>
        public static int EarthlyBranchesOfYear(int year)
        {
            var index = (year - 3) % 12;
            if (index <= 0) index += 12;
            return index;
        }

        public static Tuple<int, int> YearHE(int year)
        {
            return new Tuple<int, int>(HeavenlyStemsOfYear(year), EarthlyBranchesOfYear(year));
        }

        public static int GetYearOrderByHE(int h, int e)
        {
            int tmp = h;
            for (int ii = 0; ii < 6; ii++)
            {
                if (tmp % 12 == e) return tmp;

                tmp += 10;
            }
            throw new Exception("计算不到了!");
        }

        public static string GetYearHEByOrder(int heOrder)
        {
            int h = heOrder % 10;
            while (h <= 0)
            {
                h += 10;
            }

            int e = heOrder % 12;
            while (e <= 0)
            {
                e += 12;
            }

            return StaticTable.Heavenly_Stems[h] + StaticTable.Earthly_Branches[e];
        }

        #endregion

        #region 月份的干支计算方法

        /// <summary>
        /// 
        /// </summary>
        /// <param name="yearH">年干的序号</param>
        /// <param name="month">月份数</param>
        /// <returns></returns>
        public static int HeavenlyStemsOfMonth(int yearH, int month)
        {
            var index = (yearH * 2 + month) % 10;
            if (index <= 0) index += 10;
            return index;
        }

        /// <summary>
        /// 月份数
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        public static int EarthlyBranchesOfMonth(int month)
        {
            var index = (month + 2) % 12;
            if (index <= 0) index += 12;
            return index;
        }

        #endregion

        #region 计算日的干支基数（以公历为准）

        /// <summary>
        /// 1900----1999年日干支基数=（年尾二位数+3）×5+55+（年尾二位数-1）/4
        /// 2000----2099年日干支基数=（年尾二位数+7）×5+15+（年尾二位数+19）/4（只用商数，余数不用，数过60就去掉60）。
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static int DayHEBaseNumber(int year)
        {
            int baseNum = 0;
            int lastTwo = year % 100;

            if (year >= 1900 && year <= 1999)
            {
                baseNum = (lastTwo + 3) * 5 + 55 + (lastTwo - 1) / 4;
            }
            else if (year >= 2000 && year <= 2099)
            {
                baseNum = (lastTwo + 7) * 5 + 15 + (lastTwo + 19) / 4;
            }

            baseNum = baseNum % 60;
            if (baseNum == 0)
                baseNum += 60;
            return baseNum;
        }

        #endregion

        #region 计算时辰的干支

        //时干公式=日干序数×2+日支序数-2
        public static int HourHeavenlyStems(int dayTiangan, int dayDizhi)
        {
            var tmp = (dayTiangan * 2 + dayDizhi - 2) % 10;
            if (tmp == 0) tmp = 10;
            return tmp;
        }

        public static int HourEarthlyBranches(int hour)
        {
            hour %= 24;
            int tmp = hour;
            if (hour % 2 == 0)
                tmp = hour + 1;
            return (tmp + 1) / 2;
        }

        #endregion

    }
}
