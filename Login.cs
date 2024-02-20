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
using static System.Net.Mime.MediaTypeNames;

namespace Home
{
    public partial class Login : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Login()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-9T8DMPI\SQLEXPRESS;Initial Catalog=filmdb;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            string username = textusername.Text;
            string password = textpassword.Text;

            // You should implement your own logic for checking credentials here
            bool isValidUser = AuthenticateUser(username, password);

            if (isValidUser)
            {
                MessageBox.Show("Login successful!");
                cleardata();
                // Optionally, you can open another form or perform other actions upon successful login
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM usertable WHERE username = @username AND password = @password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();

            // If count > 0, user with provided credentials exists in the database
            return count > 0;
        }

        private void cleardata()
        {
            textusername.Clear();
            textpassword.Clear();
        }
    }
}
