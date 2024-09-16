using Tyuiu.StoletovNA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.StoletovNA.Sprint0.Task3.V0.Test {
    public class DataServiceTest {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}