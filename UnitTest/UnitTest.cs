using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EulerNamespace;

namespace UnitTest
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void Test_Jan1_1900_is_Monday()
        {
            var csObj = new CountingSundays();
            var dow = csObj.GetDayOfWeek(DateTime.Parse("1/1/1900"));
            Assert.AreEqual("Monday", dow);
        }

        [TestMethod]
        public void Test_LeapYear1900()
        {
            var csObj = new CountingSundays();
            Assert.AreEqual(false, csObj.IsLeapYear(1900));
        }

        [TestMethod]
        public void Test_LeapYear1904()
        {
            var csObj = new CountingSundays();
            Assert.AreEqual(true, csObj.IsLeapYear(1904));
        }

        [TestMethod]
        public void Test_AllLeapYearsBetween1900And2000()
        {
            var csObj = new CountingSundays();
            var LeapYearCount = 0;
            for (var i = 1900; i <= 2000; i++)
            {
                if (csObj.IsLeapYear(i)) LeapYearCount += 1;
            }
            Assert.AreEqual(25, LeapYearCount);
        }

        [TestMethod]
        public void Test_Sundays_On_The_First_Day_Of_The_Month_Between_01_Jan_1901_AND_12_31_2000()
        {
            var csObj = new CountingSundays();
            var cnt = csObj.CountSundaysFDOM();
            Assert.AreEqual(171, cnt);
        }

    }
}
