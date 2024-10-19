using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PopovaAA.Sprint2.Task1.V12.Lib
{
    public class DataService : ISprint2Task1V12
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (b > a) | (c > d);
            res[1] = (d + 331 == c) & (a - 36 == b);
            res[2] = (b >= a) || (c >= d);
            res[3] = (d + 330 + 5 == c) && (a - 30 - 6 == b);
            res[4] = !res[3];
            res[5] = (b > a) ^ (c < d);

            return res;
        }
    }
}
