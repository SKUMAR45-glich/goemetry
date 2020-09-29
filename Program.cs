using System;

namespace Start
{
    class Program
    {
        public class Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

        };
        static void Main(string[] args)
        {
            int x1 = Console.ReadLine();
            int x2 = Console.ReadLine();
            int y1 = Console.ReadLine();
            int y2 = Console.ReadLine();
            Point p1 = new Point(x1, y1);
            Point q1 = new Point(x2, y2);
            double d = getdistance(x1, x2, y1, y2);
            Console.WriteLine("Distance between coordinates"+d);
        }
        static double getdistance(int x1, int x2, int y1, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
