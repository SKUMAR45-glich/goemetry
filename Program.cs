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
        public static void distance(Point p1, Point q1, Point p2, Point q2)
        {
            
            double d1 = Math.Sqrt(Math.Pow(q1.x - p1.x, 2) + Math.Pow(q1.y - p1.y, 2));

            double d2 = Math.Sqrt(Math.Pow(q2.x - p2.x, 2) + Math.Pow(q2.y - p2.y, 2));
            double d = d1.CompareTo(d2);

            if (d == 0)
            {
                Console.WriteLine("Equal");
            }
            else if (d<0)
            {
                Console.WriteLine("d2 is greater than d1");
            }
            else
            {
                Console.WriteLine("d1 is greater than d2");
            }
            //double d1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int x12 = Convert.ToInt32(Console.ReadLine());
            int y12 = Convert.ToInt32(Console.ReadLine());
            int y21 = Convert.ToInt32(Console.ReadLine());
            int x21 = Convert.ToInt32(Console.ReadLine());
            Point p1 = new Point(x1, y1);
            Point q1 = new Point(x2, y2);
            Point p2 = new Point(x12, y12);
            Point q2 = new Point(x21, y21);
            distance(p1, q1, p2, q2);
            //double d = getdistance(x1, x2, y1, y2);
        }
        /*static double getdistance(int x1, int x2, int y1, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }*/
        
        
    }
}
