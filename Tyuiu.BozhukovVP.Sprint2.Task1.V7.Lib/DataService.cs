using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BozhukovVP.Sprint2.Task1.V7.Lib
{
    public class DataService : ISprint2Task1V7
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (c == d);
            res[1] = (b > c) & (a <= d);
            res[2] = (d == b) || (a <= c);
            res[3] = (a == d) && (b >= c);
            res[4] = !(res[1]);
            res[5] = (a <= c)^(d < b);
            return res;
        }
    }
}
