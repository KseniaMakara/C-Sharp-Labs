using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab19._2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void масивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for(int i = 0; i < numericUpDown1.Value; i++)
            {
                dataGridView1[i, 0].Value = rand.Next(-100, 100);

            }
        }

        private void серАрифметичнеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double s = 0;
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                s += (int)dataGridView1[i, 0].Value;
            }
            s = s /(double)numericUpDown1.Value;
            Result.Text = s.ToString();
        }

        private void зберегиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(Result);
                sw.WriteLine((int)numericUpDown1.Value);
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    sw.WriteLine(dataGridView1[i, 0].Value);
                }
                sw.Close();
            }
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                Result.Text = sr.ReadLine();
                numericUpDown1.Value = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    dataGridView1[i, 0].Value = Convert.ToInt32(sr.ReadLine());
                }
                sr.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
            dataGridView1.RowCount = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int) numericUpDown1.Value;
        }
    }
}
