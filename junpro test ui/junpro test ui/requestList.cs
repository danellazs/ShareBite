using System;
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
    public partial class requestList : Form
    {
        public requestList()
        {
            InitializeComponent();

            // Set button properties to make it transparent
            button1.FlatStyle = FlatStyle.Flat;         // Set flat style
            button1.FlatAppearance.BorderSize = 0;      // Remove button border
            button1.BackColor = Color.Transparent;      // Set background color to transparent
            button1.ForeColor = Color.Black;            // Optional: Set text color
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonAcc form5 = new buttonAcc();
            form5.Show();
            this.Close();
        }
    }
}