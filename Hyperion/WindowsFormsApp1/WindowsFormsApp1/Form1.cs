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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            Form a = new Form2();
            a.Show();
        }

        private void Return_Click(object sender, EventArgs e)
        {

        }
    }
}
