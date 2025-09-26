using Tyuiu.LavrentevVA.Sprint1.Task7.V22.Lib;

namespace Tyuiu.LavrentevVA.Sprint1.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double z = 1.129;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);

        }
    }
}
