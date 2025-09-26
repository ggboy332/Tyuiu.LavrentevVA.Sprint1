using Tyuiu.LavrentevVA.Sprint1.Task4.V1.Lib;

namespace Tyuiu.LavrentevVA.Sprint1.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 0.062;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
