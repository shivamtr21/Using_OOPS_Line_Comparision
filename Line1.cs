using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOOPS_lineComparision
{
    public class Line1
    {
        public void Call()
        {
            //Line1
            Console.WriteLine("Enter the value of x-cordinate of point1: x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x-cordinate of point1: y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x-cordinate of point1: x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x-cordinate of point1: y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double length1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            //Line2
            Console.WriteLine("Enter the value of x-cordinate of point1: x3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x-cordinate of point1: y3");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x-cordinate of point1: x4");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x-cordinate of point1: y4");
            int y4 = Convert.ToInt32(Console.ReadLine());

            double length2 = Math.Sqrt(((x4 - x3) * (x4 - x3)) + ((y4 - y3) * (y4 - y3)));
            Console.WriteLine("Distance between two point: " + "(" + x1 + ", " + y1 + ")" + "(" + x2 + ", " + y2 + ") is :" + length1);
            Console.WriteLine("Distance between two point: " + "(" + x3 + ", " + y3 + ")" + "(" + x4 + ", " + y4 + ") is :" + length2);

            if (length1 == length2)
            {
                Console.WriteLine("Both The Line are equal");
            }
            else
            {
                Console.WriteLine("Both The Line are not Equal");
            }

        }
    }
}
