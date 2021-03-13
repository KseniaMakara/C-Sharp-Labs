using System;

namespace Func4
{
    class Program
    {
       public static double Fuck( double x)
        {
            double i, sum, mul;
            sum = 0;
            mul = -Math.Cos(x);
            if (x > 3)
            {
                for (i = 1; i <= 6; i ++)
                    sum += Math.Sin(Math.Pow(x, i));
                return sum;
            }
            else
            {
                for (i = 1; i <= 5; i += 2)
                    sum += mul;
                    mul *= -Math.Cos(x);
                return sum;
            }
              
        }
        static void Main(string[] args)
        {
            double a, b, u;
            Console.Write("a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToDouble(Console.ReadLine());
            u = Math.Min(Fuck(a), Fuck(b));
            Console.WriteLine("Minimum is:", u);

        }
    }
}
