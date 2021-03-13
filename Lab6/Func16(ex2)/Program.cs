using System;

namespace Mass16Lab
{
    class Program
    {
        public static double[] ArrM(int m, bool randomMode = false, int minRandValue = 0, int maxRandValue = 20)
        {
            double[] arr = new double[m];
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arr.Length; i++)
            {
                if (randomMode)//якщо ця штука true то рандоно вичисляє
                    arr[i] = rand.Next(minRandValue, maxRandValue);
                else
                {
                    Console.Write($"a[{i}]=");
                    arr[i] = Convert.ToDouble(Console.ReadLine());
                }
            }
            return arr;
        }
        static void printArray(double[] arr) 
        {
            for (int i = 0; i < arr.GetLength(0); i++) 
            
                Console.Write("{0,8:f}  ", arr[i]);
                Console.WriteLine();
        }
        public static void SumArr(double[] arr)
        { double sum = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > 5)
                    sum += arr[i];
            Console.WriteLine($"Sum = {sum}");

        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n=");
            n = Convert.ToInt32(Console.ReadLine());
            
            double[] arr = ArrM(n, true);
            printArray(arr);
            SumArr(arr);
        }
    }
}
