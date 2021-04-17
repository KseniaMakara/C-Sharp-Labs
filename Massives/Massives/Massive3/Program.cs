using System;

namespace Massive3
{
    class Program
    {
        /// <summary>
        /// Функція для введення або генерування двовимірного масиву
        /// </summary>
        /// <param name="rowCount">Кількість рядків</param>
        /// <param name="colCount">Кількість стовпців</param>
        /// <param name="randomMode">Якщо дорівнює true, то генерується рандомно ((false за замовчуванням))</param>
        /// <param name="minRandValue">Мінімальне рандомне значення (-100 за замовчуванням)</param>
        /// <param name="maxRandValue">Максимальне рандомне значення (-100 за замовчуванням)</param>
        /// <returns>Повертає введений/згенерований масив</returns>
        static double[,] inputArray(int rowCount, int colCount, bool randomMode = false, int minRandValue = -100, int maxRandValue = 101)
        /* Функція inputArray( ціле число рядків, ціле число стовпців, лог тип рандома, 
         * мінімальне значення рандома, максимальне згачення рандома)
         * 
         */
        {
            //2. Виділяємо пам"ять для масиву
            double[,] arr = new double[rowCount, colCount];
            //3. Вводимо елементи масиву або геренуємо їх
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arr.GetLength(0); i++) //Як змінюються номери рядків
            /* GetLength(0) повертає к-сть рядків
             * */
            {
                for (int j = 0; j < arr.GetLength(1); j++) //Як змінюються номери стовпців
                /* GetLength(1) повертає к-сть стовпців
         * */
                {
                    if (randomMode)
                        arr[i, j] = rand.Next(minRandValue, maxRandValue);
                    else
                    {
                        Console.Write($"a[{i},{j}]=");
                        arr[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                }
            }
            return arr;
        }
        static double[,] getFilledArray(int rowCount, int colCount, double fixedValue = 0)
        {
            //2. Виділяємо пам"ять для масиву
            double[,] arr = new double[rowCount, colCount];
            //3. Вводимо елементи масиву або геренуємо їх
            for (int i = 0; i < arr.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < arr.GetLength(1); j++) //Як змінюються номери стовпців
                {
                    arr[i, j] = fixedValue;
                }
            }
            return arr;
        }
        static void printArray(double[,] arr) //фукція яка виводить на екран матрицю
        {
            //Вивід матриці на екран
            for (int i = 0; i < arr.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < arr.GetLength(1); j++) //Як змінюються номери стовпців
                {
                    Console.Write("{0,8:f}  ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static double getSumOfPositiveElements(double[,] arr) // ф-ція шо шукає суму додатніх елементів
        {
            double sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < arr.GetLength(1); j++) //Як змінюються номери стовпців
                {
                    if (arr[i, j] > 0)
                        sum += arr[i, j];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //1. Вводимо кількість рядків і кількість стовпців
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m=");
            int m = Convert.ToInt32(Console.ReadLine());
            //2. Виділяємо пам"ять  i вводимо елементи масиву або геренуємо їх
            double[,] arr = inputArray(n, m, true);
            //4. Виконуємо операції з масивом
            //Вивід матриці на екран
            printArray(arr);
            //Знайти суму додатніх
            double sum = getSumOfPositiveElements(arr);
            Console.WriteLine("Sum={0}", sum);
        }
    }
}
