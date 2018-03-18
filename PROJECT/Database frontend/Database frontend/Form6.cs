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
    public partial class Form6 : Form
    {

        public string conString = "Data Source=LAPTOP-7R77VS94\\SQLEXPRESS;Initial Catalog=HyperionPhones;Integrated Security=True";
        private SqlConnection con;

        public Form6()
        {
            InitializeComponent();
            con = new SqlConnection(conString);
            con.Open();

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Form_Activated(sender, e);
            string query = "select distinct Make from products where quantity_available>0";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd[0]);
            }
            rd.Close();

            string oid = "";
            query = "select max(ordersID) from Orders";
            cmd = new SqlCommand(query, con);
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                int a = (int)rd[0];
                oid = (a + 1).ToString();
            }
            rd.Close();

            string cus = "";
            query = "select max(CustomerID) from Customer";
            cmd = new SqlCommand(query, con);
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                int a = (int)rd[0];
                cus = (a + 1).ToString();
            }
            rd.Close();

            query = "insert into Orders( OrderID,CustomerID) values ( @a,@b )";

            cmd = new SqlCommand(query, con);

            //cmd.Parameters.AddWithValue("@ordersid", ordersid);
            cmd.Parameters.AddWithValue("@a", oid);
            cmd.Parameters.AddWithValue("@b", cus);
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string query = "select model from products where make='" + comboBox1.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                comboBox2.Items.Add(rd[0]);
            }
            rd.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form_Deactivate(sender, e);
            this.Owner.Show();
            this.Close();
            //this.MdiParent.Show();

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

        private void add_Click(object sender, EventArgs e)
        {


            string query = "select Quantity_Available from products where make='" + comboBox1.Text + "' and model='" + comboBox2.Text + "'";
            //string query = "select Quantity_Available from products where make = 'iPhone' and Model = '6' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();


            if (rd.Read())
            {
                if ((int)rd[0] < Convert.ToInt32(textBox1.Text))
                {
                    MessageBox.Show("not enough phones available");
                }
                else
                {
                    if (comboBox1.Text != "" && comboBox2.Text != "" && textBox1.Text != "")
                    {
                        listBox1.Items.Add(comboBox1.Text + " " + comboBox2.Text + " " + textBox1.Text);
                    }
                }

            }
            rd.Close();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                string ordersid= "";
                string productid="";
                string unitprice="";
                string orderdetailid="";
                string query = "select max(OrdersID) from Orders";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    int a = (int)rd[0];
                    ordersid = (a).ToString();
                }
                rd.Close();

                
                query = "select max(productID) from Products";
                cmd = new SqlCommand(query, con);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    int a = (int)rd[0];
                    productid = (a).ToString();
                }
                rd.Close();

                query = "select unitPrice from Products where Make='"+ comboBox1.Text + "' and Model='"+ comboBox2.Text + "'";
                cmd = new SqlCommand(query, con);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                        unitprice=rd[0].ToString();
                    
                }
                rd.Close();

                query = "select top(1) Order_DetailsID from Order_Details order by Order_DetailsID desc";
                cmd = new SqlCommand(query, con);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    int a = (int)rd[0];
                    
                    orderdetailid = (a + 1).ToString();  /////////////
                    

                }
                rd.Close();

                query = "insert into Order_Details( Orders_OrdersID, Products_ProductID, UnitPrice, Quantity, Order_DetailsID) values (@ordersid,  @productID , @unitprice ,@something , @orderdetailid )";
            
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

Form f = new Form7();
                //this.Hide();
                f.Show(this);
            }
            else
            {
                MessageBox.Show("please buy something.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
