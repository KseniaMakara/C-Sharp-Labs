using System;

namespace Lab5_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 1;
            double x0 = 1;
            double x2 = 0;
            int n;
           
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("n = ");
            double s = 0;
            double c = 0;
            for  (int i = 2; i<=n; i++)
                x2 = Math.Sin(x1) + x0 / Math.Cos(x1);
                s += x2;
                x0 = x1;
                x1 = x2;
            Console.WriteLine("sum={0}", s);
        }
    }
}
