using Tyuiu.ShindinDN.Sprint1.Task1.V9.Lib;

namespace Tyuiu.ShindinDN.Sprint1.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;

            Assert.AreEqual(1.25, ds.Calculate(x, y));
        }
    }
}