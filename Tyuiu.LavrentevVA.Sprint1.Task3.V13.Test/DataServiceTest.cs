using Tyuiu.LavrentevVA.Sprint1.Task3.V13.Lib;

namespace Tyuiu.LavrentevVA.Sprint1.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 253;
            var res = ds.MultiplyOfDigits(x);
            Assert.AreEqual(30, res);
        }
    }
}
