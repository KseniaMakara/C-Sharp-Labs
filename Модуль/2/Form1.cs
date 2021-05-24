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

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)numericUpDown1.Value;
            dataGridView1.ColumnCount = (int)numericUpDown2.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
        }

        private void sumToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void sumToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                for (int j = 0; j < numericUpDown1.Value; j++)
                {
                    dataGridView1[i, j].Value = rand.Next(-100, 100);
                }
            }
        }

        private void summaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double s = 0;
            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                for (int j = 0; j < numericUpDown1.Value; j++)
                {
                    if (i == j)
                    {
                        s+= Convert.ToDouble(dataGridView1[i, j].Value);

                    }
                }
            }
            label2.Text = s.ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream FS = new FileStream(textBox1.Text, FileMode.Create);
                BinaryWriter BW = new BinaryWriter(FS);
                for (int i = 0; i < numericUpDown2.Value; i++)
                {
                    for (int j = 0; j < numericUpDown1.Value; j++)
                    {
                        BW.Write(Convert.ToInt32(dataGridView1[i, j].Value));
                    }
                }
                BW.Close();
                FS.Close();
                
            }
            
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream FS = new FileStream(textBox1.Text, FileMode.Open);
                BinaryReader BR = new BinaryReader(FS);
                for (int i = 0; i < numericUpDown2.Value; i++)
                {
                    for (int j = 0; j < numericUpDown1.Value; j++)
                    {
                        dataGridView1[i, j].Value = BR.ReadInt32();
                    }
                }
                BR.Close();
                FS.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
