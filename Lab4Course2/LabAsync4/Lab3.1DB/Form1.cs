using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3._1DB
{
    public partial class Form1 : Form
    {
        List<Table> stud = new List<Table>();

        public Form1()
        {

            InitializeComponent();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {

            using (UniversityContext un = new UniversityContext())
            {
                List<Table> stud = un.Table.ToList<Table>();
                dataGridView1.DataSource = stud;
            }

        }
      
        private async void buttonClear_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Columns.Clear();

            using (UniversityContext un = new UniversityContext())
            { 
                dataGridView1.DataSource = await Task
                    .Run(()=> un.Table
                    .ToList<Table>()
                    .Where((stud) => stud.course == numCourse.Value)
                    .ToList<Table>());
            }
            
            
        }
       
        private async void maxRate_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            using (UniversityContext un = new UniversityContext())
            {
                dataGridView1.DataSource = await Task
                    .Run(()=> un.Table
                    .ToList<Table>()
                    .Where((stud) => stud.name.ToLower().Contains(textFilterName.Text.ToLower()))
                    .ToList<Table>());
            }
        }
       
        private async void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            using (UniversityContext un = new UniversityContext())
            {
                dataGridView1.DataSource = await Task

                .Run(()=> un.Table
                .ToList<Table>().OrderBy(stud => stud.rate)
                .Skip(1)
                .ToList<Table>());
            }
        }
        
        private async void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            using (UniversityContext un = new UniversityContext())
            {
                dataGridView1.DataSource = await Task
                    .Run(()=> un.Table
                    .ToList<Table>().ForEach(stud => stud.rate += 12));
            }
        }
       
        private async void MaxValueRate_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            using (UniversityContext un = new UniversityContext())
            {
                dataGridView1.DataSource = await Task
                   .Run(()=> un.Table
                   .ToList<Table>().OrderByDescending(stud => stud.rate)
                   .Take(1)
                   .ToList<Table>());
            }
        }
       
        private async void countStud_Click(object sender, EventArgs e)
        {
            using (UniversityContext un = new UniversityContext())
            {
                MessageBox.Show($"All students: { await Task.Run( () => un.Table.ToList<Table>().Count(stud => stud.course == numCourse.Value))}");
            }
        }

        private async void buttonIF_Click(object sender, EventArgs e)
        {
            using (UniversityContext un = new UniversityContext())
            {
                MessageBox.Show($"Student were rate>60: {  await Task.Run( () => un.Table.ToList<Table>().Count((stud) => stud.rate>60))}");
            }
        }
    }
}
