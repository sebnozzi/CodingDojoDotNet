using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeKata;

namespace CodeKataTests
{
    [TestClass]
    public class ProgramTests
    {
        private Program program;

        [TestInitialize]
        public void Setup()
        {
            this.program = new Program();
        }

        [TestMethod]
        public void TestSum()
        {
            Assert.AreEqual(3, program.sum(1, 2));
        }
    }
}
