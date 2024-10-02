using Tyuiu.TalalaevaAV.Sprint1.Task4.V29.Lib;
namespace Tyuiu.TalalaevaAV.Sprint1.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds= new DataService();
            double x = 4.0;
            double y = 3.0;
            double wait = 0.019;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}