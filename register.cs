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
            Account account = new Account(tbusername.Text, tbpassword.Text, tbemail.Text, tbnomortelephone.Text, tblocation.Text);
            if (account.Register(account.RegisterName, account.Password, account.Email, account.NomorTelephone, account.Location))
            {
                login form2 = new login();
                dashboard form3 = new dashboard();
                this.Hide();
                form2.Show();
                form3.FormClosed += (s, args) => this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void tbemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
