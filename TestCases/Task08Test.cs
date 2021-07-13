using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tasks;

namespace TestCases
{
    [TestClass]
    public class Task08Test
    {
        [TestMethod]
        public void Test1()
        {
            var result = Task08.getFirstCharString(new List<string>() { "André", "João", "Ana", "Giromildo", "RAUL SEIXAS" });
            if (result != "AJAGR")
                Assert.Fail();
        }
        [TestMethod]
        public void Test2()
        {
            var result = Task08.getFirstCharString(new List<string>() { "André", "João", "ana", "", "RAUL SEIXAS" });
            if (result != "AJaR")
                Assert.Fail();
        }

        [TestMethod]
        public void Test3()
        {
            var result = Task08.getFirstCharString(new List<string>() { "André", null, "Ana", "Giro Mildo", "RAUL SEIXAS" });
            if (result != "AAGR")
                Assert.Fail();
        }
    }
}
