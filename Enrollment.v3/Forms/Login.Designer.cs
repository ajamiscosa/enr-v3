namespace Enrollment.Forms
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.o13L = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.txtUsername = new Telerik.WinControls.UI.RadTextBox();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.btnLogin = new Telerik.WinControls.UI.RadButton();
            this.btnClear = new Telerik.WinControls.UI.RadButton();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.w8 = new Telerik.WinControls.Themes.Windows8Theme();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.txtUsername.Location = new System.Drawing.Point(12, 179);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.NullText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(268, 30);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.ThemeName = "Windows8";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.txtPassword.Location = new System.Drawing.Point(12, 217);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NullText = "Password";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(268, 30);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.ThemeName = "Windows8";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.btnLogin.Location = new System.Drawing.Point(12, 255);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(268, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.ThemeName = "Office2013Light";
            this.btnLogin.Click += new System.EventHandler(this.LoginAction);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.btnClear.Location = new System.Drawing.Point(12, 291);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(268, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.ThemeName = "Office2013Light";
            this.btnClear.Click += new System.EventHandler(this.ClearAction);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblStatus});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 326);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(292, 29);
            this.radStatusStrip1.TabIndex = 4;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "Windows8";
            ((Telerik.WinControls.UI.RadStatusBarElement)(this.radStatusStrip1.GetChildAt(0))).Text = "radStatusStrip1";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radStatusStrip1.GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.SystemColors.Window;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStatus.Name = "lblStatus";
            this.radStatusStrip1.SetSpring(this.lblStatus, false);
            this.lblStatus.Text = "Ready...";
            this.lblStatus.TextWrap = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Enrollment.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(64, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 355);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 12.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.LoadEvent);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2013LightTheme o13L;
        private Telerik.WinControls.UI.RadTextBox txtUsername;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadButton btnLogin;
        private Telerik.WinControls.UI.RadButton btnClear;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.Themes.Windows8Theme w8;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
