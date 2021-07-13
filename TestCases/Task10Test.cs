using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks;

namespace TestCases
{
    [TestClass]
    public class Task10Test
    {
        [TestMethod]
        public void Test1()
        {
            var result = Task10.getLuckDates("02-08-2025", "04-09-2025");
            if (result != 5)
                Assert.Fail();
        }

        [TestMethod]
        public void Test2()
        {
            var result = Task10.getLuckDates("01-01-2021", "31-12-2021");
            if (result != 52)
                Assert.Fail();
        }

        [TestMethod]
        public void Test3()
        {
            var result = Task10.getLuckDates("11-02-1979", "15-11-2020");
            if (result != 5588)
                Assert.Fail();
        }
    }
}
