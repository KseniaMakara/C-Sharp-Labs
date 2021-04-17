using System;

namespace Класи1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[8] { 1, 5, 6, 7, 8, 7, 1, 4};
            Class c = new Class(arr1);
            Console.WriteLine($"Array is: {c.s} ");
            Console.WriteLine(c.printArray(arr1));
            Console.WriteLine(c.GetSum(arr1));
            Console.WriteLine(c.Max(arr1));
            Console.WriteLine($"New array is: {c.Add(ref arr1, 2, 4)} ");
        }
    }
}
                
