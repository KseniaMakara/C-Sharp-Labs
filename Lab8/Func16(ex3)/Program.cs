using System;

namespace Mass16_3_
{
    class Program
    {
        public static double LCD(double m, double n)
        {
            double a = n - m;
            double b = m - n;
            if (m == n)
            {
                Console.WriteLine(m);
                return m;
            }
            else if (n > m)
            {
                while (a != n)
                {
                    if (a > n)
                    {
                        double tmp = a;
                        a = n;
                        n = tmp;
                    }
                    n = n - a;
                }
                Console.WriteLine(a);
                return a;
            }
            else
                while (m != b)
                {
                    if (m > b)
                    {
                        double tmp = b;
                        m = b;
                        b = tmp;
                    }
                    b = b - m;
                }
            Console.WriteLine(m);
            return m;
        }
        static void Main(string[] args)
        {
            double p, k;
            Console.Write("p=");
            p = Convert.ToDouble(Console.ReadLine());
            Console.Write("k=");
            k = Convert.ToDouble(Console.ReadLine());
            LCD(p, k);

        }
    }
}
