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
            var SundaysOnFirstDayOfTheMonth = 0;
            var CurrentDayOfWeek = 1;                   //Start at Monday (1) with a Sunday  being 0.

            var tmp = 0;

            for (var yr = 1900; yr <= 2000; yr++)
            {
                var DaysInYear = 365;
                var isLeapYear = false;


                isLeapYear = IsLeapYear(yr);
                if (isLeapYear) DaysInYear = 366;

                //Every year starts on Month 1 and Day 1
                dy = 1;
                mn = 1;

                //Loop through days setting values
                for (var i = 1; i <= DaysInYear; i++)
                {
                    if (dy == 1 && CurrentDayOfWeek == 0 && yr > 1900)
                    {
                        // This is a Sunday on the first day of the month (excluding the year 1900)
                        SundaysOnFirstDayOfTheMonth += 1;
                    }

                    //Increment the day/weekday and adjust day/month if necessary.
                    dy += 1;
                    CurrentDayOfWeek += 1;
                    if (CurrentDayOfWeek > 6) CurrentDayOfWeek = 0;

                    // Reset Dy/Month using LeapYear / Month rules
                    switch (mn)
                    {
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            if (dy > 30)
                            {
                                mn += 1;
                                dy = 1;
                            }
                            break;
                        case 2:
                            if ((!isLeapYear && dy > 28) || (isLeapYear && dy > 29))
                            {
                                mn += 1;
                                dy = 1;
                            }
                            break;
                        default:
                            // This is the 31 day month.
                            if (dy > 31)
                            {
                                mn += 1;
                                dy = 1;
                            }
                            break;
                    }
                }
            }
            return (SundaysOnFirstDayOfTheMonth);
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
