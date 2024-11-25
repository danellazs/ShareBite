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
            tblocation = new TextBox();
            tbusername = new TextBox();
            tbpassword = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(72, 128, 255);
            button1.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(505, 919);
            button1.Name = "button1";
            button1.Size = new Size(428, 65);
            button1.TabIndex = 0;
            button1.Text = "Sign  Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbemail
            // 
            tbemail.BackColor = Color.FromArgb(241, 244, 249);
            tbemail.BorderStyle = BorderStyle.None;
            tbemail.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbemail.Location = new Point(471, 171);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(494, 31);
            tbemail.TabIndex = 1;
            tbemail.TextChanged += tbemail_TextChanged;
            // 
            // tbnomortelephone
            // 
            tbnomortelephone.BackColor = Color.FromArgb(241, 244, 249);
            tbnomortelephone.BorderStyle = BorderStyle.None;
            tbnomortelephone.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnomortelephone.Location = new Point(471, 301);
            tbnomortelephone.Name = "tbnomortelephone";
            tbnomortelephone.Size = new Size(494, 31);
            tbnomortelephone.TabIndex = 2;
            // 
            // tblocation
            // 
            tblocation.BackColor = Color.FromArgb(241, 244, 249);
            tblocation.BorderStyle = BorderStyle.None;
            tblocation.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblocation.Location = new Point(471, 430);
            tblocation.Name = "tblocation";
            tblocation.Size = new Size(494, 31);
            tblocation.TabIndex = 3;
            // 
            // tbusername
            // 
            tbusername.BackColor = Color.FromArgb(241, 244, 249);
            tbusername.BorderStyle = BorderStyle.None;
            tbusername.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbusername.Location = new Point(471, 663);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(494, 31);
            tbusername.TabIndex = 4;
            // 
            // tbpassword
            // 
            tbpassword.BackColor = Color.FromArgb(241, 244, 249);
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbpassword.Location = new Point(471, 792);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(494, 31);
            tbpassword.TabIndex = 5;
            tbpassword.UseSystemPasswordChar = true;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1374, 1050);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Controls.Add(tblocation);
            Controls.Add(tbnomortelephone);
            Controls.Add(tbemail);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "register";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbemail;
        private TextBox tbnomortelephone;
        private TextBox tblocation;
        private TextBox tbusername;
        private TextBox tbpassword;
    }
}
