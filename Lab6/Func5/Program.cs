using System;

namespace Func5
{
    class Program
    {
        public static double FunkyTown(double x)
        {
            double i, s1, s2, tg;
            s1 = 0;
            s2 = 15;
            tg = Math.Tan(x);
            if (x > 3)
            {
                for (i = 1; i <= 17; i += 2)
                    s1 += Math.Sin(Math.Pow(x, i));
                return s1;
            }
                
            else
            {
                for (i = 1; i <= 5; i++)
                    s2 += tg;
                    tg *= Math.Tan(x);
                return s2;
            }

        }
        static void Main(string[] args)
        {
            double a, b, u;
            Console.Write("a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToDouble(Console.ReadLine());
            u = Math.Max(FunkyTown(a), FunkyTown(b));
            Console.WriteLine($"Value is:{u}");
        
        }
    }
}
