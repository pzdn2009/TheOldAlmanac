using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 老黄历
{
    /// <summary>
    /// 干支
    /// </summary>
    public struct HE
    {
        public HE(int heavenlyStemsOrder, int earthlyBranchesOrder, HEType hEType)
            : this()
        {
            this.HEType = hEType;

            while (heavenlyStemsOrder < 0)
            {
                heavenlyStemsOrder += 10;
            }

            while (earthlyBranchesOrder < 0)
            {
                earthlyBranchesOrder += 12;
            }

            this.HeavenlyStemsOrder = heavenlyStemsOrder;
            this.EarthlyBranchesOrder = earthlyBranchesOrder;
            this.HeavenlyStems = StaticTable.Heavenly_Stems[HeavenlyStemsOrder].ToString();
            this.EarthlyBranches = StaticTable.Earthly_Branches[EarthlyBranchesOrder].ToString();
        }

        public HE(string heavenlyStems, string earthlyBranches, HEType hEType)
            : this()
        {
            this.HEType = hEType;

            this.HeavenlyStems = heavenlyStems;
            this.EarthlyBranches = earthlyBranches;

            this.HeavenlyStemsOrder = StaticTable.GetNameIndex(heavenlyStems, NameType.HeavenlyStems);
            this.EarthlyBranchesOrder = StaticTable.GetNameIndex(earthlyBranches, NameType.EarthlyBranches);
        }

        public HE(string hE, HEType hEType = 老黄历.HEType.Day)
            : this()
        {
            this.HEType = hEType;

            this.HeavenlyStems = hE[0].ToString();
            this.EarthlyBranches = hE[1].ToString();

            this.HeavenlyStemsOrder = StaticTable.GetNameIndex(hE[0].ToString(), NameType.HeavenlyStems);
            this.EarthlyBranchesOrder = StaticTable.GetNameIndex(hE[1].ToString(), NameType.EarthlyBranches);
        }

        public HEType HEType { get; private set; }

        public int HeavenlyStemsOrder { get; private set; }
        public string HeavenlyStems { get; private set; }

        public int EarthlyBranchesOrder { get; private set; }  //生肖顺序
        public string EarthlyBranches { get; private set; }

        public int HEOrder
        {
            get
            {
                int tmp = HeavenlyStemsOrder;
                for (int ii = 0; ii < 6; ii++)
                {
                    if (tmp % 12 == EarthlyBranchesOrder)
                    {
                        return tmp;
                    }
                    tmp *= 10;
                }

                return tmp;
            }
        }

        public string 生肖名称
        {
            get
            {
                return StaticTable.TwelveYears_OfAnimals[EarthlyBranchesOrder].ToString();
            }
        }

        public string ChineseCharacter
        {
            get
            {
                return StaticTable.Heavenly_Stems[HeavenlyStemsOrder] +
                    StaticTable.Earthly_Branches[EarthlyBranchesOrder];
            }
        }
    }
}

