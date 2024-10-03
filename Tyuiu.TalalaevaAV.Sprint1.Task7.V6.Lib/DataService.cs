using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TalalaevaAV.Sprint1.Task7.V6.Lib
{
    public class DataService : ISprint1Task7V6
    {
        public double Calculate(double x, double y)
        {
            var res= Math.Round((Math.Pow((1 + (1/ (x * x))), x) - 12 * x*x * y),3);
            return res;
        }
    }
}
