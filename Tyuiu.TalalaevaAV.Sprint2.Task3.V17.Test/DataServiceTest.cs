using Tyuiu.TalalaevaAV.Sprint2.Task3.V17.Lib;
namespace Tyuiu.TalalaevaAV.Sprint2.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds= new DataService();
            double x = 3;
            double wait = 265;
            double res= ds.Calculate(x);
            Assert.AreEqual(wait, res);


        }
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = -0.286;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidExpression2()
        {
            DataService ds = new DataService();
            double x = -1;
            double wait = 16;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidExpression3()
        {
            DataService ds = new DataService();
            double x = -25;
            double wait = -274.96;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);

        }
    }
}