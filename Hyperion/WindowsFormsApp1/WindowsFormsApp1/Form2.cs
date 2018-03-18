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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        public string conString = "Data Source=LAPTOP-7R77VS94\\SQLEXPRESS;Initial Catalog=HyperionPhones;Integrated Security=True";
        private SqlConnection con;
        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection(conString);
            con.Open();
            
        }

        private void next_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string query = "select distinct Make from products where quantity_available>0";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read()==true)
            {
                comboBox1.Items.Add(rd[0]);
            }
            rd.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string query = "select model from products where make='" + comboBox1.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read() == true)
            {
                comboBox2.Items.Add(rd[0]);
            }
            rd.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

            string query = "select Quantity_Available from products where make='" + comboBox2.Text + "' and model='" + comboBox1.Text + "'";
            //string query = "select Quantity_Available from products where make = 'iPhone' and Model = '6' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            if (textBox1.Text != rd[0].ToString()) {
                MessageBox.Show("thanks!!");
            }
            rd.Close();
        }
    }
}
