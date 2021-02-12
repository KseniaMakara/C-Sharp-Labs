using System;

namespace Lab1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, b1, b2, c1, c2, d1, d2;
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
            Console.Write("d1=");
            d1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("d2=");
            d2 = Convert.ToDouble(Console.ReadLine());
            double AD = Math.Sqrt(Math.Pow((a1 - d1), 2) + Math.Pow((a2 - d2), 2));
            double CD = Math.Sqrt(Math.Pow((d1 - c1), 2) + Math.Pow((d2 - c2), 2));
            double AB = Math.Sqrt(Math.Pow((a1 - b1), 2) + Math.Pow((a2 - b2), 2));
            double BC = Math.Sqrt(Math.Pow((b1 - c1), 2) + Math.Pow((b2 - c2), 2));

            if (AB == CD && AB == BC && AB == AD)
                Console.WriteLine("Ромб ");
            else
                Console.WriteLine(" Інший вид чотрикутника ");

        }
    }
}
