using System;

namespace Масиви2_10_
{
    class Program
    {

        static void Main(string[] args)
        {
            int n,i;
            Console.Write("Enter x: ");
            double x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number: ");
            n = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n];
            
            for ( i = 0; i < n; i++)
                    a[i] = (i+1)* (Math.Sin((i+1) * x) + Math.Cos((i+1) * x));
            Console.WriteLine("Array is=", a[i]);
        }
    }
}
