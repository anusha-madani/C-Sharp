using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace pos_system
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            FetchCartData();
        }

        private void FetchCartData()
        {
            string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=POSsystem;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    
                    string query = "SELECT ProductName, Price, Quantity FROM ProductDetails";

                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                   
                    dgvCart.DataSource = dt;

                   
                    decimal totalBill = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                       
                        decimal price = Convert.ToDecimal(row["Price"]);
                        int qty = Convert.ToInt32(row["Quantity"]);
                        totalBill += (price * qty);
                    }

                    lbltotalamount.Text = "Total Amount: " + totalBill.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void CalculateGrandTotal(DataTable dt)
        {
            
            decimal grandTotal = 0;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                
                if (!row.IsNewRow && row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
              
                    decimal price = Convert.ToDecimal(row.Cells[1].Value);
                    int qty = Convert.ToInt32(row.Cells[2].Value);

                    grandTotal += (price * qty);
                }
            }

          
            lbltotalamount.Text = "Total Amount: " + grandTotal.ToString();
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            string amountToSend = lbltotalamount.Text.Replace("Total Amount: ", "");

           
            Form5 donePage = new Form5(amountToSend);
            donePage.Show();
            this.Hide();
        }
    }
}
