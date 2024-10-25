using Tyuiu.GrabinaSA.Sprint3.Task0.V12.Lib;
namespace Tyuiu.GrabinaSA.Sprint3.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 1;
            int stopValue = 13;
            int startValue = 1;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}