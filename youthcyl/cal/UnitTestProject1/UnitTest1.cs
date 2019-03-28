using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cal;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num1, num2, num3, num4, x, y, z;
            num1 = 1;
            num2 = 2;
            num3 = 3;
            num4 = 4;
            x = 1;
            y = 1;
            z = 1;
            string[] operators = { "+", "-", "*", "/" };
            Assert.AreEqual(Program.Result1(num1, num2, num3, x, y),0);
            Assert.AreEqual(Program.Result2(num1, num2, num3,num4 , x, y,z), 0);
        }
    }
}
