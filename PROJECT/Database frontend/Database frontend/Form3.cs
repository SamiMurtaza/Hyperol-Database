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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form a = new Form2();
            a.Show();
            Visible = false;
        }

        private void Checkin_Click(object sender, EventArgs e)
        {
            Form a = new Form4();
            a.Show();
            Visible = false;
        }

        private void Inquiry_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.Show();

        }
    }
}
