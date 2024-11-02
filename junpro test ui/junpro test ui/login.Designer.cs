namespace junpro_test_ui
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            button1 = new Button();
            button2 = new Button();
            tbemail = new TextBox();
            tbpassword = new TextBox();
            create_account = new Button();
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
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(663, 955);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(227, 65);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1031, 957);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(235, 63);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tbemail
            // 
            tbemail.BackColor = Color.FromArgb(255, 192, 192);
            tbemail.BorderStyle = BorderStyle.None;
            tbemail.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbemail.Location = new Point(644, 590);
            tbemail.Margin = new Padding(4);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(642, 41);
            tbemail.TabIndex = 3;
            // 
            // tbpassword
            // 
            tbpassword.BackColor = Color.FromArgb(241, 244, 249);
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbpassword.Location = new Point(644, 765);
            tbpassword.Margin = new Padding(4);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(642, 41);
            tbpassword.TabIndex = 4;
            // 
            // create_account
            // 
            create_account.Location = new Point(776, 824);
            create_account.Name = "create_account";
            create_account.Size = new Size(150, 46);
            create_account.TabIndex = 5;
            create_account.Text = "Create Account";
            create_account.UseVisualStyleBackColor = true;
            create_account.Click += create_account_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1439, 1073);
            Controls.Add(create_account);
            Controls.Add(tbpassword);
            Controls.Add(tbemail);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox tbemail;
        private TextBox tbpassword;
        private Button create_account;
    }
}