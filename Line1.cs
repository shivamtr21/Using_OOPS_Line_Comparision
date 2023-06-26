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
            Console.WriteLine("Enter the value of x-cordinate of point1: x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x-cordinate of point1: y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x-cordinate of point1: x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x-cordinate of point1: y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double length = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Console.WriteLine("Distance between two point: " + "(" + x1 + ", " + y1 + ")" + "(" + x2 + ", " + y2 + ") is :" + length);
        }
    }
}
