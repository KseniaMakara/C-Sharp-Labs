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

namespace Lab19._1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void genereteDigitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < NumericMassive.Value; i++)
            {
                dataGridView1[i, 0].Value = rand.Next(-50, 25);

            }
        }

        private void resultConditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> array = new List<int>();
            for (int i = 0; i < NumericMassive.Value; i++)
            {
                if ((int)dataGridView1[i, 0].Value < 0)
                {
                    array.Add((int)dataGridView1[i, 0].Value);
                }
                int max = array[0];
                for(int j = 0; j < array.Count; j++)
                {
                    if (array[j] >= max)
                    {
                        max = array[j];
                    }
                }
                Result.Text = max.ToString();
            }
        }
                
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine((int)NumericMassive.Value);
                for (int i = 0; i < NumericMassive.Value; i++)
                {
                    sw.WriteLine(dataGridView1[i, 0].Value);
                }
                sw.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                NumericMassive.Value = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < NumericMassive.Value; i++)
                {
                    dataGridView1[i, 0].Value = Convert.ToInt32(sr.ReadLine());
                }
                sr.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = (int)NumericMassive.Value;
        }

        private void NumericMassive_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)NumericMassive.Value;
        }

    }
}
