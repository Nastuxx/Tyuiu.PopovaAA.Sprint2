using Tyuiu.PopovaAA.Sprint2.Task2.V20.Lib;
namespace Tyuiu.PopovaAA.Sprint2.Task2.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                 *");
            Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи                        *");
            Console.WriteLine("* Задание #2                                                                *");
            Console.WriteLine("* Вариант #20                                                               *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и  *");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области. *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Введите значение переменной X");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y");
            int y = Convert.ToInt32(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находится в закрашенной области");
            }

            else
            {
                Console.WriteLine("Точка не находится в закрашенной области");
            }

            Console.ReadKey();


        }
    }
}
