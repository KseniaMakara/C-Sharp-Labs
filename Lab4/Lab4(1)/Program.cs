using System;

namespace Lab4_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, b1, b2, c1, c2;
            Console.Write("a1=");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("a2=");
            a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b1=");
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b2=");
            b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c1=");
            c1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c2=");
            c2 = Convert.ToDouble(Console.ReadLine());

            double p = Math.Sqrt(Math.Pow((a1 - c1), 2) + Math.Pow((a2 - c2), 2)) + Math.Sqrt(Math.Pow((b1 - c1), 2) + Math.Pow((b2 - c2), 2)) + Math.Sqrt(Math.Pow((a1 - b1), 2) + Math.Pow((a2 - b2), 2));

            Console.WriteLine("p={0}", p);
            Console.ReadKey();
        }
    }
}
