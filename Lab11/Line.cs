using System;
using System.Collections.Generic;
using System.Text;

namespace Класи11_13_
{
    class Line
    {
        public double x;
        public double y;

        public  Line(double x, double y)
        {
            this.x = x;
            this.x = y;
        }
        public Line()
        {
            x = 4;
            y = 3;
        }
        public Line(Line l)
        {
            this.x = l.x;
            this.y = l.y;
        }

        public double Enter(double x, double y)
        {
            Console.WriteLine("Enter x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y:");
            y = Convert.ToDouble(Console.ReadLine());
            return x;
            return y;
        }
        public string Crossing(double x, double y, double x1, double y1)
        {
            if (x * y1 - x1 * y != 0)
                return "Lines have common point";
            else if (x * y1 - x1 * y == 0 && x * y1 != 0 && x1 * y != 0)
                return "Lines are parallel";
            return "Lines aren't parallel or crossing";
        }
        public static Line operator +(Line l1, Line l2)
        {
            return new Line(l1.x + l2.x, l1.y + l2.y);
        }
        public static Line operator -(Line l1, Line l2)
        {
            return new Line(l1.x - l2.x, l1.y - l2.y);
        }
    }
}
