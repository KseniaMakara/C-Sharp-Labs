using System;

namespace Massive1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Elements : "); // ввід елементів
            string s = Console.ReadLine();   // присвоєння в змінну типу стрінг раніше введених елементів
            string[] arrStr = s.Split(' ');  
            /* створення списку з елементами типу стрінг з введеними в обєкті s 
             * з сплітом у виді пробіла arrStr= ['12', '23', '235']
            */
            int[] arrInt = new int[arrStr.Length]; //створення обєкта список типу int з довжиною arrString
            for (int i = 0; i < arrInt.Length; i++)// для і, що =0 і менше за довжину списка
            {
                arrInt[i] = Convert.ToInt32(arrStr[i]); // додаємо елементи у список arrInt
            }
            //arrInt= [12, 23, 235] на виході
            int sum = 0; //вводимо обєкт суми що =0
            foreach (var item in arrInt) 
             /*для кожного елемента типу вар в списку arrInt 
              * var неявно заданий тип, в ході компіляції прога сама обирає тип для вара 
             */
            {
                sum += item; // додаються елементи до суми
            }
            Console.WriteLine($"sum={sum}");// вивід суми на екран
        }
    }
}
