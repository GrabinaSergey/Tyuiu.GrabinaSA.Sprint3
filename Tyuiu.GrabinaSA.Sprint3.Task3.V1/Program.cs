using Tyuiu.GrabinaSA.Sprint3.Task3.V1.Lib;
namespace Tyuiu.GrabinaSA.Sprint3.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Исходные данные:                                                       ");
            Console.WriteLine("*************************************************************************");
            string value = "have a nice time";
            char chr = 'a';
            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Искомый символ: " + chr);
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*Результат:                                                             *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Найдено символов: " + ds.GetCharCount(value, chr));
            Console.ReadKey();
        }
    }
}
