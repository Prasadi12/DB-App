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
    public partial class Production : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Production()
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
            string query = $"insert into production values('{textid.Text.ToString()}','{textclientid.Text}','{textproductiontype.Text}','{textday.Text}')";
            ExecuteQuery(query);
            MessageBox.Show("Add production successful!");
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
            string query = "select * from production";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid.DataSource = dt;
            conn.Close();
        }

        private void cleardata()
        {
            textid.Clear();
            textclientid.Clear();
            textproductiontype.Clear();
            textday.Clear();
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
            string query = "select * from production where productionID='" + textsearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid.DataSource = dt;
            conn.Close();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            string query = "update production set clientID=@clientID, productionType=@ptype, noOfDays=@day where productionID=@productionID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@clientID", textclientid.Text);
            cmd.Parameters.AddWithValue("@ptype", textproductiontype.Text);
            cmd.Parameters.AddWithValue("@day", textday.Text);
            cmd.Parameters.AddWithValue("@productionID", textid.Text);
            ExecuteQuery2(cmd);
            MessageBox.Show("Update production successful!");
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
            string query = $"delete from production where productionID='{textid.Text}'";
            ExecuteQuery(query);
            MessageBox.Show("Delete production successful!");
            cleardata();
            displaydata();
        }

    }
}
