using Tyuiu.TalalaevaAV.Sprint1.Task3.V2.Lib;
namespace Tyuiu.TalalaevaAV.Sprint1.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1| Выполнила: Талалаева А.В. | ИИПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Талалаева Александра Васильевна | ИИПБ-24-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            double cen;
            Console.WriteLine("Укажите цену тетради:");
            cen = Convert.ToDouble(Console.ReadLine());
            int tetr;
            Console.WriteLine("Укажите количество тетрадей:");
            tetr = Convert.ToInt32(Console.ReadLine());
            double cen1;
            Console.WriteLine("Укажите цену карандаша:");
            cen1 = Convert.ToDouble(Console.ReadLine());
            int kar;
            Console.WriteLine("Укажите количество карандашей:");
            kar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Стоимость покупки: " + ds.PurchaseAmount(cen, tetr, cen1, kar));
            Console.ReadLine();

        }
    }
}
