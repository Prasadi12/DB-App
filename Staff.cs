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

namespace Home
{
    public partial class Staff : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Staff()
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

        private void buttonadd_Click(object sender, EventArgs e)
        {
            string query = $"insert into staff values('{textid.Text.ToString()}','{textstafftypeid.Text}','{textname.Text}','{textsalary.Text}')";
            ExecuteQuery(query);
            MessageBox.Show("Add staff successful!");
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
            string query = "select * from staff";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid.DataSource = dt;
            conn.Close();
        }

        private void cleardata()
        {
            textid.Clear();
            textstafftypeid.Clear();
            textname.Clear();
            textsalary.Clear();
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
            string query = "select * from staff where staffID='" + textsearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid.DataSource = dt;
            conn.Close();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            string query = "update staff set stafftypeID=@stafftypeID, name=@name, salary=@salary where staffID=@staffID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@stafftypeID", textstafftypeid.Text);
            cmd.Parameters.AddWithValue("@name", textname.Text);
            cmd.Parameters.AddWithValue("@salary", textsalary.Text);
            cmd.Parameters.AddWithValue("@staffID", textid.Text);
            ExecuteQuery2(cmd);
            MessageBox.Show("Edit staff successful!");
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
            string query = $"delete from staff where staffID='{textid.Text}'";
            ExecuteQuery(query);
            MessageBox.Show("Delete staff successful!");
            cleardata();
            displaydata();
        }
    }
}
