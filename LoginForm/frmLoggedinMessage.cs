using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class frmLoggedinMessage : Form
    {
        public frmLoggedinMessage()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin objfrmLogin = new frmLogin();
            this.Hide();
            objfrmLogin.Show();
        }
    }
}
