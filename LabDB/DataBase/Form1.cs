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

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void position_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void salary_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void children_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void xp_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
           
            //SqlCommand command = new SqlCommand("INSERT INTO [Table](Name, Position, Salary, Children, Experience)VALUES(@name, @position, @salary, @children, @experience)", sqlConnection);
            //command.Parameters.AddWithValue("Name", name.Text);
            //command.Parameters.AddWithValue("Position", position.Text);
            //command.Parameters.AddWithValue("Salary", salary.Text);
            //command.Parameters.AddWithValue("Children", children.Text);
            //command.Parameters.AddWithValue("Experience", xp.Text);
            //await command.ExecuteNonQueryAsync();

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

        private async void updateToInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            //SqlDataReader sqlreader = null;
            //SqlCommand command = new SqlCommand("SELECT * FROM [Table]", sqlConnection);
            //try
            //{
            //    sqlreader = await command.ExecuteReaderAsync();
            //    while (await sqlreader.ReadAsync())
            //    {
            //        listBox1.Items.Add(Convert.ToString(sqlreader["id"]) + " " + Convert.ToString(sqlreader["name"]) + " " + Convert.ToString(sqlreader["position"]) + " " + Convert.ToString(sqlreader["salary"]) + " " + Convert.ToString(sqlreader["children"]) + " " + Convert.ToString(sqlreader["experience"]));
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    if (sqlreader != null)
            //        sqlreader.Close();
            //}
        }
    }
}
