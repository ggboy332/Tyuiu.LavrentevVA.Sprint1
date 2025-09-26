using Tyuiu.LavrentevVA.Sprint1.Task5.V4.Lib;

namespace Tyuiu.LavrentevVA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 15000;
            double wait = 4;
            int res = ds.SecondsToHours(x);
            Assert.AreEqual(wait, res);
        }
    }
}
