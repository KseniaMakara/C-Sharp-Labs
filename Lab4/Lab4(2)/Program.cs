using System;

namespace Lab2_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.Write("x=");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y=");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("z=");
            z = Convert.ToDouble(Console.ReadLine());
            double p = x + y + z;
            double n = x * y * z;
            double m = x * y - z;
            double max1 = Math.Max(p, n);
            double max2 = Math.Max(max1, m);
            Console.WriteLine("max={0}", max2);
            Console.ReadKey();
        }
    }
}
