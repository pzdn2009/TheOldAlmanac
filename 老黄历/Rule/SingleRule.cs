using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 老黄历
{
    /// <summary>
    /// 规则数据
    /// </summary>
    public class SingleRule
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string MessageFormat { get; set; }

        /// <summary>
        /// 宜忌
        /// </summary>
        public bool ShouldAvoid { get; set; }

        /// <summary>
        /// 文法规则
        /// </summary>
        public string SyntaxRule { get; set; }
    }
}
