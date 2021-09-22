using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    [Serializable]
   public class Employees
    {
        public List<EmployeesAddList> empList { get; set; } = new List<EmployeesAddList>();
    }
    [Serializable]

    public class EmployeesAddList
    {
        public string name { get; set; }
        public string position { get; set; }
        public int salary { get; set; }
        public int children { get; set; }
        public int xp { get; set; }
        public EmployeesAddList() { }

        public EmployeesAddList(string name, string position, int salary, int children, int xp)
        {
            this.name = name;
            this.position = position;
            this.salary = salary;
            this.children = children;
            this.name = name;

        }
    }
}
