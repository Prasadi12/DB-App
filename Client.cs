using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Home
{
    public partial class Client : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public Client()
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

        private void buttonadd_Click(object sender, EventArgs e)
        {
            string query = $"insert into client values('{txtid.Text.ToString()}','{txtname.Text}','{txtphone.Text}','{textBox4.Text}')";
            ExecuteQuery(query);
            MessageBox.Show("Add client successful!");
            cleardata();
            displaydata();
        }

        private void ExecuteQuery(string query)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void displaydata()
        {
            conn.Open();
            string query = "select * from client";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void cleardata()
        {
            txtid.Clear();
            txtname.Clear();
            txtphone.Clear();
            textBox4.Clear();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void buttonview_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void buttonfind_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from client where clientID='" + textBox5.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            string query = "update client set name=@name, phoneNo=@phoneNo, email=@email where clientID=@clientID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@phoneNo", txtphone.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@clientID", txtid.Text);
            ExecuteQuery2(cmd);
            MessageBox.Show("Update client successful!");
            cleardata();
            displaydata();
        }

        private void ExecuteQuery2(SqlCommand cmd)
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            string query = $"delete from client where clientID='{txtid.Text}'";
            ExecuteQuery(query);
            MessageBox.Show("Delete client successful!");
            cleardata();
            displaydata();
        }
    }
}
