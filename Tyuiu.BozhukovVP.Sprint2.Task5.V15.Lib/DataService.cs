using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BozhukovVP.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            string res;
            k = k % 7;
            switch (k)
            {
                case 1:
                    res = "понедельник";
                    break;
                case 2:
                    res = "вторник";
                    break;
                case 3:
                    res = "среда";
                    break;
                case 4:
                    res = "четверг";
                    break;
                case 5:
                    res = "пятница";
                    break;
                case 6:
                    res = "Суббота";
                    break;
                case 7:
                    res = "воскресенье";
                    break;
                default:
                    throw new ArgumentException($"День должен быть от 1 до 365. Значение {k}");
            }
            return res;
        }
    }
}
