using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBase
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\DataBase\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connection);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlreader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Table]", sqlConnection);
            try
            {
                sqlreader = await command.ExecuteReaderAsync();//зчитування таблиці
                while(await sqlreader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlreader["id"]) + " " + Convert.ToString(sqlreader["name"]) + " " + Convert.ToString(sqlreader["position"]) + " " + Convert.ToString(sqlreader["salary"]) + " " + Convert.ToString(sqlreader["children"]) + " " + Convert.ToString(sqlreader["experience"]));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlreader != null)
                    sqlreader.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        
    }
}
