using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab19._1._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateMassiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for(int i=0; i < (int)numericUpDown1.Value; i++)
            {
                dataGridView1[i, 0].Value = rand.Next(10, 506);
            }
        }

        private void deleteElementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double k, x, z, n=10;
            List<double> array = new List<double>();
            for (int i = 0; i < (int)numericUpDown1.Value; i++)
            {
                if (Convert.ToDouble(dataGridView1[i, 0].Value) % n != 0)
                {
                    for(int j=0; j < array.Count(); j++)
                    {
                        k = Convert.ToDouble(dataGridView1[i, 0].Value) / n;
                        z = Convert.ToDouble(dataGridView1[i, 0].Value) % n;
                        x = k - z / n;
                        array.Add(x);
                        n *= n;
                    }
                }
            }
            dataGridView2.ColumnCount = array.Count();
            dataGridView2.RowCount = 1;
            for (int i = 0; i < array.Count(); i++)
            {
                dataGridView2[i, 0].Value = array[i];
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
            dataGridView1.RowCount = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
        }
    }
}
