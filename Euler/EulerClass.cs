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

        //Solve Euler problem #99
        //Determine the number of Sundays between 1/1/1901 and 12/31/2000
        //Without using the DayOfWeek command.
        public int CountSundaysFDOM()
        {
            var dy=1;
            var mn=1;
            var CurrentDayOfWeek = 2;                   //Start at Tuesday (2) with a Sunday  being 0.

            for (var yr = 1900; yr <= 2000; yr++)
            {
                var DaysInYear = 365;
                var isLeapYear = false;

                isLeapYear = IsLeapYear(yr);
                if (isLeapYear) DaysInYear = 366;

            }
            return (CountSundaysFDOM_TheEasyWay());
        }

        public bool IsLeapYear(int yr)
        {
            if (yr % 4 == 0)
            {
                // Test if century
                if( yr % 100 == 0 ) {
                    if( yr % 400 == 0 ) {
                        return(true);
                    }
                }
                else {
                    return(true);
                }
            }
            return (false);
        }

        // Temporary procedure to loop through all days between 1/1/1901 and 2/31/2000
        // just to find the number of Sundays for testing purposes.
        // Function modified to exclude Sundays that are not the first day of the month.
        public int CountSundaysFDOM_TheEasyWay()
        {
            var StartDate = DateTime.Parse("1/1/1901");
            var EndDate = DateTime.Parse("12/31/2000");
            var Days = 0;

            for (var dt = StartDate; dt <= EndDate; dt = dt.AddDays(1))
            {
                if (dt.DayOfWeek.ToString() == "Sunday") 
                {
                    if (dt.Day == 1)
                    {
                        Days += 1;
                    }
                };
            }

            return (Days);
        }
    
    }
}
