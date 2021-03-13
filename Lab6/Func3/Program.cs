using System;

namespace Func3
{
    class Program
    {
        public static double Func3(double x)
        { double i, sum, mul;
            sum = 0;
            mul = 1;
            if (x > 0)
            {
                for (i = 1; i <= 5; i++)
                    sum += Math.Pow(x, i);
                return sum;
            }
            else 
            {
                for (i = 1; i <= 5; i++)
                    mul *= Math.Pow(x, i);
                return mul;
            }
               
        }
        static void Main(string[] args)
        {
            double a, b,u;
            Console.Write("a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            b = Convert.ToDouble(Console.ReadLine());
            u = Func3(a) + Func3(2) + Func3(b);
            Console.WriteLine($"Value is ={u}");

        }
    }
}
