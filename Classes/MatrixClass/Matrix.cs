using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixClass
{
    class Matrix
    {
        public int[,] matrix; //fields
        public int n;
        public int m;


        public int N //properties
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
        public int M //properties
        {
            get
            {
                return m;
            }
            set
            {
                if (value > 0)
                    m = value;
                m = 3;
            }
        }
        public Matrix()//constructor 
        {
            matrix = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };

        }
        public Matrix(int[,] matrix, int n, int m)
        {
            this.n = n;
            this.m = m;

            matrix = new int [this.n, this.m];
        }
        public void EnterMatrix(int n, int m)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < n; i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < m; j++) //Як змінюються номери стовпців
                {
                    //Console.Write($"a[{i},{j}]=");
                    //arr[i, j] = Convert.ToDouble(Console.ReadLine());
                    matrix[i, j] = rand.Next(-100, 101);
                }
            }
        }
        public void PrintMatrix(int n, int m)
        {
            for (int i = 0; i < n; i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < m; j++) //Як змінюються номери стовпців
                {
                    Console.Write(matrix[i, j] + "/t");
                }
                Console.WriteLine();
            }
        }
        public int Max(int[,] matrix, int n, int m)
        {
            int max = matrix[1, 1];
            for (int i = 0; i < n; i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < m; j++) //Як змінюються номери стовпців
                {
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                }
            }
            Console.WriteLine($"Maximum is:{max}");
            return max;
        }
        public int Min(int[,] matrix, int n, int m)
        {
            int min = matrix[1, 1];
            for (int i = 0; i < n; i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < m; j++) //Як змінюються номери стовпців
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                }
            }
            Console.WriteLine($"Maximum is:{min}");
            return min;
        }
    }
}

