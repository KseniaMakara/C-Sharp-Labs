using System;
using System.Collections.Generic;
using System.Text;

namespace Notched_Massive
{
    class Regular
    {
        private int[,] mass = new int[5, 6];
        
        public Regular()
        {
            int[,] mass = new int[5, 6];
           
        }
        public Regular(int[,] mass)
        {
            this.mass = new int[mass.GetLength(0), mass.GetLength(1)];
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    this.mass[i, j] = mass[i, j];
                }
            }
        }
        //public Regular(Regular r)
        //{
        //    this.mass = r.mass;
        //}

        public int Length
        {
            get
            {
                return mass.Length;
            }
        }
        public int this[int i, int j] // indexer
        {
            get
            {
                if (i >= 0 && i < mass.GetLength(0) && j >= 0 && j < mass.GetLength(1))
                    return mass[i, j];
                return 0;
            }
            set
            {
                if (i >= 0 && i < mass.GetLength(0) && j >= 0 && j < mass.GetLength(1) && value > 0 && value <= 100)
                    mass[i, j] = value;
            }
        }
       
        public int[,] Enter( )
        {
            Random rand = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = rand.Next(100);
                }
            }
            return mass;
        }
        public void Print()
        {
            Enter( );
            Random rand = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
