using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 老黄历
{
    /// <summary>
    /// 文法规则：
    /// 表达式     ——> 表达式 "或者" 且表达式 | 且表达式
    /// 且表达式   ——> 且表达式 "而且" 元表达式 | 元表达式
    /// 元表达式   ——> 名:值 | "(" 表达式 ")"
    /// 名        ——> "年" | "月" | "日" | "时" | "年甲子" | "月甲子" | "日甲子" | "时甲子" | "四季" | "星宿"
    /// 值        ——> "正" | "二" | "三" | "四" | "五" | "六" | "七" | "八" | "九" | "十" ...
    /// </summary>
    public class ComplexRuleResolver
    {
        /// <summary>
        /// For Test
        /// </summary>
        public ComplexRuleResolver()
            : this("(日:初一|初七|初九|十四|十七|廿三|廿五)", new CnLunarCalendar(DateTime.Now))
        {

        }

        private string ruleString = string.Empty;
        private int pointer = 0;
        private string currentToken = string.Empty;
        private FieldTypeName ChooseFieldName;
        private CnLunarCalendar cnLunar;

        private List<string> resultDay = new List<string>();

        private DataForResolver dataForRule = new DataForResolver();

        public ComplexRuleResolver(string ruleString, CnLunarCalendar cnLunar)
        {
            this.ruleString = ruleString;
            this.cnLunar = cnLunar;
        }

        public string Start()
        {
            resultDay.Clear();
            Console.WriteLine(ExpressionContain());
            return string.Join(";", resultDay);
        }

        /// <summary>
        /// 是否包含制定的日期
        /// </summary>
        /// <returns></returns>
        private bool ExpressionContain()
        {
            bool result = AndExpression();
            if (result) return true;
            resultDay.Clear();

            while (Match("或者"))
            {
                var ret2 = AndExpression();
                result = result || ret2;
            }
            if (!result)
                resultDay.Clear();

            return result;
        }

        private bool AndExpression()
        {
            bool result = FactorExpress();

            while (Match("而且"))
            {
                var ret2 = FactorExpress();
                result = ret2 && result;
            }

            return result;
        }

        private bool FactorExpress()
        {
            if (Match("("))
            {
                var result = ExpressionContain();
                Match(")");
                return result;
            }
            else
            {
                return NameValue();
            }
        }

        private bool NameValue()
        {
            Name();
            Match(":");
            return Value();
        }

        //private static string[] types = new string[] { };

        private void Name()
        {
            if (Match("年"))
            {
                ChooseFieldName = FieldTypeName.年;
                return;
            }

            if (Match("月"))
            {
                ChooseFieldName = FieldTypeName.月;
                return;
            }

            if (Match("日"))
            {
                ChooseFieldName = FieldTypeName.日;
                return;
            }

            if (Match("年甲子"))
            {
                ChooseFieldName = FieldTypeName.年甲子;
                return;
            }

            if (Match("月甲子"))
            {
                ChooseFieldName = FieldTypeName.月甲子;
                return;
            }

            if (Match("日甲子"))
            {
                ChooseFieldName = FieldTypeName.日甲子;
                return;
            }

            if (Match("时甲子"))
            {
                ChooseFieldName = FieldTypeName.时甲子;
                return;
            }

            if (Match("四季"))
            {
                ChooseFieldName = FieldTypeName.四季;
                return;
            }

            if (Match("星宿"))
            {
                ChooseFieldName = FieldTypeName.星宿;
            }
        }

        private bool Value()
        {
            MatchWithRegex();
            string[] splits = InnerSplit(currentToken);

            Console.WriteLine(currentToken);

            var ret = false;
            switch (ChooseFieldName)
            {
                case FieldTypeName.年:   //?
                    for (int ii = 0; ii < splits.Length; ii++)
                    {
                        dataForRule.LunarYears.Add(new LunarYear(int.Parse(splits[ii])));
                    }
                    ret = dataForRule.LunarYears.Contains(cnLunar.LunarYear);
                    if (ret)
                    {
                        resultDay.Add(cnLunar.LunarYear.LunarName);
                    }
                    return ret;
                case FieldTypeName.月:
                    for (int ii = 0; ii < splits.Length; ii++)
                    {
                        dataForRule.LunarMonths.Add(new LunarMonth(splits[ii]));
                    }

                    ret = dataForRule.LunarMonths.Contains(cnLunar.LunarMonth);
                    if (ret)
                    {
                        resultDay.Add(cnLunar.LunarMonth.LunarName);
                    }
                    return ret;
                case FieldTypeName.日:
                    for (int ii = 0; ii < splits.Length; ii++)
                    {
                        dataForRule.LunarDays.Add(new LunarDay(splits[ii]));
                    }
                    ret = dataForRule.LunarDays.Contains(cnLunar.LunarDay);
                    if (ret)
                    {
                        resultDay.Add(cnLunar.LunarDay.LunarName);
                    }
                    return ret;
                case FieldTypeName.时:
                    for (int ii = 0; ii < splits.Length; ii++)
                    {
                        dataForRule.LunarHours.Add(new LunarHour(splits[ii]));
                    }
                    ret = dataForRule.LunarHours.Contains(cnLunar.LunarHour);
                    if (ret)
                    {
                        resultDay.Add(cnLunar.LunarHour.LunarName);
                    }
                    return ret;
                case FieldTypeName.年甲子:
                    for (int ii = 0; ii < splits.Length; ii++)
                    {
                        dataForRule.YearHEs.Add(new HE(splits[ii], HEType.Year));
                    }
                    ret = dataForRule.YearHEs.Contains(cnLunar.YearHE);
                    if (ret)
                    {
                        resultDay.Add(cnLunar.YearHE.ChineseCharacter);
                    }
                    return ret;
                case FieldTypeName.月甲子:
                    for (int ii = 0; ii < splits.Length; ii++)
                    {
                        dataForRule.MonthHEs.Add(new HE(splits[ii], HEType.Month));
                    }
                    ret = dataForRule.MonthHEs.Contains(cnLunar.MonthHE);
                    if (ret)
                    {
                        resultDay.Add(cnLunar.MonthHE.ChineseCharacter);
                    }
                    return ret;
                case FieldTypeName.日甲子:
                    for (int ii = 0; ii < splits.Length; ii++)
                    {
                        dataForRule.DayHEs.Add(new HE(splits[ii], HEType.Day));
                    }
                    ret = dataForRule.DayHEs.Contains(cnLunar.DayHE);
                    if (ret)
                    {
                        resultDay.Add(cnLunar.DayHE.ChineseCharacter);
                    }
                    return ret;
                case FieldTypeName.时甲子:
                    for (int ii = 0; ii < splits.Length; ii++)
                    {
                        dataForRule.HourHEs.Add(new HE(splits[ii], HEType.Hour));
                    }
                    ret = dataForRule.HourHEs.Contains(cnLunar.HourHE);
                    if (ret)
                    {
                        resultDay.Add(cnLunar.HourHE.ChineseCharacter);
                    }
                    return ret;
                case FieldTypeName.四季:
                    {
                        return false;
                    }
                //ret = resultDay.Add(cnLunar.LunarYear.LunarString);
                //if (ret)
                //{
                //    resultDay.Add(cnLunar.LunarYear.LunarString);
                //}
                //return ret;
                case FieldTypeName.星宿:
                    for (int ii = 0; ii < splits.Length; ii++)
                    {
                        dataForRule.TwentyEightLunarMansions.Add(new TwentyEightLunarMansions(splits[ii]));
                    }
                    ret = dataForRule.TwentyEightLunarMansions.Contains(cnLunar.TwentyEightLunarMansions);
                    if (ret)
                    {
                        resultDay.Add(cnLunar.TwentyEightLunarMansions.ToString());
                    }
                    return ret;
                default:
                    throw new Exception();
            }
        }

        private string[] InnerSplit(string str)
        {
            return str.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
        }

        private bool Match(string strValue)
        {
            currentToken = GetToken();
            if (currentToken == strValue)
            {
                pointer += currentToken.Length;
                return true;
            }
            return false;
        }

        private static char[] spliters = new char[] { '(', ')', ':', '|' };

        private string GetToken()
        {
            var result = string.Empty;
            int tmpIndex = pointer;

            bool isFirst = true;
            while (true)
            {
                if (tmpIndex > ruleString.Length - 1)
                {
                    break;
                }
                if (spliters.Contains(ruleString[tmpIndex]))
                {
                    if (isFirst)
                    {
                        result += ruleString[tmpIndex];
                    }
                    break;
                }

                result += ruleString[tmpIndex];

                tmpIndex++;

                isFirst = false;
            }
            return result;
        }

        private bool MatchWithRegex()
        {
            string pattern = @"[^\)]*";
            Regex reg = new Regex(pattern);
            var ret = reg.Match(ruleString, pointer);
            if (ret.Success)
            {
                if (ret.Index - pointer == 0)
                {
                    pointer += ret.Length;
                    currentToken = ret.Value;
                    return true;
                }
            }

            currentToken = "";
            return false;
        }
    }
}
