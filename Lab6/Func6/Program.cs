using System;

namespace Func6
{
    class Program
    {
        public static double Max(double x, double y, double z) 
        {
            double m;
            if (x > y&& x>z)
            {  
                m = x;
                return m;
            }
            else if (y>x && y>z)
            {
                m = y;
                return m;
            }
            m = z;
            return z;
        }
        
        static void Main(string[] args)
        {
            double a, b, c, u;
            Console.Write("a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c=");
            c = Convert.ToDouble(Console.ReadLine());
            u = Max(a, b, c) + Max(a + b, a * b, 4 * c) / Max(Math.Pow(Max(a + b, a * b, Math.Pow(a, 2)), 2), 7, Math.Pow(c, 2));
            Console.WriteLine($"Value is: {u}");
        }
    }
}
