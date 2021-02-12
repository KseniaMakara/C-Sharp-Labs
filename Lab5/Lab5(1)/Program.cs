using System;

namespace Lab5_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("a=");
            a = Convert.ToDouble(Console.ReadLine());
            int n;
            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());
            double s = 1/a;
           
            for (int i = 1; i <= n; i++)
                s= s + s/(a+(i));
            
            Console.WriteLine("s={0}", s);
        }
    }
}
