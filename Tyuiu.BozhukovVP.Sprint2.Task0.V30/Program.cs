using Tyuiu.BozhukovVP.Sprint2.Task0.V30.Lib;
namespace Tyuiu.BozhukovVP.Sprint2.Task0.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 95;
            int y = 1735;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.Title = "Спринт #2 Выполнил: Божуков В. П. ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #30                                                              *");
            Console.WriteLine("* Выполнил: Божуков В. П. ИБКСб-24-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УCЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не *");
            Console.WriteLine("* должна нарушаться) и арифметических выражений, которая вернет логическую *");
            Console.WriteLine("* последовательность(массив): (True, False, True, False, True, False), при x = 95, y = 1735 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("X == " + x);
            Console.WriteLine("Y == " + y);
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
