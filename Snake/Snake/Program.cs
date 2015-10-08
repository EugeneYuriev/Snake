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
            
            Point p1 = new Point(2,5,'*');
            //p1.Draw();

            Point p2 = new Point(4, 3, '*');
            //p2.Draw();
            
            
            List<int> numList = new List<int>();

            numList.Add(5);
            numList.Add(7);
            numList.Add(9);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            List<Point> PointList = new List<Point>();

            PointList.Add(p1);
            PointList.Add(p2);


            List<char> cList = new List<char>();

            cList.Add('@');
            cList.Add('$');
            cList.Add('%');
            cList.Add('&');

            foreach (char i in cList)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            cList.RemoveAt(1);
            foreach (char i in cList)
            {
                Console.Write(i);
            }

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
