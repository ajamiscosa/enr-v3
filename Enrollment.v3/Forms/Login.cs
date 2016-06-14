using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Enrollment.Classes;
using Enrollment.Models;

namespace Enrollment.Forms
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoadEvent(object sender, EventArgs e)
        {
            this.ActiveControl = btnLogin;
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void LoginAction(object sender, EventArgs e)
        {
            User user = new User(txtPassword.Text, txtPassword.Text);
            Session s = user.Login();
            if(s!=null)
            {
                new Main().Show();
                this.Hide();
            }
            else
            {
                txtUsername.Clear();
                txtPassword.Clear();
                lblStatus.Text = "Login failed. Please try again.";
            }
        }

        private void ClearAction(object sender, EventArgs e)
        {

        }
    }
}
