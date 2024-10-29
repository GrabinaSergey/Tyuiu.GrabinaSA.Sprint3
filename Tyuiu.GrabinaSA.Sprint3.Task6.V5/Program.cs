using Tyuiu.GrabinaSA.Sprint3.Task6.V5.Lib;
namespace Tyuiu.GrabinaSA.Sprint3.Task6.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int startValue = 15;
            int stopValue = 22;

            Console.WriteLine("* Начало отрезка = " + startValue);
            Console.WriteLine("* Конец отрезка = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество делителей = " + ds.GetSumTheDivisors(startValue, stopValue));

            Console.ReadLine();
        }
    }
}
