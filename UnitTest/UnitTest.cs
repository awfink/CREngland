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
            csObj.GetDayOfWeek(DateTime.Parse("1/1/1900"));
        }
    }
}
