using Tyuiu.LavrentevVA.Sprint1.Task1.V21.Lib;
namespace Tyuiu.LavrentevVA.Sprint1.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-1, res);
        }
    }
}
