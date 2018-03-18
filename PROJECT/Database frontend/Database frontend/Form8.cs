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
    public partial class Form8 : Form
    {
        public string conString = "Data Source=LAPTOP-7R77VS94\\SQLEXPRESS;Initial Catalog=HyperionPhones;Integrated Security=True";
        private SqlConnection con;
        string cus_name;
        public Form8(string cus_name)
        {
            InitializeComponent();
            con = new SqlConnection(conString);
            con.Open();
            this.cus_name = cus_name;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            groupBox2.Enabled = false;
            groupBox1.Enabled = false;
            checkBox1.Checked = true;

            string query = "select max(OrdersID) from Orders";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                int a = (int)rd[0];
                textBox1.Text = (a + 1).ToString();
            }
            rd.Close();
            textBox3.Text = cus_name;
            DateTime today = DateTime.Now;
            textBox4.Text = DateTime.Now.ToShortDateString();
            textBox4.Text = today.ToShortDateString();
            DateTime answer = today.AddDays(3);
            textBox5.Text = answer.ToShortDateString();

            textBox6.Text = textBox3.Text;
            query = "select * from Customer where [Name]='"+ cus_name +"'";
            cmd = new SqlCommand(query, con);
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                textBox7.Text = rd[2].ToString();
                textBox8.Text = rd[4].ToString();
                textBox9.Text = rd[5].ToString();
                textBox10.Text = rd[7].ToString();
            }
            rd.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = !checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string query = "select max(OrdersID) from Orders";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                int a = (int)rd[0];
                textBox1.Text = (a + 1).ToString();
            }
            rd.Close();

            query= "update [Orders] set Customer_CustomerID = (select CustomerID from Customer where[Name] = @n), Order_Date = GETDATE() ,Ship_Name = @na ,Ship_Address = @add,Ship_City = @cit ,Ship_Postal_Code = @pos ,Ship_Country = @cou,Expected_Date = @expd where Customer_CustomerID = ((select CustomerIDfrom Customer where[Name] = @n))";
            cmd.Parameters.AddWithValue("@add", textBox7.Text);
            cmd.Parameters.AddWithValue("@cit", textBox8.Text);
            cmd.Parameters.AddWithValue("@pos", textBox9.Text);
            cmd.Parameters.AddWithValue("@cou", textBox10.Text);
            cmd.Parameters.AddWithValue("@expd", textBox5.Text);

            cmd.ExecuteReader();

            MessageBox.Show("order recieved");
            this.Close();

        }
    }
}
