using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 老黄历
{
    public class Checker
    {
        private DataForResolver myRule;

        private SingleRule ruleData;

        public Checker(SingleRule ruleData)
        {
            this.ruleData = ruleData;
            //var bl = new AllRuleResolver(this.ruleData.Value, new CnLunisolar(DateTime.Now)).ExpressionContain();
        }

        public void Check(CnLunarCalendar cnLunisolar)
        {
            bool con = myRule.DayHEs.Contains(cnLunisolar.DayHE);
            if (con)
            {
                string.Format(ruleData.MessageFormat, cnLunisolar.DayHE);
            }

            con = myRule.LunarDays.Contains(cnLunisolar.LunarDay);
            if (con)
            {
                string.Format(ruleData.MessageFormat, cnLunisolar.LunarDay);
            }
        }
    }
}
