using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks;

namespace TestCases
{
    [TestClass]
    public class Task05Test
    {
        [TestMethod]
        public void Test1()
        {
            var result = Task05.GetEvenOrOdd(1);

            if (result != "impar")
                Assert.Fail();
        }

        [TestMethod]
        public void Test2()
        {
            var result = Task05.GetEvenOrOdd(2);

            if (result != "par")
                Assert.Fail();
        }

        [TestMethod]
        public void Test3()
        {
            var result = Task05.GetEvenOrOdd(153423);

            if (result != "impar")
                Assert.Fail();
        }

        [TestMethod]
        public void Test4()
        {
            var result = Task05.GetEvenOrOdd(1234);

            if (result != "par")
                Assert.Fail();
        }

        [TestMethod]
        public void Test5()
        {
            var result = Task05.GetEvenOrOdd(1020);

            if (result != "par")
                Assert.Fail();
        }

        [TestMethod]
        public void Test6()
        {
            var result = Task05.GetEvenOrOdd(120);

            if (result != "par")
                Assert.Fail();
        }

        [TestMethod]
        public void Test7()
        {
            var result = Task05.GetEvenOrOdd(0);

            if (result != "zero")
                Assert.Fail();
        }
    }
}
