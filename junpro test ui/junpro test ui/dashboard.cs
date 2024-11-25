using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static junpro_test_ui.Program;

namespace junpro_test_ui
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            requestList form4 = new requestList();
            form4.Show();
            this.Close();
        }

        private void productPemberi_Click(object sender, EventArgs e)
        {
            productPemberi form9 = new productPemberi();
            form9.Show();
            this.Close();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btngeneralSetting_Click(object sender, EventArgs e)
        {
            ViewgeneralSetting settingsForm = new ViewgeneralSetting(Program.UserSession.LoggedInUsername);
            settingsForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            requestList form15 = new requestList();
            form15.Show();
            this.Close();
        }
    }
}
