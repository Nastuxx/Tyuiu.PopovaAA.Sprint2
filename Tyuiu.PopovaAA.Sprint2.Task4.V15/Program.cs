using Tyuiu.PopovaAA.Sprint2.Task4.V15.Lib;
namespace Tyuiu.PopovaAA.Sprint2.Task4.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                 *");
            Console.WriteLine("* Тема: Тернарный оператор                                                  *");
            Console.WriteLine("* Задание #4                                                                *");
            Console.WriteLine("* Вариант #15                                                               *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение использованием   *");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значение переменных x, y с  *");
            Console.WriteLine("* клавиатуры, если х^1/2 : 2 > y^1/2 - 20, то z = ((3 + 2/y^2 ))^x  иначе   *");
            Console.WriteLine("* cos(y) + (12/x^2 ). Ответ округлите до 3 знаков после запятой.            *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Значение функции: " + res);

            Console.ReadKey();
        }
    }
}
