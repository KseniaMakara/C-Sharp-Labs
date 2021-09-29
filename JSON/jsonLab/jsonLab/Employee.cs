using System;
using System.Collections.Generic;
using System.Text;

namespace jsonLab
{
   public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public int Children { get; set; }
        public int Xp { get; set; }

        public Employee(string name, string position, int salary, int children, int xp)
        {
            Name = name;
            Position = position;
            Salary = salary;
            Children = children;
            Xp = xp;
        }
        public Employee()
        {

        }
    }
}
