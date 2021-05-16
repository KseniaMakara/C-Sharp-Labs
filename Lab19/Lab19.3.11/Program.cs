using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab19._3._11
{
    class Program
    {
        static void SaveToFile(string fileName, List<Inquisition> list)
        {
            FileStream FS = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(FS, list);
            FS.Close();

        }
        static List<Inquisition> OpenFromFile(string fileName)
        {
            FileStream FS1 = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<Inquisition> list = (List<Inquisition>)bf.Deserialize(FS1);
            FS1.Close();
            return list;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. Write\n2.Read");
            switch (Console.ReadLine()[0])
            {
                case '1':
                    List<Inquisition> list = new List<Inquisition>();
                    list.Add(new Inquisition("Cullen", "Warrior", "Templar", "Commander"));
                    list.Add(new Inquisition("Leliana", "Rogue", "Bard", "Spymaster"));
                    list.Add(new Inquisition("Josephina", "Rogue", "Bard", "Ambassador"));
                    list.Add(new Inquisition("Cassandra", "Warrior", "Templar", "Founder"));

                    SaveToFile("my.dat", list);
                    break;
                case '2':
                    List<Inquisition> list2 = OpenFromFile("my.dat");
                    foreach(var item in list2)
                    {
                        Console.WriteLine(item);
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
