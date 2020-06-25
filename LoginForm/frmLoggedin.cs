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
    public partial class frmLoggedin : Form
    {
        public frmLoggedin(string strUsername)
        {
            InitializeComponent();
            labelWelcome.Text = "Welcome " + strUsername + " !";
        }

        
        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch_Click(sender,e);
            }
        }
       

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string street = textboxStreet.Text;
            string city = textboxCity.Text;
            string state = textboxState.Text;
            string zipcode = textboxZipCode.Text;
            StringBuilder address= new StringBuilder();

            try
            {
                StringBuilder queryData = new StringBuilder();
                queryData.Append("http://maps.google.com/maps?q=");

                if (street != string.Empty)
                {
                    queryData.Append(street + "," + "+");
                    address.Append(street + ",");
                }
                if (city != string.Empty)
                {
                    queryData.Append(city + "," + "+");
                    address.Append(city + ",");
                }
                if (state != string.Empty)
                {
                    queryData.Append(state + "," + "+");
                    address.Append(state + ",");
                }
                if (zipcode != string.Empty)
                {
                    queryData.Append(zipcode + "," + "+");
                    address.Append(zipcode);
                }

                webBrowser1.Navigate(queryData.ToString());
                listBoxHistory.Items.Add(address);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }     
       
        private void buttonAddFavorites_Click(object sender, EventArgs e)
        {
            string street = textboxStreet.Text;
            string city = textboxCity.Text;
            string state = textboxState.Text;
            string zipcode = textboxZipCode.Text;
            StringBuilder address = new StringBuilder();

            try
            {
                if (street != string.Empty)
                {
                    
                    address.Append(street + ",");
                }
                if (city != string.Empty)
                {
                    address.Append(city + ",");
                }
                if (state != string.Empty)
                {
                    address.Append(state + ",");
                }
                if (zipcode != string.Empty)
                {
                    address.Append(zipcode);
                }

                listBoxFavorites.Items.Add(address);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            frmLogin objfrmLogin = new frmLogin();
            this.Close();
            objfrmLogin.Show();
        }

    }
    
}
