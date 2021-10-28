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

namespace Lab3._2DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //1
        private void Form1_Load(object sender, EventArgs e)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Lab3.2DB\Lab3.2DB\Univer.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand getAll = new SqlCommand(
                "SELECT name, faculty, course, rate FROM University",
                con
                );
            SqlDataAdapter adapt = new SqlDataAdapter(getAll);
            DataTable dt = new DataTable();
            con.Open();
            adapt.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }
        //2(А)
        private void ex1_Click(object sender, EventArgs e)
        {
            int course = Convert.ToInt32(numericUpDown1.Value);
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Lab3.2DB\Lab3.2DB\Univer.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand getAll = new SqlCommand(
                "SELECT * FROM University WHERE Course = @Course",
                con
                );
            getAll.Parameters.AddWithValue("Course", course);
            SqlDataAdapter adapt = new SqlDataAdapter(getAll);
            DataTable dt = new DataTable();
            con.Open();
            adapt.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        //2(Б)
        private void ex2_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Lab3.2DB\Lab3.2DB\Univer.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand getAll = new SqlCommand(
                "SELECT max(rate)  FROM University",
                con
                );
            SqlDataAdapter adapt = new SqlDataAdapter(getAll);
            DataTable dt = new DataTable();
            con.Open();
            adapt.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }
        //2(B)
        private void ex3_Click(object sender, EventArgs e)
        {
            string faculty = textBox1.Text;
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Lab3.2DB\Lab3.2DB\Univer.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand getAll = new SqlCommand(
                "SELECT count(id) FROM University WHERE faculty = @faculty",
                con
                );
            getAll.Parameters.AddWithValue("Faculty", faculty);
            SqlDataAdapter adapt = new SqlDataAdapter(getAll);
            DataTable dt = new DataTable();
            con.Open();
            adapt.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        //3
        private void exIncrease_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Lab3.2DB\Lab3.2DB\Univer.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand getAll = new SqlCommand(
                "SELECT name, faculty, course, rate+12  FROM University",
                con
                );
            SqlDataAdapter adapt = new SqlDataAdapter(getAll);
            DataTable dt = new DataTable();
            con.Open();
            adapt.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }
        //4
        private void exDel_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Lab3.2DB\Lab3.2DB\Univer.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand ChangeList = new SqlCommand(
                "WITH MyBD AS (" +
                "SELECT TOP(1) * FROM University ORDER BY rate)" +
                "DELETE FROM MyBD",
                con
                );
            SqlCommand getList = new SqlCommand(
              "SELECT * FROM University ",
              con
              );
            SqlDataAdapter adaptGet = new SqlDataAdapter(getList);
            ChangeList.ExecuteNonQuery();
            adaptGet.Fill(dt);
            con.Close();
        }
        //5
        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Lab3.2DB\Lab3.2DB\Univer.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand getAll = new SqlCommand(
                "SELECT rate FROM University WHERE rate = ANY " +
                "(SELECT rate FROM University WHERE rate > 60)",
                con);
        
            SqlDataAdapter adapt = new SqlDataAdapter(getAll);
            DataTable dt = new DataTable();
            con.Open();
            adapt.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
            
        }

        private void all_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Lab3.2DB\Lab3.2DB\Univer.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand getAll = new SqlCommand(
                "SELECT rate FROM University WHERE rate = ALL " +
                "(SELECT rate FROM University WHERE rate > 60)",
                con);
            SqlDataAdapter adapt = new SqlDataAdapter(getAll);
            DataTable dt = new DataTable();
            con.Open();
            adapt.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }
    }
}
