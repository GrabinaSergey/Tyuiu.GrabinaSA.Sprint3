using Tyuiu.GrabinaSA.Sprint3.Task3.V1.Lib;
namespace Tyuiu.GrabinaSA.Sprint3.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "have a nice time";
            char chr = 'a';
            int res = ds.GetCharCount(str, chr);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}