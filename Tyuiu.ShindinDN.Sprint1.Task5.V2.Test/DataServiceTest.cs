using Tyuiu.ShindinDN.Sprint1.Task5.V2.Lib;

namespace Tyuiu.ShindinDN.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double temp = 50;
            double res = ds.FahrenheitToĐelsius(temp);
            Assert.AreEqual(10, res);
        }
    }
}