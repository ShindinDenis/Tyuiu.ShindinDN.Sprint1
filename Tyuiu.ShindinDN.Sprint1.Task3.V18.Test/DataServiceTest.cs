using Tyuiu.ShindinDN.Sprint1.Task3.V18.Lib;

namespace Tyuiu.ShindinDN.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 5;
            double b = 7;
            double c = 5;
            double res = ds.HowManySquares(a, b, c);
            Assert.AreEqual(1.4, res);
        }
    }
}