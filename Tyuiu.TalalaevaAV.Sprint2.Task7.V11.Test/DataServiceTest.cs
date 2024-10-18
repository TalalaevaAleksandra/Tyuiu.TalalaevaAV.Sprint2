using Tyuiu.TalalaevaAV.Sprint2.Task7.V11.Lib;
namespace Tyuiu.TalalaevaAV.Sprint2.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.7;
            double y = 0.7;
            bool wait = true;
            bool res=ds.CheckDotInShadedArea(x,y);
            Assert.AreEqual(wait, res);

        }
    }
}