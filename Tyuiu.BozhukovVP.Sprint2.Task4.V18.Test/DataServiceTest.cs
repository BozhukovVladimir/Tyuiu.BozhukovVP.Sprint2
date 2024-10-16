using Tyuiu.BozhukovVP.Sprint2.Task4.V18.Lib;
namespace Tyuiu.BozhukovVP.Sprint2.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = -2;
            double y = -2;
            double res = ds.Calculate(x, y);
            double wait = 0.025;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 50;
            Assert.AreEqual(res, wait);
        }
    }
}