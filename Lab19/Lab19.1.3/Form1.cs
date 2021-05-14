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

namespace Lab19._1._3
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
            for(int i = 0; i < (int)numericUpDown1.Value; i++)
            {
                Data1[i, 0].Value = rand.Next(-50, 50);
            }
        }

        private void majorityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int countPositive = 0;
            int countNegative = 0;
            for (int i = 0; i < (int)numericUpDown1.Value; i++)
            {
                if ((int)Data1[i, 0].Value > 0)
                {
                    countPositive++;
                }
                if ((int)Data1[i, 0].Value < 0)
                {
                    countNegative++;
                }
            }
            if (countNegative < countPositive)
            {
                Answer.Text = "Positives";
            }
            else if (countPositive < countNegative)
            {
                Answer.Text = "Negatives";
            }
            else
            {
                Answer.Text = "Equal";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine((int)numericUpDown1.Value);
                for (int i = 0; i < (int)numericUpDown1.Value; i++)
                {
                    sw.WriteLine(Data1[i, 0].Value);
                }
                sw.Close();
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(saveFileDialog1.FileName);
                numericUpDown1.Value = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < (int)numericUpDown1.Value; i++)
                {
                    Data1[i, 0].Value = sr.ReadLine();
                }
                sr.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data1.ColumnCount = (int)numericUpDown1.Value;
            Data1.RowCount = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Data1.ColumnCount = (int)numericUpDown1.Value;
        }
    }
}
