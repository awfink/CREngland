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
        public void Test_Sundays_Between_01_Jan_1901_AND_12_31_2000()
        {
            var csObj = new CountingSundays();
            var cnt = csObj.CountSundays();
            Assert.AreEqual(65, cnt);
        }
    }
}
