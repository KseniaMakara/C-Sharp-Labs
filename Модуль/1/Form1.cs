using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for(int i = 0; i < (int)numericUpDown1.Value; i++)
            {
                dataGridView1[i, 0].Value = rand.Next(-100, 100);
            }
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

        private void arifmeticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int s = 0;
            for (int i = 0; i < (int)numericUpDown1.Value; i++)
            {
                s +=(int)dataGridView1[i, 0].Value/(int)numericUpDown1.Value;
            }
            A.Text = s.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                numericUpDown1.Value = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    dataGridView1[i, 0].Value = sr.ReadLine();
                }
                A.Text = sr.ReadLine();
                G.Text = sr.ReadLine();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine((int)numericUpDown1.Value);
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    sw.WriteLine(dataGridView1[i, 0].Value);
                }
                sw.WriteLine(A.Text);
                sw.WriteLine(G.Text);
                sw.Close();
            }
        }

        private void geomenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double g = 1;
            for (int i = 0; i < (int)numericUpDown1.Value; i++)
            {
                g *= Convert.ToDouble(dataGridView1[i, 0].Value);
            }
            double Geom = Math.Pow(g, Convert.ToDouble(1 / numericUpDown1.Value));
            G.Text = Convert.ToString(Geom);
        }
    }
}
