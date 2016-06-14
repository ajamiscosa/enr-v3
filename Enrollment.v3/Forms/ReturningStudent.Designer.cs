namespace Enrollment.Forms
{
    partial class ReturningStudent
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
            this.w8 = new Telerik.WinControls.Themes.Windows8Theme();
            this.o13 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.separator1 = new SwingWERX.Controls.Separator();
            this.btnContinue = new Telerik.WinControls.UI.RadButton();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContinue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBox1
            // 
            this.radTextBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 10.25F);
            this.radTextBox1.Location = new System.Drawing.Point(12, 28);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.PasswordChar = '●';
            this.radTextBox1.Size = new System.Drawing.Size(268, 24);
            this.radTextBox1.TabIndex = 42;
            this.radTextBox1.ThemeName = "Windows8";
            this.radTextBox1.UseSystemPasswordChar = true;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.radTextBox1.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.radTextBox1.GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            // 
            // separator1
            // 
            this.separator1.BackColor = System.Drawing.SystemColors.Window;
            this.separator1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.separator1.Location = new System.Drawing.Point(12, 9);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(268, 16);
            this.separator1.TabIndex = 43;
            this.separator1.Text = "Student Number";
            // 
            // btnContinue
            // 
            this.btnContinue.AllowShowFocusCues = false;
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.btnContinue.Location = new System.Drawing.Point(12, 67);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(268, 30);
            this.btnContinue.TabIndex = 45;
            this.btnContinue.Text = "Continue";
            this.btnContinue.ThemeName = "Office2013Light";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(12, 58);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(268, 4);
            this.radSeparator1.TabIndex = 46;
            this.radSeparator1.Text = "radSeparator1";
            this.radSeparator1.ThemeName = "Office2013Light";
            // 
            // ReturningStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 110);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.separator1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 12.5F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturningStudent";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Returning Student";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContinue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Windows8Theme w8;
        private Telerik.WinControls.Themes.Office2013LightTheme o13;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private SwingWERX.Controls.Separator separator1;
        private Telerik.WinControls.UI.RadButton btnContinue;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
    }
}
