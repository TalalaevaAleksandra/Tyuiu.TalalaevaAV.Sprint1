using Tyuiu.TalalaevaAV.Sprint1.Task5.V4.Lib;
namespace Tyuiu.TalalaevaAV.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds= new DataService();
            int x = 13257;
            double res = ds.SecondsToHours(x);
            int result = Convert.ToInt32(res);
            int wait = 3;
            Assert.AreEqual(result, wait);
        }
    }
}