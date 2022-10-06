using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using testingMethodsEx;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddStu()
        {
            Calculations cal = new Calculations();

            string actual = cal.AddStudent("joe", "bloggs").ToLower();

            string expected = "student added joe bloggs".ToLower();

            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        public void TestCalNumbers()
        {
            Calculations cal = new Calculations();

            double actual = cal.CalNumbers(5.5, 6.7);

            double expected = 36.84;

            Assert.AreEqual(expected, actual);



        }
    }
}
