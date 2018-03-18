using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_frontend
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=LAPTOP-7R77VS94\\SQLEXPRESS;Initial Catalog=HyperionPhones;Integrated Security=True";

        private void Login_Click(object sender, EventArgs e)
        {
            if (ID.Text == "admin" && Password.Text == "admin")
            {
                Form a = new Form3();
                a.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid ID and password combination");
                ID.Clear();
                Password.Clear();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
