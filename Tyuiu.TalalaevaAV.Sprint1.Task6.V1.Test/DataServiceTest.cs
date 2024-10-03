using System.Globalization;
using Tyuiu.TalalaevaAV.Sprint1.Task6.V1.Lib;
namespace Tyuiu.TalalaevaAV.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string x = "A";
            string res = ds.SymbolCode(x);
            string wait = "65";
            Assert.AreEqual(wait, res);


        }
    }
}