using Tyuiu.GrabinaSA.Sprint3.Task2.V18.Lib;
namespace Tyuiu.GrabinaSA.Sprint3.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 1;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 0.277;

            Assert.AreEqual(wait, res);
        }
    }
}