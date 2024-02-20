using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void buttonlink_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
            this.Hide();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void buttonproduction_Click(object sender, EventArgs e)
        {
            Production production = new Production();
            production.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Show();
            this.Hide();
        }

        private void buttonstaff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Hide();
        }

        private void buttonstafftype_Click(object sender, EventArgs e)
        {
            Stafftype stafftype = new Stafftype();
            stafftype.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Propertytype propertytype = new Propertytype();
            propertytype.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
