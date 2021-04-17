using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_18_
{
    class TInterval2D
    {
        public int X1,X2,Y1,Y2;
        public TInterval2D(int x1, int x2, int y1, int y2) //констрктор з параметрами
        {
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
    }
        public TInterval2D()// конструктор без параметрів
        {
            X1 = 9;
            X2 = 2;
            Y1 = -7;
            Y2 = 1;
        }
        public TInterval2D (TInterval2D t)// конструктор копіювання
        {
            this.X1 = t.X1;
            this.Y1 = t.Y1;
            this.X2 = t.X2;
            this.Y2 = t.Y2;
        }
        public void EnterPrint(int x1, int x2, int y1, int y2)
        {
            Console.WriteLine($"Start: X1={X1}, Y1 ={Y1}");
            Console.WriteLine($"End: X2={X2}, Y2 ={Y2}");
        }
        public void Poin(int x1, int x2, int y1, int y2, int a1, int a2, int b1, int b2)
        {
            int k1 = (y2 - y1) / (x2 - x1);
            int d1 = (x2 * y1 - x1 * y2) / (x2 - x1);

            int k2 = (b2 - b1) / (a2 - a1);
            int d2 = (a2 * b1 - a1 * b2) / (a2 - a1);

            int x3 = (d2 - d1) / (k1 - k2);
            int y3 = k1 *(d2 - d1) / (k1 - k2) + d1;
            Console.WriteLine($"Cross x ={x3}, Cross y = {y3}");
            if (x3 < x2 && x3 > x1 && x3 < a2 && x3 > a1 && y3 < y2 && y3 > y1 && y3 < b2 && y3 > b1)
                Console.WriteLine("Lines are crossing");
            Console.WriteLine("Lines aren't crossing ");
        }
        public void Lenght(int x1, int x2, int y1, int y2)
        {
            double AB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine($"Lenght : {AB}");
        }
        public void Middle(int x1, int x2, int y1, int y2)
        {
            int c_x = (x1 - x2) / 2;
            int c_y = (y1 - y2) / 2;
            Console.WriteLine($"Middle coordinates : {c_x}, {c_y}");

        }
        public static int operator +(TInterval2D v1, TInterval2D v2)
        {
            return v1.X1 + v2.X2;
            return v1.Y1+v2.Y2;
        }
        public static double operator *(TInterval2D v1, double d)
        {
            return d * v1.X1;
            
        }

    }
}
