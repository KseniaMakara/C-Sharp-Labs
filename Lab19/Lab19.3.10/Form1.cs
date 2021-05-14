using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab19._3._10
{
    public partial class Form1 : Form
    {
        private List<LifeIsJoke> People { get; set; }
        public Form1()
        {
            People = GetPeople();
            textBox3.TextChanged += textBox3_TextChanged;
            InitializeComponent();
        }
        private List<LifeIsJoke> GetPeople()
        {
            var list = new List<LifeIsJoke>();
            list.Add(new LifeIsJoke()
            {
                surnameName = " Dorian of house Pavus",
                year = 1990,
                adress = "Inquisitors room",
                rate = "Amatus/Love of my life"
            }
            );
            list.Add(new LifeIsJoke()
            {
                surnameName = "Victor Trevelyan",
                year = 1995,
                adress = "Dorians ass",
                rate = "Beautiful ass"
            }
            );
            list.Add(new LifeIsJoke()
            {
                surnameName = "Sera",
                year = 2000,
                adress = "Tavern",
                rate = "Tadwinks"
            }
            );
            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var people = this.People;
            dataGridView1.DataSource = people;
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for(int i= 0; i<dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if(textBox1.Text == Convert.ToString(dataGridView1[i, j].Value))
                    {
                        
                        dataGridView2[i,0].Value = dataGridView1[i, j].Value;

                    }
                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e, List<LifeIsJoke> list )
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream FS = new FileStream(textBox3.Text, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(FS, list);
                FS.Close();

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(textBox3.Text, FileMode.Open, FileAccess.Read, FileShare.Read);
                BinaryFormatter bf = new BinaryFormatter();
                List<LifeIsJoke> list = (List<LifeIsJoke>)bf.Deserialize(fs);
                fs.Close();
            }
                
            
        }
    }
}
