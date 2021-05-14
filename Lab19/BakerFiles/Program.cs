using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Baker> baker = new List<Baker>();

            Baker bk1 = new Baker("Skyhold", "Tevinter", 5, "Necromancer");
            Baker bk2 = new Baker("Kaer Morhen", "Northern kingdom", 3, "witcher");
            Baker bk3 = new Baker("Korea", "Killing Stalking", 1, "serial killer");

            baker.Add(bk1);
            baker.Add(bk2);
            baker.Add(bk3);


            string FileName1;
            Console.Write("Enter file name: ");
            FileName1 = Console.ReadLine();

            FileStream FS = new FileStream(FileName1, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(FS, bk1);
            FS.Close();

            FileStream FS1 = new FileStream(FileName1, FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryFormatter bf1 = new BinaryFormatter();
            bk1 = (Baker)bf.Deserialize(FS);

            FS1.Close();

        }
    }
}
