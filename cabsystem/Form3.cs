﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cabsystem
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void reg1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Driverregistration f4 = new Driverregistration();
            f4.ShowDialog();
        }
    }
}
