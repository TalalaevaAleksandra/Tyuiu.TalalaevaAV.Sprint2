using Tyuiu.TalalaevaAV.Sprint2.Task5.V10.Lib;
namespace Tyuiu.TalalaevaAV.Sprint2.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds=new DataService();
            int g = 2023;
            int m = 9;
            int n = 8;
            string wait ="07.09.2023";
            string res = ds.FindDateOfPreviousDay(g,m,n);
            Assert.AreEqual(wait,res);
            
        }
    }
}