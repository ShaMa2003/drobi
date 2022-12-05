using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using drobi;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string stroka = "9/10";
            string expected = "9/10";

            FixWrongResult g = new FixWrongResult();
            string actual = g.FixWrongResultt(stroka);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string stroka = "15/10";
            string expected = "10/10";

            FixWrongResult g = new FixWrongResult();
            string actual = g.FixWrongResultt(stroka);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string stroka = "-10/10";
            string expected = "-10/10";

            FixWrongResult g = new FixWrongResult();
            string actual = g.FixWrongResultt(stroka);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string stroka = "12/-10";
            string expected = "-10/-10";

            FixWrongResult g = new FixWrongResult();
            string actual = g.FixWrongResultt(stroka);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string stroka = "";
          

            FixWrongResult g = new FixWrongResult();
            Action actual =()=> g.FixWrongResultt(stroka);
            Assert.ThrowsException<Exception>(actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            string stroka = "10/1b";
            string expected = "Error!";

            FixWrongResult g = new FixWrongResult();
            string actual = g.FixWrongResultt(stroka);
            Assert.AreEqual(expected, actual);
        }
    }
}
