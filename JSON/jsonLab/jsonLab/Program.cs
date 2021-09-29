using System;
using System.Text.Json;
using Newtonsoft.Json; // Newton'S'oft.Json;
namespace jsonLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Freddie Mercury", "singer", 16000, 0, 30);
            Employee e2 = new Employee("Michael Jackson", "singer", 20000, 1, 30);
            Employee e3 = new Employee("Paul McCartney", "singer", 12000, 2, 50);
            Employee e4 = new Employee("Axl Rose", "singer", 6000, 0, 40);
            Employee e5 = new Employee("Stella", "fairy", 60000, 0, 12);
            Employee[] emps = new Employee[] { e1, e2, e3, e4, e5 };

            string json = JsonConvert.SerializeObject(emps, Formatting.Indented);
            Console.WriteLine(json);

            Employee empl = JsonConvert.DeserializeObject<Employee>(json);
            Console.WriteLine($"Name: {empl.Name} --- Position: {empl.Position} --- Salary: {empl.Salary} --- Children: {empl.Children} --- Experience: {empl.Xp}");
        }
    }
}
