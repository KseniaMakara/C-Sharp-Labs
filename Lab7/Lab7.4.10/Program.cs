using System;

namespace Lab7._4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = "); //lines
            int n = Convert.ToInt32(Console.ReadLine());


            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Random r = new Random();
                    matrix[i, j] = r.Next(-100, 100);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int min=matrix[0,0];
            Console.Write("\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        if (matrix[i, j] <=min)
                        {
                            min = matrix[i, j];
                        }
                        matrix[i, j] = min;
                    }
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }
    }
}


