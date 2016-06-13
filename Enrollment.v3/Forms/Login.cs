using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

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
            new Main().Show();
            this.Hide();
        }

        private void ClearAction(object sender, EventArgs e)
        {

        }
    }
}
