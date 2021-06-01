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


namespace BinaryFiles
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream FS = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(FS);
                for (int i = 0; i < numericUpDown2.Value; i++)
                {
                    for (int j = 0; j < numericUpDown1.Value; j++)
                    {
                        bw.Write(Convert.ToInt32(dataGridView1[i, j].Value));
                    }
                }
                bw.Close();
                FS.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream FS = new FileStream(openFileDialog1.FileName, FileMode.Open);
                BinaryReader br = new BinaryReader(FS);
                for (int i = 0; i < numericUpDown2.Value; i++)
                {
                    for (int j = 0; j < numericUpDown1.Value; j++)
                    {
                        dataGridView1[i, j].Value = br.ReadInt32();
                    }
                }
                br.Close();
                FS.Close();
            }
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

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                for (int j = 0; j < numericUpDown1.Value; j++)
                {
                    if ((int)dataGridView1[i, j].Value < 0)
                    {
                        dataGridView1[i, j].Value = 0;
                    }
                }
            }
        }

        private void minimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int minimal = (int)dataGridView1[0, 0].Value;
            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                for (int j = 0; j < numericUpDown1.Value; j++)
                {
                    if ((int)dataGridView1[i, j].Value <= minimal)
                    {
                        minimal = Convert.ToInt32(dataGridView1[i, j].Value);
                    }

                }
            }
            label2.Text = Convert.ToString(minimal);
        }
    }
}
