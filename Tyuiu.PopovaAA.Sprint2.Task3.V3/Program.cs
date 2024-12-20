﻿using Tyuiu.PopovaAA.Sprint2.Task3.V3.Lib;
namespace Tyuiu.PopovaAA.Sprint2.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #2 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                 *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                       *");
            Console.WriteLine("* Задание #3                                                                *");
            Console.WriteLine("* Вариант #3                                                                *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с      *");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит        *");
            Console.WriteLine("*значение переменной X с клавиатуры. Округлить полученное значение до трех  *");
            Console.WriteLine("* знаков после запятой                                                      *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();
        }
    }
}
