using System;

namespace Lab7._3._10
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

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Random r = new Random();
                    matrix[i, j] = r.Next(-100, 100);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.Write("\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        matrix[i, j] = 0;
                    }
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }
    }
}
