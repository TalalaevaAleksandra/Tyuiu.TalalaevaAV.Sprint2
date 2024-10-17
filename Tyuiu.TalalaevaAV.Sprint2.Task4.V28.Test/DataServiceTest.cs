using Tyuiu.TalalaevaAV.Sprint2.Task4.V28.Lib;
namespace Tyuiu.TalalaevaAV.Sprint2.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            double wait =1.593;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidExpression2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 6;
            double wait =9;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);


        }

    }
}