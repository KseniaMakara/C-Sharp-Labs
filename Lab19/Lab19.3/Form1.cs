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
using System.Runtime.Serialization.Formatters.Binary;


namespace Lab19._3
{
    public partial class Form1 : Form
    {
        private List<Characters> People { get; set; }
        public Form1()
        {
            textBox1.TextChanged += textBox1_TextChanged;

            People = GetCharacters();
            InitializeComponent();
        }
    private List<Characters> GetCharacters()
        {
            var list = new List<Characters>();
            list.Add(new Characters()
            {
                name = "Dorian Pavus",
                country = "Tevinter",
                game = "Dragon age Inquisition",
                loveInterest = " Inquisitor Trevelyan",
                bestFriend = "Mevaris"
            });
            list.Add(new Characters()
            {
                name = "Geralt of Rivia",
                country = "Temeria",
                game = "The Witcher",
                loveInterest = " Yennefer",
                bestFriend = "Dandelion"
            });
            list.Add(new Characters()
            {
                name = "Geralt of Rivia",
                country = "Temeria",
                game = "The Witcher",
                loveInterest = " Yennefer",
                bestFriend = "Dandelion"
            });
            list.Add(new Characters()
            {
                name = "Geralt of Rivia",
                country = "Temeria",
                game = "The Witcher",
                loveInterest = " Yennefer",
                bestFriend = "Dandelion"
            });

            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var people = this.People;
            dataGridView1.DataSource = people;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream FS = new FileStream(textBox1.Text, FileMode.Create, FileAccess.Write, FileShare.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(FS, dataGridView1.DataSource);
                FS.Close();
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream FS1 = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read, FileShare.Read);
                BinaryFormatter bf = new BinaryFormatter();
                List<Characters> list = (List<Characters>)bf.Deserialize(FS1);
                FS1.Close();
            }
        }
    }
}
