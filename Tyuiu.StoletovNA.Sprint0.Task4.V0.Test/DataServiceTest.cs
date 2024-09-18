using Tyuiu.StoletovNA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.StoletovNA.Sprint0.Task4.V0.Test {
    public class DataServiceTest {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [Test]
        public void CheckSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [Test]
        public void CheckMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [Test]
        public void CheckDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}