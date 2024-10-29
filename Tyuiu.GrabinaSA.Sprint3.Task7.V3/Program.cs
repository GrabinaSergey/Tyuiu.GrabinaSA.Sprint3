using Tyuiu.GrabinaSA.Sprint3.Task7.V3.Lib;
namespace Tyuiu.GrabinaSA.Sprint3.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*           3x - 1.5                                                      *");
            Console.WriteLine("* F(x) = ---------------  + 2                                             *");
            Console.WriteLine("*        sin(x) - 3 + x                                                   *");
            Console.WriteLine("*                                                                         *");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine(" Начало шага = " + startValue);
            Console.WriteLine(" Конец шага  = " + stopValue);
            Console.WriteLine("*                                                                         *");

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |    f(x)  |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1, 6:f2}  |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
