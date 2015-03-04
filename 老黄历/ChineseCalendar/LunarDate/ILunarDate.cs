using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 老黄历
{
    /// <summary>
    /// 农历接口
    /// </summary>
    public interface ILunarDate
    {
        /// <summary>
        /// 农历名称
        /// </summary>
        string LunarName { get; }

        /// <summary>
        /// 数值
        /// </summary>
        int Number { get; }

    }
}
