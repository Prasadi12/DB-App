using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Home
{
    public partial class Location : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Location()
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
            string query = $"insert into location values('{textid.Text.ToString()}','{textname.Text}','{textaddress.Text}')";
            ExecuteQuery1(query);
            MessageBox.Show("Add location successful!");
            cleardata();
            displaydata();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            string query = "update location set name=@name, address=@address where locationID=@locationID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", textname.Text);
            cmd.Parameters.AddWithValue("@address", textaddress.Text);
            cmd.Parameters.AddWithValue("@locationID", textid.Text);
            ExecuteQuery2(cmd);
            MessageBox.Show("Update location successful!");
            cleardata();
            displaydata();

        }

        private void ExecuteQuery2(SqlCommand cmd)
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void ExecuteQuery1(string query)
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void displaydata()
        {
            conn.Open();
            string query = "select * from location";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid.DataSource = dt;
            conn.Close();
        }

        private void cleardata()
        {
            textid.Clear();
            textname.Clear();
            textaddress.Clear();
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

        private void buttondelete_Click(object sender, EventArgs e)
        {
            string query = $"delete from location where locationID='{textid.Text}'";
            ExecuteQuery1(query);
            MessageBox.Show("Delete location successful!");
            cleardata();
            displaydata();
        }

        private void buttonfind_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from location where locationID='" + textsearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid.DataSource = dt;
            conn.Close();
        }
    }
}
