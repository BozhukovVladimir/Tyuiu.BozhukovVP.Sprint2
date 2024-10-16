using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BozhukovVP.Sprint2.Task2.V15.Lib
{
    public class DataService : ISprint2Task2V15
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            bool a = ((x == 2) && (y > 4 && y < 7)) || (x == 6)&&(y>10 && y<13);
            bool b = ((x > 2 && x < 6)&&(y > 2 && y < 8)) || ((x > 5 && x < 13)&&(y > 4 && y < 9));
            bool c = ((x > 1 && x < 4)&&(y > 12 && y < 14)) || ((x > 3 && x < 6) && (y > 11 && y < 13)) || ((x > 11 && x < 14) && (y > 11 && y < 13));
            bool d = ((x > 4 && x < 7)&&(y > 8 && y < 11)) || ((x > 10 && x < 13) && (y > 8 && y < 12));
            bool e = ((x > 8 && x < 13) && (y > 2 && y < 5)) || ((x > 12 && x < 14) && (y > 5 && y < 9));
            if (a || b || c || d)
            { res = true; }
            else { res = false; }
            return res;
        }
    }
}
