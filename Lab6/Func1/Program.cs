using System;
/// <summary>
/// Функції
/// </summary>
namespace Classes
{
    class Program
    {
        public static double MinMax(double a, double b)
        {
            if (a > b)
              return  Math.Pow(a, 3) + Math.Pow(Math.Pow(a, 2) + Math.Pow(b, 4), 1 / 2);
            
            else
              return (Math.Pow(a, 2) - 2 * a + Math.Pow(a, 1 / 2))/ Math.Pow(a, 3 / 5);
             
        }
        static void Main(string[] args)
        {
            double n, m;
            Console.WriteLine("n=");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("m=");
            m = Convert.ToDouble(Console.ReadLine());
            
            double u = MinMax(n, m) + MinMax(2, n) + 2;
            Console.WriteLine("Value is:={0:0.00}", u);
            Console.ReadKey();
        }
    }
}