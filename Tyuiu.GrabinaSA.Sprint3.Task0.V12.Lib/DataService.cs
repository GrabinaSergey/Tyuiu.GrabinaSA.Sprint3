using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GrabinaSA.Sprint3.Task0.V12.Lib
{
    public class DataService : ISprint3Task0V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double pr = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                pr *= (Math.Pow(value, i) + 1 / (i + 1));

            }
            return Math.Round(pr, 3);
        }
    }
}
