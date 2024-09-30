using Tyuiu.ShindinDN.Sprint1.Task7.V24.Lib;

namespace Tyuiu.ShindinDN.Sprint1.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 2;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(0.502, res);
        }
    }
}