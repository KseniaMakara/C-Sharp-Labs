using System;

namespace ClassMatrixOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Mat mass1 = new Mat();
            mass1.EnterMat();
            mass1.Sum();
            Mat mass2 = new Mat();
            mass2.EnterMat();
            mass2.Sum();
            Mat sumM = mass1 + mass2;
            sumM.PrintMat();
            Console.WriteLine();

            TMSMatrix t = new TMSMatrix();
            t.EnterMat(); 
        }
    }
}
