using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace xmlLab
{
    [Serializable]
    public class Emoloyee
    {

        public string Name { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public int Children { get; set; }
        public int Xp { get; set; }

        public Emoloyee(string name, string position, int salary, int children, int xp)
        {
            Name = name;
            Position =position;
            Salary = salary;
            Children = children;
            Xp = xp;
        }
        public Emoloyee()
        {

        }


    }
}
