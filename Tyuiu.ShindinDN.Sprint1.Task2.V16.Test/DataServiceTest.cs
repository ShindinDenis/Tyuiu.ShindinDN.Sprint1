using Tyuiu.ShindinDN.Sprint1.Task2.V16.Lib;

namespace Tyuiu.ShindinDN.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 5;
            var res = ds.CalculatePerimetrCircle(value);
            Assert.AreEqual(31.416, res);
        }
    }
}