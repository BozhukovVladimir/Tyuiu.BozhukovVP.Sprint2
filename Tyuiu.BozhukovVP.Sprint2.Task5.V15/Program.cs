using Tyuiu.BozhukovVP.Sprint2.Task5.V15.Lib;
namespace Tyuiu.BozhukovVP.Sprint2.Task5.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 Выполнил: Божуков В. П. ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Божуков В. П. ИБКСб-24-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УCЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на с#, которая суммирует значение двух    *");
            Console.WriteLine("* одинаоквых массивов по длине.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите число от 1 до 365: ");
            int numDay = Convert.ToInt32(Console.ReadLine());
            string res;
            if ((numDay < 1) || (numDay > 365))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                numDay= numDay % 7;
                res = "Это день недели: " + ds.FindDayName(numDay);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
