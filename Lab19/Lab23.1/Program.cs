using System;
using System.IO;

namespace Lab231
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] arr = new int[n];
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(-50, 50);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            string FileName1;
            Console.Write("Enter file name: ");
            FileName1 = Console.ReadLine();

            FileStream FS = new FileStream(FileName1, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(FS);
            bw.Write(n);
            for (int i = 0; i < n; i++)
            {
                bw.Write(arr[i]);
            }
            bw.Close();
            FS.Close();

            FileStream FS1 = new FileStream(FileName1, FileMode.Open);
            BinaryReader br = new BinaryReader(FS);
            int max = arr[0];
            n = br.ReadInt32();
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
            br.Close();
            FS1.Close();

        }
    }
}
