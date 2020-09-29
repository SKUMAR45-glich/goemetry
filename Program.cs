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
        public static string distance(Point p1, Point q1, Point p2, Point q2)
        {
            // for details of below formula. 
            /*int val = (q.y - p.y) * (r.x - q.x) -
                    (q.x - p.x) * (r.y - q.y);

            if (val == 0) return 0; // colinear 

            return (val > 0) ? 1 : 2; // clock or counterclock wise */
            double d1 = Math.Sqrt(Math.Pow(q1.x - p1.x, 2) + Math.Pow(q1.y - p1.y, 2));

            double d2 = Math.Sqrt(Math.Pow(q2.x - p2.x, 2) + Math.Pow(q2.y - p2.y, 2));
            if (d1 == d2)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            //double d1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            int x1 = Console.ReadLine();
            int x2 = Console.ReadLine();
            int y1 = Console.ReadLine();
            int y2 = Console.ReadLine();
            int x12 = Console.ReadLine();
            int y12 = Console.ReadLine();
            int y21 = Console.ReadLine();
            int x21 = Console.ReadLine();
            Point p1 = new Point(x1, y1);
            Point q1 = new Point(x2, y2);
            Point p2 = new Point(x12, y12);
            Point q2 = new Point(x21, y21);
            distance(p1, q1, p2, q2);
            //double d = getdistance(x1, x2, y1, y2);
        }
       
        
        
    }
}
