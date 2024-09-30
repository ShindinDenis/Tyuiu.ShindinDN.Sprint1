using Tyuiu.ShindinDN.Sprint1.Task4.V5.Lib;

namespace Tyuiu.ShindinDN.Sprint1.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 1;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(0.2, res);
        }
    }
}