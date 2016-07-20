namespace Enrollment.Forms
{
    partial class Payment
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
            this.o13L = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.w8 = new Telerik.WinControls.Themes.Windows8Theme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnComplete = new Telerik.WinControls.UI.RadButton();
            this.lblChange = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTendered = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSchoolYear = new System.Windows.Forms.Label();
            this.lblYrSection = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTendered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.BackgroundImage = global::Enrollment.Properties.Resources.watermark;
            this.radPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radPanel1.Controls.Add(this.btnComplete);
            this.radPanel1.Controls.Add(this.lblChange);
            this.radPanel1.Controls.Add(this.label16);
            this.radPanel1.Controls.Add(this.txtTendered);
            this.radPanel1.Controls.Add(this.label15);
            this.radPanel1.Controls.Add(this.label14);
            this.radPanel1.Controls.Add(this.lblTotal);
            this.radPanel1.Controls.Add(this.lblAmountDue);
            this.radPanel1.Controls.Add(this.label11);
            this.radPanel1.Controls.Add(this.lblDescription);
            this.radPanel1.Controls.Add(this.label9);
            this.radPanel1.Controls.Add(this.lblSchoolYear);
            this.radPanel1.Controls.Add(this.lblYrSection);
            this.radPanel1.Controls.Add(this.lblStudentID);
            this.radPanel1.Controls.Add(this.lblName);
            this.radPanel1.Controls.Add(this.lblDate);
            this.radPanel1.Controls.Add(this.label2);
            this.radPanel1.Controls.Add(this.lblOR);
            this.radPanel1.Controls.Add(this.label1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(451, 477);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.ThemeName = "Windows8";
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.SystemColors.Window;
            this.btnComplete.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.btnComplete.Location = new System.Drawing.Point(12, 433);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(427, 30);
            this.btnComplete.TabIndex = 40;
            this.btnComplete.Text = "Complete";
            this.btnComplete.ThemeName = "Office2013Light";
            // 
            // lblChange
            // 
            this.lblChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChange.BackColor = System.Drawing.Color.Transparent;
            this.lblChange.Font = new System.Drawing.Font("Courier New", 11F);
            this.lblChange.Location = new System.Drawing.Point(299, 368);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(137, 14);
            this.lblChange.TabIndex = 39;
            this.lblChange.Text = "2,000.00";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Courier New", 11F);
            this.label16.Location = new System.Drawing.Point(12, 367);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 16);
            this.label16.TabIndex = 38;
            this.label16.Text = "Change";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTendered
            // 
            this.txtTendered.BackColor = System.Drawing.Color.Transparent;
            this.txtTendered.Culture = new System.Globalization.CultureInfo("en-PH");
            this.txtTendered.Font = new System.Drawing.Font("Courier New", 11F);
            this.txtTendered.Location = new System.Drawing.Point(301, 343);
            this.txtTendered.Mask = "C2";
            this.txtTendered.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtTendered.Name = "txtTendered";
            this.txtTendered.Size = new System.Drawing.Size(135, 22);
            this.txtTendered.TabIndex = 37;
            this.txtTendered.TabStop = false;
            this.txtTendered.Text = "Php0.00";
            this.txtTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTendered.ThemeName = "Windows8";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Courier New", 11F);
            this.label15.Location = new System.Drawing.Point(12, 346);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 16);
            this.label15.TabIndex = 36;
            this.label15.Text = "Cash Tendered";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Courier New", 11F);
            this.label14.Location = new System.Drawing.Point(156, 313);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 14);
            this.label14.TabIndex = 35;
            this.label14.Text = "Total";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Courier New", 11F);
            this.lblTotal.Location = new System.Drawing.Point(299, 313);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(137, 14);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "2,000.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmountDue.BackColor = System.Drawing.Color.Transparent;
            this.lblAmountDue.Font = new System.Drawing.Font("Courier New", 11F);
            this.lblAmountDue.Location = new System.Drawing.Point(299, 195);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(137, 14);
            this.lblAmountDue.TabIndex = 33;
            this.lblAmountDue.Text = "2,000.00";
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Courier New", 11F);
            this.label11.Location = new System.Drawing.Point(299, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 14);
            this.label11.TabIndex = 32;
            this.label11.Text = "AMOUNT";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Courier New", 11F);
            this.lblDescription.Location = new System.Drawing.Point(12, 194);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(287, 16);
            this.lblDescription.TabIndex = 31;
            this.lblDescription.Text = "Downpayment";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Courier New", 11F);
            this.label9.Location = new System.Drawing.Point(9, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 14);
            this.label9.TabIndex = 30;
            this.label9.Text = "PAYMENT FOR";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSchoolYear
            // 
            this.lblSchoolYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSchoolYear.BackColor = System.Drawing.Color.Transparent;
            this.lblSchoolYear.Font = new System.Drawing.Font("Courier New", 11F);
            this.lblSchoolYear.Location = new System.Drawing.Point(299, 122);
            this.lblSchoolYear.Name = "lblSchoolYear";
            this.lblSchoolYear.Size = new System.Drawing.Size(137, 14);
            this.lblSchoolYear.TabIndex = 29;
            this.lblSchoolYear.Text = "SY 2015-2016";
            this.lblSchoolYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYrSection
            // 
            this.lblYrSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYrSection.BackColor = System.Drawing.Color.Transparent;
            this.lblYrSection.Font = new System.Drawing.Font("Courier New", 11F);
            this.lblYrSection.Location = new System.Drawing.Point(12, 122);
            this.lblYrSection.Name = "lblYrSection";
            this.lblYrSection.Size = new System.Drawing.Size(137, 14);
            this.lblYrSection.TabIndex = 28;
            this.lblYrSection.Text = "I-YELLOW";
            this.lblYrSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStudentID
            // 
            this.lblStudentID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentID.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentID.Font = new System.Drawing.Font("Courier New", 11F);
            this.lblStudentID.Location = new System.Drawing.Point(12, 105);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(137, 14);
            this.lblStudentID.TabIndex = 27;
            this.lblStudentID.Text = "2015-1000";
            this.lblStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Courier New", 11F);
            this.lblName.Location = new System.Drawing.Point(12, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(427, 14);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "DELA CRUZ, JUANITO VICTOR III";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Courier New", 11F);
            this.lblDate.Location = new System.Drawing.Point(9, 68);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(427, 20);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "April 5, 2016";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.25F);
            this.label2.Location = new System.Drawing.Point(295, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "No.";
            // 
            // lblOR
            // 
            this.lblOR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOR.AutoSize = true;
            this.lblOR.BackColor = System.Drawing.Color.Transparent;
            this.lblOR.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOR.Location = new System.Drawing.Point(345, 13);
            this.lblOR.Name = "lblOR";
            this.lblOR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOR.Size = new System.Drawing.Size(96, 27);
            this.lblOR.TabIndex = 24;
            this.lblOR.Text = "170010";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "OFFICIAL RECEIPT";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 477);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Payment";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowItemToolTips = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Payment";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTendered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2013LightTheme o13L;
        private Telerik.WinControls.Themes.Windows8Theme w8;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton btnComplete;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label16;
        private Telerik.WinControls.UI.RadMaskedEditBox txtTendered;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSchoolYear;
        private System.Windows.Forms.Label lblYrSection;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.Label label1;
    }
}
