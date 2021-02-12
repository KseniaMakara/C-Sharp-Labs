using System;

namespace Lab5_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, a3;
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("a1=");
            a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("a2=");
            a3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("a3=");
            if (a3 - a2 == a2 - a1)
                Console.WriteLine(" Арифметична прогресія");
            else
                Console.WriteLine("Рандомний набір чисел");


        }
    }
}
