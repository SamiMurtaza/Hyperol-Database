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
    public partial class Form1 : Form
    {
        public string constring = "Data Source=LAPTOP-7R77VS94\\SQLEXPRESS;Initial Catalog=HyperionPhones;Integrated Security=True";
        private SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(constring);
            con.Open();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Products_gb.Enabled = false;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Product.Items.Clear();
            Quantity.Clear();
            Products_lb.Items.Clear();
            Description.Clear();
            string query = "select p.Make + ' ' + p.model from products p, order_details od, orders o where o.ordersID =" + OrderID.Text.ToString() + "and o.ordersID = od.orders_ordersID and od.products_productID = p.productID";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read() == true)
            {
                Product.Items.Add(rd[0]);
            }
            rd.Close();
            if (Product.Items.ToString() != null)
            {
                Quantity.Enabled = false;
                Return_Replace.Enabled = false;
                Products_gb.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid Order ID");
            }
            
        }

        private void Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string query = "select od.quantity from products p, order_details od, orders o where o.ordersID = 1 and o.ordersID = od.orders_ordersID and od.products_productID = p.productID and od.products_productID in ( select p.productID where p.Make + ' ' + p.model ='" + Product.Text.ToString() + "' )";
            //SqlCommand cmd = new SqlCommand(query, con);
            //SqlDataReader rd = cmd.ExecuteReader();
            //while (rd.Read() == true)
            //{
            //    int a = 1;
            //    for (a = 1; a < Convert.ToInt32(rd[0]); a++)
            //    {
            //        Quantity.Items.Add(a);
            //    }
            //    Quantity.Items.Add(rd[0]);
            //}
            //rd.Close();
            Return_Replace.Enabled = true;
            Quantity.Enabled = true;
        }
        

        private void Add_Click(object sender, EventArgs e)
        {
            if (Product.Text == "" || Quantity.Text == "" || Return_Replace.Text == "")
            {
                if (Product.Text == "")
                {
                    MessageBox.Show("Please select a product.");
                }
                if (Quantity.Text == "")
                {
                    MessageBox.Show("Please select a Quantity.");
                }
                else
                {
                    MessageBox.Show("Please select an option from Return/Replace.");
                }
            }
            else
            {
                string query = "select od.quantity from products p, order_details od, orders o where o.ordersID = '"+ OrderID.Text.ToString() +"' and o.ordersID = od.orders_ordersID and od.products_productID = p.productID and od.products_productID in ( select p.productID where p.Make + ' ' + p.model ='" + Product.Text.ToString() + "' )";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read() == true)
                {
                    if (Int32.Parse(Quantity.Text) <= Convert.ToInt32(rd[0]) && Int32.Parse(Quantity.Text) > 0)
                    {
                        Products_lb.Items.Add(Product.Text + " (" + Quantity.Text + ") [" + Return_Replace.Text + "]");
                        Product.Items.Remove(Product.SelectedItem);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Quantity");
                    }
                }
                rd.Close();                          
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Products_lb.Items.Remove(Products_lb.SelectedItem);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Products_lb.Items.Clear();
        }

        private void Back_Click(object sender, EventArgs e)
        {
                     
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (Products_lb.Items.Count>0)
            {                
                for (int i=0; i<Products_lb.Items.Count; i++)
                {
                    string prod = "";
                    string qty = "";
                    string ret_rep = "";
                    int brackat = -1;
                    Products_lb.SelectedIndex = i;
                    for (int j=0; j < Products_lb.SelectedIndex.ToString().Length; j++)
                    {   
                        if (Products_lb.SelectedIndex.ToString()[j] == '(')
                        {
                            brackat = j;
                            while (Products_lb.SelectedIndex.ToString()[j] != ' ')
                            {
                                j++;
                                qty += Products_lb.SelectedIndex.ToString()[j];
                            }                            
                        }
                        else if (Products_lb.SelectedIndex.ToString()[j] == '[')
                        {                            
                            while (Products_lb.SelectedIndex.ToString().Length > j )
                            {
                                ret_rep += Products_lb.SelectedIndex.ToString()[j];
                                j++;
                            }

                        }
                        for (int k=0; k< brackat-1; k++)
                        {
                            prod += Products_lb.SelectedIndex.ToString()[k];
                        }
                    }
                    string query1 = "select od.Order_DetailsID from Orders o, Products p, Order_Details od where o.OrdersID = od.Orders_OrdersID and p.ProductID = od.Products_ProductID and o.OrdersID = '"+ OrderID.Text.ToString() +"' and p.Make + ' ' + p.Model = '" + prod + "'";
                    string query2 = "";
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    SqlDataReader rd1 = cmd1.ExecuteReader();
                    while (rd1.Read() == true)
                    {
                        query2 = "insert into [return] (returnID,Order_Details_Order_DetailsID, Return_Date, Quantity, reason) values (2,"+ rd1[0] + ", GETDATE(), "+ qty + ", '" + ret_rep + ' ' + Description.Text.ToString() + "')";
                    }
                    rd1.Close();
                    //SqlCommand cmd2 = new SqlCommand();
                    //cmd2.CommandType = System.Data.CommandType.Text;
                    //cmd2.CommandText = query2;
                    //cmd2.Connection = con;
                    //cmd2.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Accepted.");
                }
            }
            MessageBox.Show("Your return / replacement is filed!\nOur customer service representative will get in\ntouch with you soon.\nYour return ID is:");
        }

        private void Products_gb_Enter(object sender, EventArgs e)
        {

        }
    }
}
