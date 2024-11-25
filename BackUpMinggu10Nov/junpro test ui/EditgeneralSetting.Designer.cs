namespace junpro_test_ui
{
    partial class EditgeneralSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditgeneralSetting));
            tbusername = new TextBox();
            tbcurrent_password = new TextBox();
            tbnew_password = new TextBox();
            tbemail = new TextBox();
            tblocation = new TextBox();
            tbabout_me = new TextBox();
            btnsave = new Button();
            SuspendLayout();
            // 
            // tbusername
            // 
            tbusername.BackColor = Color.FromArgb(241, 244, 249);
            tbusername.BorderStyle = BorderStyle.None;
            tbusername.Location = new Point(460, 437);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(344, 32);
            tbusername.TabIndex = 0;
            // 
            // tbcurrent_password
            // 
            tbcurrent_password.BackColor = Color.FromArgb(241, 244, 249);
            tbcurrent_password.BorderStyle = BorderStyle.None;
            tbcurrent_password.Location = new Point(460, 581);
            tbcurrent_password.Name = "tbcurrent_password";
            tbcurrent_password.Size = new Size(344, 32);
            tbcurrent_password.TabIndex = 1;
            // 
            // tbnew_password
            // 
            tbnew_password.BackColor = Color.FromArgb(241, 244, 249);
            tbnew_password.BorderStyle = BorderStyle.None;
            tbnew_password.Location = new Point(460, 711);
            tbnew_password.Name = "tbnew_password";
            tbnew_password.Size = new Size(344, 32);
            tbnew_password.TabIndex = 2;
            // 
            // tbemail
            // 
            tbemail.BackColor = Color.FromArgb(241, 244, 249);
            tbemail.BorderStyle = BorderStyle.None;
            tbemail.Location = new Point(881, 440);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(346, 32);
            tbemail.TabIndex = 3;
            // 
            // tblocation
            // 
            tblocation.BackColor = Color.FromArgb(241, 244, 249);
            tblocation.BorderStyle = BorderStyle.None;
            tblocation.Location = new Point(881, 581);
            tblocation.Name = "tblocation";
            tblocation.Size = new Size(342, 32);
            tblocation.TabIndex = 4;
            // 
            // tbabout_me
            // 
            tbabout_me.BackColor = Color.FromArgb(241, 244, 249);
            tbabout_me.BorderStyle = BorderStyle.None;
            tbabout_me.Location = new Point(881, 711);
            tbabout_me.Name = "tbabout_me";
            tbabout_me.Size = new Size(342, 32);
            tbabout_me.TabIndex = 5;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.Transparent;
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnsave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Location = new Point(710, 820);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(265, 46);
            btnsave.TabIndex = 6;
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // EditgeneralSetting
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1415, 1035);
            Controls.Add(btnsave);
            Controls.Add(tbabout_me);
            Controls.Add(tblocation);
            Controls.Add(tbemail);
            Controls.Add(tbnew_password);
            Controls.Add(tbcurrent_password);
            Controls.Add(tbusername);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "EditgeneralSetting";
            RightToLeft = RightToLeft.No;
            Text = "generalSetting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbusername;
        private TextBox tbcurrent_password;
        private TextBox tbnew_password;
        private TextBox tbemail;
        private TextBox tblocation;
        private TextBox tbabout_me;
        private Button btnsave;
    }
}