using Tyuiu.BozhukovVP.Sprint2.Task7.V14.Lib;
namespace Tyuiu.BozhukovVP.Sprint2.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInSharedArea()
        {
            DataService ds = new DataService();
            double x = 0.7;
            double y = 0.7;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}