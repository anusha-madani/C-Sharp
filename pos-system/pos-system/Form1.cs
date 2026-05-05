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
using System.Security.Cryptography;
using System.Text;

namespace pos_system

{
    public partial class Form1 : Form
    {

        string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=POSsystem;Integrated Security=True";
        public Form1()
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

        private void regbtn_Click(object sender, EventArgs e)
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

            string query = "INSERT INTO Users (Username, Password) VALUES (@u, @p)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", hashedPassword);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Registration Successful!");

           
            Form2 login = new Form2();
            login.Show();

            this.Hide();

        }
    }
}
