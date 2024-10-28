﻿using Tyuiu.PopovaAA.Sprint2.Task7.V3.Lib;
namespace Tyuiu.PopovaAA.Sprint2.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Title = "Спринт #2 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                 *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                   *");
            Console.WriteLine("* Задание #7                                                                *");
            Console.WriteLine("* Вариант #3                                                                *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные             *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами X, *");
            Console.WriteLine("* Y в заштрихованной области.                                               *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}
