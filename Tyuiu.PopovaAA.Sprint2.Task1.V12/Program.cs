﻿using Tyuiu.PopovaAA.Sprint2.Task1.V12.Lib;
namespace Tyuiu.PopovaAA.Sprint2.Task1.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 152;
            int b = 116;
            int c = 887;
            int d = 556;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                 *");
            Console.WriteLine("* Тема: Логические операции                                                 *");
            Console.WriteLine("* Задание #1                                                                *");
            Console.WriteLine("* Вариант #12                                                               *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,           *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражении)*");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций не *");
            Console.WriteLine("* должна нарушаться), а также арифметических выражений, которая вернет      *");
            Console.WriteLine("* логическую последовательность(массив): (True, True, True, False, True,    *");
            Console.WriteLine("* False), при a = 152, b = 116, c = 887, d = 556                            *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            for (int i = 0; i<6; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}
