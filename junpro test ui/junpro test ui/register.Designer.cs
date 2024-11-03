namespace junpro_test_ui
{
    partial class register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            button1 = new Button();
            tbemail = new TextBox();
            tbnomortelephone = new TextBox();
            tbusername = new TextBox();
            tbpassword = new TextBox();
            rbpemberi = new RadioButton();
            rbpenerima = new RadioButton();
            login = new Button();
            role = new GroupBox();
            role.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(507, 839);
            button1.Name = "button1";
            button1.Size = new Size(428, 51);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // tbemail
            // 
            tbemail.BackColor = Color.FromArgb(241, 244, 249);
            tbemail.BorderStyle = BorderStyle.None;
            tbemail.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbemail.Location = new Point(471, 237);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(494, 41);
            tbemail.TabIndex = 1;
            // 
            // tbnomortelephone
            // 
            tbnomortelephone.BackColor = Color.FromArgb(241, 244, 249);
            tbnomortelephone.BorderStyle = BorderStyle.None;
            tbnomortelephone.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnomortelephone.Location = new Point(471, 364);
            tbnomortelephone.Name = "tbnomortelephone";
            tbnomortelephone.Size = new Size(494, 41);
            tbnomortelephone.TabIndex = 2;
            // 
            // tbusername
            // 
            tbusername.BackColor = Color.FromArgb(241, 244, 249);
            tbusername.BorderStyle = BorderStyle.None;
            tbusername.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbusername.Location = new Point(471, 587);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(494, 41);
            tbusername.TabIndex = 4;
            // 
            // tbpassword
            // 
            tbpassword.BackColor = Color.FromArgb(241, 244, 249);
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbpassword.Location = new Point(471, 710);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(494, 41);
            tbpassword.TabIndex = 5;
            tbpassword.UseSystemPasswordChar = true;
            // 
            // rbpemberi
            // 
            rbpemberi.BackColor = Color.Transparent;
            rbpemberi.Location = new Point(36, 9);
            rbpemberi.Name = "rbpemberi";
            rbpemberi.Size = new Size(220, 40);
            rbpemberi.TabIndex = 6;
            rbpemberi.TabStop = true;
            rbpemberi.UseVisualStyleBackColor = false;
            rbpemberi.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbpenerima
            // 
            rbpenerima.BackColor = Color.Transparent;
            rbpenerima.Location = new Point(327, 9);
            rbpenerima.Name = "rbpenerima";
            rbpenerima.Size = new Size(220, 40);
            rbpenerima.TabIndex = 7;
            rbpenerima.TabStop = true;
            rbpenerima.UseVisualStyleBackColor = false;
            rbpenerima.CheckedChanged += rbpenerima_CheckedChanged;
            // 
            // login
            // 
            login.BackColor = Color.Transparent;
            login.FlatAppearance.BorderSize = 0;
            login.FlatAppearance.MouseDownBackColor = Color.Transparent;
            login.FlatAppearance.MouseOverBackColor = Color.Transparent;
            login.FlatStyle = FlatStyle.Flat;
            login.ForeColor = Color.Transparent;
            login.Location = new Point(803, 915);
            login.Name = "login";
            login.Size = new Size(66, 37);
            login.TabIndex = 8;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // role
            // 
            role.BackColor = Color.Transparent;
            role.Controls.Add(rbpemberi);
            role.Controls.Add(rbpenerima);
            role.Location = new Point(459, 462);
            role.Name = "role";
            role.Size = new Size(596, 49);
            role.TabIndex = 9;
            role.TabStop = false;
            role.Enter += groupBox1_Enter;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1374, 1050);
            Controls.Add(role);
            Controls.Add(login);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Controls.Add(tbnomortelephone);
            Controls.Add(tbemail);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "register";
            Text = "Form1";
            role.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbemail;
        private TextBox tbnomortelephone;
        private TextBox tbusername;
        private TextBox tbpassword;
        private RadioButton rbpemberi;
        private RadioButton rbpenerima;
        private Button login;
        private GroupBox role;
    }
}
