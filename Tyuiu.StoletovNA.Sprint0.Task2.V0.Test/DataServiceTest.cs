using System.Security.Cryptography.X509Certificates;
using System;
using Tyuiu.StoletovNA.Sprint0.Task2.V0.Lib;


namespace Tyuiu.StoletovNA.Sprint0.Task2.V0.Test {
    public class DataServiceTest {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void CheckMessageValid()
        {
        
            var name = "Никита";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Никита", res);
        
        }
    }
}