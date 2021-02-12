using System;

namespace Lab2_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.Write("x=");
            x = Convert.ToDouble(Console.ReadLine());
            if (x <= 3 && x >= 1)
            {
                double z = Math.Log10(x) - Math.Tan(x);
                Console.WriteLine("z={0}", z);
            }
            else if (x > 3 && x <= 4)
            {
                double z = Math.Tan(x);
                Console.WriteLine("z={0}", z);
            }
            else
                Console.WriteLine("z=0");
        }
    }
}
