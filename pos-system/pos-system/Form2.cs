using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_system
{
    public partial class Form2 : Form
    {
        string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=POSsystem;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            string hashedPassword = HashPassword(password);

            SqlConnection con = new SqlConnection(conStr);
            con.Open();

          
            string checkUser = "SELECT COUNT(*) FROM Users WHERE Username=@u";
            SqlCommand cmd1 = new SqlCommand(checkUser, con);
            cmd1.Parameters.AddWithValue("@u", username);

            int userExists = (int)cmd1.ExecuteScalar();

            if (userExists == 0)
            {
                MessageBox.Show("User not found! Please register first.");
                con.Close();
                return;
            }

            
            string checkPass = "SELECT COUNT(*) FROM Users WHERE Username=@u AND Password=@p";
            SqlCommand cmd2 = new SqlCommand(checkPass, con);
            cmd2.Parameters.AddWithValue("@u", username);
            cmd2.Parameters.AddWithValue("@p", hashedPassword);

            int valid = (int)cmd2.ExecuteScalar();

            if (valid == 1)
            {
                MessageBox.Show("Login Successful!");

                
                Form3 dashboard = new Form3();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password!");
            }

            con.Close();
        }

        private void reglogbtn_Click(object sender, EventArgs e)
        {
            Form1 reg = new Form1();
            reg.Show();
            this.Hide();
        }
    }
}
