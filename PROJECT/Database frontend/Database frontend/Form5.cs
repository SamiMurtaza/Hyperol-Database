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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Checkout_Click(object sender, EventArgs e)
        {           
            Form a = new Form6();
            //a.MdiParent = this;
            //this.Hide();

            a.Show(this);

        }

        private void Return_Click(object sender, EventArgs e)
        {
            Form a = new Form1();
            a.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Form a = new Form2();
            a.Show();
        }
    }
}
