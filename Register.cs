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
    public partial class Register : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Register()
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
            string query = $"insert into usertable values('{textid.Text.ToString()}','{textuname.Text}','{textpassword.Text}')";
            ExecuteQuery(query);
            MessageBox.Show("Register successful!");
            cleardata();
        }

        private void ExecuteQuery(string query)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void cleardata()
        {
            textid.Clear();
            textuname.Clear();
            textpassword.Clear();
        }
    }
}
