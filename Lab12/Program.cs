using System;

namespace Класи12_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Man m = new Man("Erwin Smith","male", 30);
            m.Set_age(30);
            m.Print("Erwin Smith", "male", 30);
            m.Zodiac(4);
            m.Aging(30);
            Console.Read();
        }
    }
}
