using Tyuiu.TalalaevaAV.Sprint1.Task7.V6.Lib;
namespace Tyuiu.TalalaevaAV.Sprint1.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds= new DataService();
            double x = 3.0;
            double y = 3.0;
            var res =ds.Calculate(x, y);
            double wait =-322.628;
            Assert.AreEqual(wait, res);

        }
    }
}