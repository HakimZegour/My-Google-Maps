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

namespace LoginForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-KADB5C7P\SQLSERVER2019;Initial Catalog=userLogin;Integrated Security=True");
            string query = "select * from logins where username = '" + usernameTextBox.Text.Trim() + "' and password='" + passwordTextBox.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count==1)
            {
                frmLoggedin objfrmLoggedin = new frmLoggedin(usernameTextBox.Text);
                objfrmLoggedin.Show();
                this.Hide();
                


            }
            else
            {
                MessageBox.Show("Please check your username and password");
            }
        }

    }
}
