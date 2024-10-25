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
            int StopValue = 14;

            double res = ds.GetMultiplySeries(value, startValue, StopValue);

            double wait = 287.18;
            Assert.AreEqual(wait, res);
        }
    }
}