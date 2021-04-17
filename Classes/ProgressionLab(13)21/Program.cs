using System;


namespace ProgressionLab_13_21
{
    class Program
    {
        static void Main(string[] args)
        {
            TArProgression pr1 = new TArProgression();
            pr1.EnterPrint(6);

            Console.WriteLine(pr1.IndexOf(3));

        }
    }
}
