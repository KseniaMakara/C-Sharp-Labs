using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab19._3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HRD> listHRD = new List<HRD>();
            HRD person1 = new HRD("Oh Sangwoo ", "University of Corea", "serial killer", "top", "500 dollars per month");
            HRD person2 = new HRD("Dorian of house Pavus", "the Circle at Carastes", "love of my life", "top/bottom", "the welthiest man in this world");
            HRD person3 = new HRD("Victor of house Trevelyan", "Nobody knows", "Quizy", "top/bottom", " wealthy as fuck");
            HRD person4 = new HRD("Geralt of Rivia", "Caer Morhen", "Witcher", "top", " destitute as fuck");

            listHRD.Add(person1);
            listHRD.Add(person2);
            listHRD.Add(person3);
            listHRD.Add(person4);

            string path = @"C:\Files\files.dat";


            try
            {
                using (BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Create)))
                {
                    foreach (HRD r in listHRD)
                    {
                        bw.Write(r.ID);
                        bw.Write(r.education);
                        bw.Write(r.specialization);
                        bw.Write(r.posiion);
                        bw.Write(r.salary);


                    }

                }
                using (BinaryReader br = new BinaryReader(File.Open(path, FileMode.OpenOrCreate)))
                {
                    while (br.PeekChar() > -1)
                    {
                        string ID = br.ReadString();
                        string education = br.ReadString();
                        string specialization = br.ReadString();
                        string posiion = br.ReadString();
                        string salary = br.ReadString();

                        Console.WriteLine("ID: {0}, Education: {1}, Specialization: {2}, Position: {3}, Salary: {4}", ID, education, specialization, posiion, salary);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();

        }
    }
}

