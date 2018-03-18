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
    public partial class Form7 : Form
    {
        public string conString = "Data Source=LAPTOP-7R77VS94\\SQLEXPRESS;Initial Catalog=HyperionPhones;Integrated Security=True";
        private SqlConnection con;

        public Form7()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
            con = new SqlConnection(conString);
            con.Open();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            groupBox1.Enabled = !groupBox1.Enabled;
            groupBox2.Enabled = !groupBox2.Enabled;


        }

        private void button3_Click(object sender, EventArgs e)
        {

            string query = "select count(*) from Customer where CustomerID = '" + textBox8.Text + "' and Name = '" + textBox9.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                if (rd[0].ToString() == "1")
                {
                    rd.Close();
                    string query2 = "select * from Customer where CustomerID = '" + textBox8.Text + "' and Name = '" + textBox9.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    SqlDataReader rd2 = cmd2.ExecuteReader();
                    if (rd2.Read())
                    {
                        textBox1.Text = rd2[1].ToString();
                        textBox2.Text = rd2[2].ToString();
                        textBox3.Text = rd2[3].ToString();
                        textBox4.Text = rd2[4].ToString();
                        textBox5.Text = rd2[5].ToString();
                        textBox6.Text = rd2[6].ToString();
                        textBox7.Text = rd2[7].ToString();

                    }
                    rd2.Close();
                }
                else
                {
                    MessageBox.Show("You are not a customer.");
                }
            }
            rd.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Deactivate(sender, e);
            this.Close();
            //Parent.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                if (!checkBox1.Checked) {

                    string ID = "";
                    string query2 = "select CustomerID from Customer where Name = '" + textBox1.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    SqlDataReader rd2 = cmd2.ExecuteReader();
                    if (rd2.Read())
                    {
                        ID = (string)rd2[0];

                    }
                    rd2.Close();


                    string query = "insert into Customer ([CustomerID],[Name], Email, Contact, Street, City, Postal_Code,Country)  Values (@Cid,@CName,@Cemail,@Cpho,@CStre,@CCity,@CPostal,@CCountry);";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Cid", ID);
                    cmd.Parameters.AddWithValue("@CName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Cemail", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Cpho", textBox3.Text);
                    cmd.Parameters.AddWithValue("@CStre", textBox4.Text);
                    cmd.Parameters.AddWithValue("@CCity", textBox5.Text);
                    cmd.Parameters.AddWithValue("@CPostal", textBox6.Text);
                    cmd.Parameters.AddWithValue("@CCountry", textBox7.Text);
                 


                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("successfull!");

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unsuccessfull!");
                    }
                }

               /* query = "insert into Order_Details(Orders_OrdersID, Products_ProductID, UnitPrice, Quantity, Order_DetailsID) values ( @ordersid  , @productID , @unitprice ,@something , @orderdetailid )";

                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ordersid", ordersid);
                cmd.Parameters.AddWithValue("@productID", productid);
                cmd.Parameters.AddWithValue("@unitprice", unitprice);
                cmd.Parameters.AddWithValue("@something", textBox1.Text);
                cmd.Parameters.AddWithValue("@orderdetailid", orderdetailid);



                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    MessageBox.Show("Unsuccessfull!");
                }

                */
                Form_Deactivate(sender, e);
                Form8 f4 = new Form8(textBox1.Text);
                f4.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("please fill all the details");
            }

        }

        private void Form_Activated(object sender, System.EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Enabled = false;
            }
        }

        private void Form_Deactivate(object sender, System.EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Enabled = true;

            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Form_Activated(sender, e);
        }
    }
}
