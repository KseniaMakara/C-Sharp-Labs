using System;

namespace Mass1_Lab6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(-5, 10);
             
            foreach (var item in arr)
            {
                Console.Write("{0,8:f}  ", item);
            }
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
                if (max < arr[i])
                {
                    max = arr[i];
                }
            Array.Sort(arr);
            int maxValue = arr[arr.Length - 1];

            Console.WriteLine($"Array is:{maxValue}");
        }
    }
}