using System;

namespace Massive2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Вводимо кількість рядків і кількість стовпців
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m=");
            int m = Convert.ToInt32(Console.ReadLine());
            //2. Виділяємо пам"ять     0  1            для масиву
            double[,] arr = new double[n, m];
            //3. Вводимо елементи масиву або геренуємо їх
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arr.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < arr.GetLength(1); j++) //Як змінюються номери стовпців
                {
                    //Console.Write($"a[{i},{j}]=");
                    //arr[i, j] = Convert.ToDouble(Console.ReadLine());
                    arr[i, j] = rand.Next(-100, 101);
                }
            }
            //4. Виконуємо операції з масивом
            //Вивід матриці на екран
            for (int i = 0; i < arr.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < arr.GetLength(1); j++) //Як змінюються номери стовпців
                {
                    Console.Write("{0,8:f}  ", arr[i, j]);
                }
                Console.WriteLine();
            }
            //Знайти суму додатніх
            double sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < arr.GetLength(1); j++) //Як змінюються номери стовпців
                {
                    if (arr[i, j] > 0)
                        sum += arr[i, j];
                }
            }
            Console.WriteLine("Sum={0}", sum);
        }
    }
}
