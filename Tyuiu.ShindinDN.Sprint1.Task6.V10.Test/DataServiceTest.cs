using Tyuiu.ShindinDN.Sprint1.Task6.V10.Lib;

namespace Tyuiu.ShindinDN.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string words = "������ �� ��� �����";
            string res = ds.DeleteMiddleLetter(words);
            Assert.AreEqual("������ � �� ����", res);
        }
    }
}