using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using Tyuiu.TalalaevaAV.Sprint2.Task0.V15.Lib;
namespace Tyuiu.TalalaevaAV.Sprint2.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperationns()
        {
            DataService ds= new DataService();
            int x = 3105;
            int y = 275;
            bool[] res= new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, false, true, true, false, false, };
            CollectionAssert.AreEqual(wait,res);

        }
    }
}