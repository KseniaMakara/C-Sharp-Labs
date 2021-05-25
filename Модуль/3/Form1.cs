using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace _3
{
    public partial class Form1 : Form
    {
        private List<Menu> Dishes { get; set; }
        public Form1()
        {
            Dishes = GetDish();
            InitializeComponent();
        }

        private List<Menu> GetDish()
        {
            var list = new List<Menu>();
            list.Add(new Menu()
            {
                dish = "Анна Павлова",
                measure = "303 гр",
                pricePerOne = "320 грн",
                nationality = "Франція"
            });
            list.Add(new Menu()
            {
                dish = "Борщ з пампушками",
                measure = "200 гр",
                pricePerOne = "95 грн",
                nationality = "Україна"
            });
            list.Add(new Menu()
            {
                dish = "Яблучний пиріг",
                measure = "30 см",
                pricePerOne = "65 грн",
                nationality = "Америка"
            });
            list.Add(new Menu()
            {
                dish = "Полента",
                measure = "150 гр",
                pricePerOne = "200 грн",
                nationality = "Італія"
            });

            return list;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream FS = new FileStream(textBox1.Text, FileMode.Create, FileAccess.Write, FileShare.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(FS, dataGridView1.DataSource);
                FS.Close();
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream FS1 = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read, FileShare.Read);
                BinaryFormatter bf = new BinaryFormatter();
                List<Menu> list = (List<Menu>)bf.Deserialize(FS1);
                FS1.Close();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            var dish = this.Dishes;
            dataGridView1.DataSource = dish;
        }


    }
}
