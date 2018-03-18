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

namespace Database_frontend
{
    public partial class Form9 : Form
    {
        public string conString = "Data Source=LAPTOP-7R77VS94\\SQLEXPRESS;Initial Catalog=HyperionPhones;Integrated Security=True";
        private SqlConnection con;

        public Form9()
        {
            InitializeComponent();
            con = new SqlConnection(conString);
            con.Open();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from Customer";
            SqlDataAdapter sqlda = new SqlDataAdapter(query, conString);
            DataTable det = new DataTable();
            sqlda.Fill(det);
            dataGridView1.DataSource = det;
            groupBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            string query = "select * from Orders";
            SqlDataAdapter sqlda = new SqlDataAdapter(query, conString);
            DataTable det = new DataTable();
            sqlda.Fill(det);
            dataGridView1.DataSource = det;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "select * from Order_Details";
            SqlDataAdapter sqlda = new SqlDataAdapter(query, conString);
            DataTable det = new DataTable();
            sqlda.Fill(det);
            dataGridView1.DataSource = det;
            groupBox1.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "select * from Products";
            SqlDataAdapter sqlda = new SqlDataAdapter(query, conString);
            DataTable det = new DataTable();
            sqlda.Fill(det);
            dataGridView1.DataSource = det;
            groupBox1.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "select * from Purchased";
            SqlDataAdapter sqlda = new SqlDataAdapter(query, conString);
            DataTable det = new DataTable();
            sqlda.Fill(det);
            dataGridView1.DataSource = det;
            groupBox1.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "select * from Supplier";
            SqlDataAdapter sqlda = new SqlDataAdapter(query, conString);
            DataTable det = new DataTable();
            sqlda.Fill(det);
            dataGridView1.DataSource = det;
            groupBox1.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string query = "select * from Order_Details where Orders_OrdersID ='" + textBox1.Text +"'";
            SqlDataAdapter sqlda = new SqlDataAdapter(query, conString);
            DataTable det = new DataTable();
            sqlda.Fill(det);
            dataGridView1.DataSource = det;
            groupBox1.Enabled = false;
        }
    }
}
