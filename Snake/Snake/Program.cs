using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Point p1 = new Point(2,5,'*');
            p1.Draw();

            Point p2 = new Point(4, 2, '*');
            p2.Draw();
            */

            int x;
            x = 1;
            Console.WriteLine(x);
            func1(x);
            Console.WriteLine(x);


            Point p1 = new Point(1, 1, '*');
            Point p2 = new Point();

            //p2 = p1;
            Copy(p2,p1);

            p2.x = 2;
            p2.y = 2;

            Console.WriteLine("p1.x=" + p1.x + ", p1.y=" + p1.y);

            Console.ReadLine();
        }

        static void Copy(Point p1, Point p2)
        {
            p1.x = p2.x;
            p1.y = p2.y;
        }

        static void func1(int x)
        {
            x = 2;
            Console.WriteLine(x);
        }
    }
}
