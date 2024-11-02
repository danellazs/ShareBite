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
    public partial class buttonAcc : Form
    {
        public buttonAcc()
        {
            InitializeComponent();
        }

        private void buttonAcc_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Request has been sent!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    }
}