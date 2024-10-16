using Tyuiu.BozhukovVP.Sprint2.Task5.V15.Lib;
namespace Tyuiu.BozhukovVP.Sprint2.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            Assert.AreEqual("понедельник", ds.FindDayName(1));
            Assert.AreEqual("вторник", ds.FindDayName(2));
            Assert.AreEqual("среда", ds.FindDayName(3));
            Assert.AreEqual("четверг", ds.FindDayName(4));
            Assert.AreEqual("пятница", ds.FindDayName(5));
            Assert.AreEqual("Суббота", ds.FindDayName(6));
            Assert.AreEqual("воскресенье", ds.FindDayName(7));
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(8);
            });
        }
    }
}