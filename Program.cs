using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = Console.ReadLine();
            int x2 = Console.ReadLine();
            int y1 = Console.ReadLine();
            int y2 = Console.ReadLine();
            double d = getdistance(x1, x2, y1, y2);
        }
        static double getdistance(int x1, int x2, int y1, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
