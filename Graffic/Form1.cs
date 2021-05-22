using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graffic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.chart1.Series[0].Points.Clear();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            double xMin = (double)numericUpDown1.Value;
            
            for (int i=0; i < (int)numericUpDown2.Value; i++)
            {
                double y = Math.Sin(xMin);
                chart1.Series[0].Points.AddXY(xMin, y);
                xMin += ((double)numericUpDown2.Value - (double)numericUpDown1.Value) / (double)numericUpDown3.Value;


            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
            double xMin = (double)numericUpDown1.Value;

            for (int i = 0; i < (int)numericUpDown2.Value; i++)
            {
                double y = Math.Cos(xMin);
                chart1.Series[1].Points.AddXY(xMin, y);
                xMin += ((double)numericUpDown2.Value - (double)numericUpDown1.Value) / (double)numericUpDown3.Value;


            }

        }
    }
}
