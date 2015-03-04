using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 老黄历
{
    public class RuleFileConfig
    {
        private static object lockObject = new object();

        public static string CONFIG_FILE = "./Rules.xml";

        /// <summary>
        /// 获取当前公司的使用次数
        /// </summary>
        /// <param name="companyCode"></param>
        /// <returns></returns>
        public static void AddRule(SingleRule ruleData)
        {
            lock (lockObject)
            {
                XElement doc = XElement.Load(CONFIG_FILE);

                var last = doc.Elements("Rule").LastOrDefault();

                var ruleElement = new XElement("Rule", new XAttribute("Name", ruleData.Name),
                    new XElement("Description", ruleData.Description),
                    new XElement("MessageFormat", ruleData.MessageFormat),
                    new XElement("ShouldAvoid", ruleData.ShouldAvoid ? "1" : "0"),
                    new XElement("Value", ruleData.SyntaxRule));

                if (last != null)
                {
                    last.AddAfterSelf(ruleElement);
                }
                else
                {
                    doc.Add(ruleElement);
                }

                doc.Save(CONFIG_FILE);
            }
        }

        public static void EidtRule(SingleRule ruleData, string oldName)
        {
            lock (lockObject)
            {
                XElement doc = XElement.Load(CONFIG_FILE);

                var ruleElement = doc.Elements("Rule").Where(zw => zw.FirstAttribute.Value == oldName).FirstOrDefault();

                if (ruleElement != null)
                {
                    var newRuleElement = new XElement("Rule", new XAttribute("Name", ruleData.Name),
                    new XElement("Description", ruleData.Description),
                    new XElement("MessageFormat", ruleData.MessageFormat),
                    new XElement("ShouldAvoid", ruleData.ShouldAvoid ? "1" : "0"),
                    new XElement("Value", ruleData.SyntaxRule));

                    ruleElement.ReplaceWith(newRuleElement);

                    doc.Save(CONFIG_FILE);
                }
            }
        }

        public static IList<SingleRule> LoadRules()
        {
            lock (lockObject)
            {
                var list = new List<SingleRule>();

                XDocument doc = XDocument.Load(CONFIG_FILE);
                var query = doc.Descendants("Rule");
                foreach (var item in query)
                {
                    var entity = new SingleRule()
                    {
                        Name = item.Attribute("Name").Value,
                        Description = item.Element("Description").Value,
                        MessageFormat = item.Element("MessageFormat").Value,
                        ShouldAvoid = item.Element("ShouldAvoid").Value == "0" ? false : true,
                        SyntaxRule = item.Element("Value").Value
                    };

                    list.Add(entity);
                }

                return list;
            }
        }
    }
}
