using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 老黄历
{
    [Flags]
    public enum HEType
    {
        None = 0,
        SingleHE = 1,
        Hour = 2,
        Day = 4,
        Month = 8,
        Year = 16,
    }
}
