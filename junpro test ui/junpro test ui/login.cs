using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace junpro_test_ui
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Giver giver = new Giver (tbemail.Text, tbpassword.Text);
            if (giver.LoginGiver(giver.Email, giver.Password))
            {
                dashboard form3 = new dashboard();
                form3.Show();
                this.Close();
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receiver receiver = new Receiver(tbemail.Text, tbpassword.Text);
            if (receiver.LoginReceiver(receiver.Email, receiver.Password))
            {
                product form7 = new product();
                form7.Show();
                this.Close();
            }
        }

        private void create_account_Click(object sender, EventArgs e)
        {
            register form2 = new register();

            // Menampilkan Form2
            form2.Show();

            // Menutup Form1 sepenuhnya
            this.Close();
        }
    }
}
