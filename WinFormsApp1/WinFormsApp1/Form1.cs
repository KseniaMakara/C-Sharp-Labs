using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clear();
        }
        private void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            Salary.Value = 0;
            Children.Value = 0;
            xp.Value = 0;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Add(EmployeesAddList emp)
        {
            ListViewItem lvi = new ListViewItem(emp.name);
            lvi.Tag = emp;
            listE.Items.Add(lvi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
            Employees emps = DeserializeXML();
            foreach (EmployeesAddList emp in emps.empList)
            {
                Add(emp);
            }
        }
        private Employees DeserializeXML()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Employees));
            using (FileStream fs = new FileStream("Emp.xml", FileMode.OpenOrCreate))
            {
                return (Employees)xml.Deserialize(fs);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listE.SelectedItems.Count == 1)
            {
                EmployeesAddList emp = (EmployeesAddList)listE.SelectedItems[0].Tag;
                if (emp != null)
                {
                    textBox1.Text = emp.name;
                    textBox2.Text = emp.position;
                    Salary.Value = emp.salary;
                    Children.Value = emp.children;
                    xp.Value = emp.xp;

                }
            }
            else if(listE.SelectedItems.Count == 0)
            {
                Clear();

            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            EmployeesAddList emp = new EmployeesAddList (textBox1.Text, textBox2.Text, Convert.ToInt32(Salary.Value), Convert.ToInt32(Children.Value), Convert.ToInt32(xp.Value));
            Add(emp);
            Clear();
        }
        private void SerializeXML(Employees emps)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Employees));
            using (FileStream fs = new FileStream("Emp.xml",FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, emps);
            }
        }
       
        private void serializeE_Click(object sender, EventArgs e)
        {
            Employees emps = new Employees(); 

            foreach(ListViewItem item in listE.Items)
            {
                if(item.Tag != null)
                {
                    emps.empList.Add((EmployeesAddList)item.Tag);
                  
                }
            }
            SerializeXML(emps);
        }
    }
}
