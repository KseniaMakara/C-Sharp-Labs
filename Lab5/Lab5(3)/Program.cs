using System;

namespace Lab5_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double b = 1
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("x = ");
          
            double sum = 1;
            double a = x;
            for (int i = 1; sum < Math.Abs(a); i++)
       
                double c = b * i;
                sum = sum + a/c;
                a = a * x;
                b= b*i;
            Console.WriteLine("sum={0}", sum);



        }
    }
}
