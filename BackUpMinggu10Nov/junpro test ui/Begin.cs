﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace junpro_test_ui
{
    public partial class Begin : Form
    {
        public Begin()
        {
            InitializeComponent();
        }

        private void Begin_Load(object sender, EventArgs e)
        {

        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            register registerForm = new register();
            registerForm.Show();
            this.Hide();
        }
    }
}
