using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerNamespace
{
    public class CountingSundays
    {
        public string GetDayOfWeek(DateTime dt)
        {
            var x = dt.DayOfWeek;
            return(x.ToString());
        }
    }
}
