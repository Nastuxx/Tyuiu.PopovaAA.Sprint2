using Tyuiu.PopovaAA.Sprint2.Task5.V2.Lib;
namespace Tyuiu.PopovaAA.Sprint2.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int numMonth = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numMonth < 1) || (numMonth > 12))
            {
                res = "Введено неверное значение";
            }

            else
            {
                res = "Время года: " + ds.FindMonthSeason(numMonth);
            }

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();

        }
    }
}
