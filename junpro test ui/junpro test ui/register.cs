using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace junpro_test_ui
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account account = new Account(tbusername.Text, tbpassword.Text, tbemail.Text, tbnomortelephone.Text);
            if (account.Register(account.RegisterName, account.Password, account.Email, account.NomorTelephone))
            {
                login form2 = new login();
                dashboard form3 = new dashboard();
                this.Hide();
                form2.Show();
                form3.FormClosed += (s, args) => this.Close();

            }

        }
    }
}
