using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary;

namespace UnitTestProjectMyMath
{
    [TestClass]
    public class MyUnitTestClass
    {
        [TestMethod]
        public void Test_AdditionTwoNumbers()
        {
            MyMath myMath = new MyMath();
            int result = myMath.AdditionTwoNumbers(2, 2);
            if (result != 4)
                throw new ArgumentOutOfRangeException("result", result, "Неправильная работа метода AdditionTwoNumbers");
        }
        [TestMethod]
        public void Test_GetLengthString()
        {
            MyMath myMath = new MyMath();
            string testString = "test";
            int size = myMath.GetLengthString(testString);
            if (size != 4)
                throw new ArgumentOutOfRangeException("testString", testString, "Неправильная работа метода GetLengthString");
        }
        [TestMethod]
        public void Test_GetLengthStringNull()
        {
            MyMath myMath = new MyMath();
            string testString = null;

            int size = myMath.GetLengthString(testString);
            if (size != 0)
                throw new ArgumentOutOfRangeException("testString", testString, "Неправильная работа метода GetLengthString");
        }

    }
}
