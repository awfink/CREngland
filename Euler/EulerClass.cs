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

        public int CountSundays()
        {
            return (CountSundays_TheEasyWay());
        }

        // Temporary procedure to loop through all days between 1/1/1901 and 2/31/2000
        // just to find the number of sundays for testing purposes.
        public int CountSundays_TheEasyWay()
        {
            var StartDate = DateTime.Parse("1/1/1901");
            var EndDate = DateTime.Parse("12/31/2000");
            var Days = 0;

            for (var dt = StartDate; dt <= EndDate; dt = dt.AddDays(1))
            {
                if (dt.DayOfWeek.ToString() == "Sunday") { Days += 1; };
            }

            return (Days);
        }
    
    }
}
