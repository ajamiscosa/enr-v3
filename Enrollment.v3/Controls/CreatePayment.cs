﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment.Controls
{
    public partial class CreatePayment : UserControl
    {
        public CreatePayment()
        {
            InitializeComponent();
        }

        private void Proceed_Action(object sender, EventArgs e)
        {
            new Forms.Payment().ShowDialog();
        }
    }
}
