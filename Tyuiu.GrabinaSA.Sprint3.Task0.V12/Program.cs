
using Tyuiu.GrabinaSA.Sprint3.Task0.V12.Lib;
namespace Tyuiu.GrabinaSA.Sprint3.Task0.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int t = 1;
            int start = 1;
            int stop = 13;

            Console.WriteLine($"Переменная t = {t}");
            Console.WriteLine($"Старт шага = {start}");
            Console.WriteLine($"Конец шага = {stop}");

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Произведние ряда = " + .GetMultiplySeries(t, start, stop));
            Console.ReadKey();
        }
    }
}
