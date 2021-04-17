using System;

namespace Func2
{
    class Program
    {
        public static double Func2(double a, double b)
        {
            if (a>0 && b>0)
                return Math.Pow(a, 3) + Math.Pow(Math.Pow(a, 2) + Math.Pow(b, 4), 1 / 2);
            else if (a>0 && b<0)
                return (Math.Pow(a, 2) - 2 * a + Math.Pow(a, 1 / 2)) / Math.Pow(a, 3 / 5);
            return Math.Sin(a * b);

        }
        static void Main(string[] args)
        {
            double n, m, u;
            Console.Write("n =");
            n = Convert.ToDouble(Console.ReadLine());
            Console.Write("m");
            m = Convert.ToDouble(Console.ReadLine());
            u = Func2(n, m) + Func2(2,n) + 2;
            Console.WriteLine("Value is: {0:0.00}", u);
        }
    }
}
