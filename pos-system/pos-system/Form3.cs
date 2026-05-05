using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_system
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void proitem_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbProducts.Text) || string.IsNullOrEmpty(txtprice.Text) || string.IsNullOrEmpty(txtqty.Text))
            {
                MessageBox.Show("Please fill all fields first!");
                return;
            }

            // Grid mein data add karna (image_f61732.jpg wale style mein)
            dataGridView1.Rows.Add(cmbProducts.Text, txtprice.Text, txtqty.Text);

            // Inputs clear karna taakay user mazeed products add kar sakay
            cmbProducts.SelectedIndex = -1;
            txtprice.Clear();
            txtqty.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (dataGridView1.ColumnCount == 0)
            {
                dataGridView1.Columns.Add("ProductName", "Product Name");
                dataGridView1.Columns.Add("Price", "Price");
                dataGridView1.Columns.Add("Quantity", "Quantity");
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            cmbProducts.SelectedIndex = -1;
            txtprice.Clear();
            txtqty.Clear();
            dataGridView1.Rows.Clear();
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0 || (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow))
            {
                MessageBox.Show("Pehle products list mein add karein!");
                return;
            }

            string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=POSsystem;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();

                  
                    
                    SqlCommand clearCmd = new SqlCommand("DELETE FROM ProductDetails", con);
                    clearCmd.ExecuteNonQuery();
                    

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string sql = "INSERT INTO ProductDetails (ProductName, Price, Quantity) VALUES (@name, @price, @qty)";
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("@name", row.Cells[0].Value ?? "");
                                cmd.Parameters.AddWithValue("@price", row.Cells[1].Value ?? 0);
                                cmd.Parameters.AddWithValue("@qty", row.Cells[2].Value ?? 0);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    
                    Form4 cartPage = new Form4();
                    cartPage.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btndone_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(cmbProducts.Text) ||
                string.IsNullOrWhiteSpace(txtprice.Text) ||
                string.IsNullOrWhiteSpace(txtqty.Text))
            {
                MessageBox.Show("Please fill Product, Price, and Quantity first!");
                return;
            }

            
            
            dataGridView1.Rows.Add(cmbProducts.Text, txtprice.Text, txtqty.Text);

            
            cmbProducts.SelectedIndex = -1;
            txtprice.Clear();
            txtqty.Clear();

            MessageBox.Show("Product added to list!");
        }
    }
}
