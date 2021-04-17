using System;
using System.Collections.Generic;
using System.Text;

namespace Класи12_2_
{
    class Man
    {
        public string name;
        public string gender;
        private int age_;

        public int Get_age()
        {
            return age_;
        }
        public void Set_age(int age)
        {
            if (age > 0) age_ = age;
        }
        public Man()
        {
            this.name = name;
            this.gender = gender;
            this.age_ = age_;
        }
        public Man(string name, string gender, int age)
        {
            name = "Levi Ackerman";
            gender = "Male";
            age = 34;
        }
        public void Print(string name, string gender, int age_)
        {
            Console.WriteLine($"Name = {name}, Gender = {gender}, age = {age_} ");
        }
        public void Zodiac(int month)
        {
            switch(month)
            {
                case 1:
                    Console.WriteLine("Capricorn");
                    break;
                case 2:
                    Console.WriteLine("Aquarius");
                    break;
                case 3:
                    Console.WriteLine("Pisces");
                    break;
                case 4:
                    Console.WriteLine("Aries");
                    break;
                case 5:
                    Console.WriteLine("Taurus");
                    break;
                case 6:
                    Console.WriteLine("Gemini");
                    break;
                case 7:
                    Console.WriteLine("Cancer");
                    break;
                case 8:
                    Console.WriteLine("Leo");
                    break;
                case 9:
                    Console.WriteLine("Virgo");
                    break;
                case 10:
                    Console.WriteLine("Libra");
                    break;
                case 11:
                    Console.WriteLine("Scorpio");
                    break;
                case 12:
                    Console.WriteLine("Saggitarius");
                    break;
            }
        }
            public void Aging(int age_)
        {
            if (age_ > 0 && age_ < 13)
                Console.WriteLine("Baby boy");
            else if (age_ >= 13 && age_ < 18)
                Console.WriteLine("Teenager");
            else if (age_ >= 18 && age_<=25)
            Console.WriteLine("Chanwoo OH");
            Console.WriteLine("Myung-Dae KIM");
        }
    }
}
