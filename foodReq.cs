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
    public partial class foodReq : Form
    {
        public foodReq()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Request request = new Request(tbrcname.Text, tbqty.Text);
            if (request.SentRequest(request.Receiver, request.Quantities))
            { MessageBox.Show("Request has been sent!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
