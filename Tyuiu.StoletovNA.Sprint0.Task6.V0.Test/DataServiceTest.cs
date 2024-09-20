using Tyuiu.StoletovNA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.StoletovNA.Sprint0.Task6.V0.Test {
    public class DataServiceTest
        {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] {1, 2, 3, 4, 5};
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        [Test]
        public void CheckSubtractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(numbers);
            Assert.AreEqual(-15, res);
        }
        [Test]
        public void CheckMultiplicationArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}