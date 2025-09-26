using Tyuiu.LavrentevVA.Sprint1.Task6.V7.Lib;

namespace Tyuiu.LavrentevVA.Sprint1.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strT = "привет как дела";
            DataService ds = new DataService();
            string res = ds.DeleteLastLetter(strT);
            string wait = "приве ка дел";
            Assert.AreEqual(wait, res);


        }
    }
}
