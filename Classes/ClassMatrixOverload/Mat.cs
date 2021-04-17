using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMatrixOverload
{
    class Mat
    {
        public int n;
        public int[,] matrix;

        public int N
        {
            get
            {
                return n;
            }
            set
            {
                if (value > 0)
                    n = value;
                n = 2;
            }
        }
        public Mat(int n, int[,] arr)//constructor with parameters
        {
            this.n = n;
            matrix = arr;
        }
        public Mat()
        {
            n = 2;
            matrix = new int[2, 2];

        }
        public void EnterMat( bool ran = true, int minRandValue = -100, int maxRandValue = 101)
        {
            {
                int[,] massive = new int[n, n];

                Random rand = new Random(DateTime.Now.Millisecond);
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (ran)
                            massive[i, j] = rand.Next(minRandValue, maxRandValue);
                        else
                        {
                            Console.Write($"a[{i},{j}]=");
                            massive[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }
                matrix = massive;
                PrintMat();
            }
        }
        public void PrintMat()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void Sum()
        {
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    s += matrix[i, j];
                }
            }
            Console.WriteLine($"Sum is: {s} ");
        }
        public static Mat operator +(Mat a, Mat b)
        {
            int[,] array = new int[a.n, a.n];
            for (int i = 0; i < a.n; i++)
            {
                for (int j = 0; j < a.n; j++)
                {
                    array[i, j] = a.matrix[i, j] + b.matrix[i, j];
                }
            }
            return new Mat(a.n, array);
        } 
    }
}
