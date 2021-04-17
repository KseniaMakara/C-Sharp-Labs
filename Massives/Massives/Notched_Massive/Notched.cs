using System;
using System.Collections.Generic;
using System.Text;

namespace Notched_Massive
{
    class Notched
    {
        public int[][] arr = new int[5][];

        public Notched()
        {
            arr[0] = new int[3];
            arr[1] = new int[6];
            arr[2] = new int[8];
            arr[3] = new int[6];
            arr[4] = new int[1];

        }
        public Notched(int[][] arr)
        {
            this.arr = arr;
        }
        public Notched(Notched n)
        {
            this.arr = n.arr;
        }
        public int[][] Enter()
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = random.Next(100);
                }
            return arr;
        }
        public void Print()
        {
            Enter();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write((arr[i][j]) + "\t ");
                }
                Console.WriteLine();
            }
        }
    }
}
