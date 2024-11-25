namespace junpro_test_ui
{
    partial class ViewgeneralSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewgeneralSetting));
            btnedit = new Button();
            tbusername = new TextBox();
            tbpassword = new TextBox();
            tbemail = new TextBox();
            tblocation = new TextBox();
            tbabout_me = new TextBox();
            SuspendLayout();
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.Transparent;
            btnedit.FlatAppearance.BorderSize = 0;
            btnedit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnedit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnedit.FlatStyle = FlatStyle.Flat;
            btnedit.Location = new Point(1084, 843);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(256, 46);
            btnedit.TabIndex = 0;
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // tbusername
            // 
            tbusername.BackColor = Color.FromArgb(241, 244, 249);
            tbusername.BorderStyle = BorderStyle.None;
            tbusername.Location = new Point(461, 437);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(341, 32);
            tbusername.TabIndex = 1;
            // 
            // tbpassword
            // 
            tbpassword.BackColor = Color.FromArgb(241, 244, 249);
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Location = new Point(461, 580);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(350, 32);
            tbpassword.TabIndex = 2;
            tbpassword.UseSystemPasswordChar = true;
            // 
            // tbemail
            // 
            tbemail.BackColor = Color.FromArgb(241, 244, 249);
            tbemail.BorderStyle = BorderStyle.None;
            tbemail.Location = new Point(879, 437);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(342, 32);
            tbemail.TabIndex = 3;
            // 
            // tblocation
            // 
            tblocation.BackColor = Color.FromArgb(241, 244, 249);
            tblocation.BorderStyle = BorderStyle.None;
            tblocation.Location = new Point(879, 580);
            tblocation.Name = "tblocation";
            tblocation.Size = new Size(342, 32);
            tblocation.TabIndex = 4;
            // 
            // tbabout_me
            // 
            tbabout_me.BackColor = Color.FromArgb(241, 244, 249);
            tbabout_me.BorderStyle = BorderStyle.None;
            tbabout_me.Location = new Point(879, 712);
            tbabout_me.Name = "tbabout_me";
            tbabout_me.Size = new Size(342, 32);
            tbabout_me.TabIndex = 5;
            // 
            // ViewgeneralSetting
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1415, 1035);
            Controls.Add(tbabout_me);
            Controls.Add(tblocation);
            Controls.Add(tbemail);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Controls.Add(btnedit);
            Name = "ViewgeneralSetting";
            Text = "ViewgeneralSetting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnedit;
        private TextBox tbusername;
        private TextBox tbpassword;
        private TextBox tbemail;
        private TextBox tblocation;
        private TextBox tbabout_me;
    }
}