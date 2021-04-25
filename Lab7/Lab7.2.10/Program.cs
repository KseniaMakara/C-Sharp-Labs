using System;

namespace Lab7._2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = "); //lines
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("m = "); //columns
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, m];

            int k = 1, l = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                        matrix[i, j] = k - l;
                        Console.Write(matrix[i, j] + "\t");
                        k*= (k + 1);
                        l*= (l + 1);
                }
                Console.WriteLine();
            }
           
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i +j)% 2 != 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
