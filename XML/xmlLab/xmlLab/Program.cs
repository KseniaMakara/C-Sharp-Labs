using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
namespace xmlLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Emoloyee e1 = new Emoloyee("Freddie Mercury", "singer", 16000, 0, 30);
            Emoloyee e2 = new Emoloyee("Michael Jackson", "singer", 20000, 1, 30);
            Emoloyee e3 = new Emoloyee("Paul McCartney", "singer", 12000, 2, 50);
            Emoloyee e4 = new Emoloyee("Axl Rose", "singer", 6000, 0, 40);
            Emoloyee e5 = new Emoloyee("Stella", "fairy", 60000, 0, 12);
            Emoloyee[] emps = new Emoloyee[] { e1, e2, e3, e4, e5 };

            XmlSerializer formatter = new XmlSerializer(typeof(Emoloyee[]));

            using (FileStream fs = new FileStream("staff.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, emps);
            }

            using (FileStream fs = new FileStream("staff.xml", FileMode.OpenOrCreate))
            {
                Emoloyee[] newEmployee = (Emoloyee[])formatter.Deserialize(fs);

                foreach (Emoloyee e in newEmployee)
                {
                    Console.WriteLine($"Name: {e.Name} --- Position: {e.Position} --- Salary: {e.Salary} --- Children: {e.Children} --- Experience: {e.Xp}");
                }
            }
            Console.ReadLine();
        }

    }
}
