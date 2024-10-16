using Tyuiu.TalalaevaAV.Sprint2.Task2.V13.Lib;
namespace Tyuiu.TalalaevaAV.Sprint2.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds=new DataService();
            int x = 6;
            int y = 6;
            bool wait = true;
            bool res=ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait,  res);
        }
    }
}