namespace junpro_test_ui
{
    partial class Announcement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Announcement));
            tbAnnounce = new TextBox();
            btnSendAnnounce = new Button();
            flowLPAnnouncement = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // tbAnnounce
            // 
            tbAnnounce.Location = new Point(301, 231);
            tbAnnounce.Margin = new Padding(2);
            tbAnnounce.Name = "tbAnnounce";
            tbAnnounce.Size = new Size(395, 31);
            tbAnnounce.TabIndex = 0;
            tbAnnounce.TextChanged += tbAnnounce_TextChanged;
            // 
            // btnSendAnnounce
            // 
            btnSendAnnounce.BackColor = Color.Transparent;
            btnSendAnnounce.FlatAppearance.BorderSize = 0;
            btnSendAnnounce.FlatStyle = FlatStyle.Flat;
            btnSendAnnounce.Location = new Point(882, 228);
            btnSendAnnounce.Margin = new Padding(2);
            btnSendAnnounce.Name = "btnSendAnnounce";
            btnSendAnnounce.Size = new Size(152, 36);
            btnSendAnnounce.TabIndex = 1;
            btnSendAnnounce.UseVisualStyleBackColor = false;
            btnSendAnnounce.Click += btnSendAnnounce_Click;
            // 
            // flowLPAnnouncement
            // 
            flowLPAnnouncement.Location = new Point(274, 347);
            flowLPAnnouncement.Margin = new Padding(2);
            flowLPAnnouncement.Name = "flowLPAnnouncement";
            flowLPAnnouncement.Size = new Size(1106, 657);
            flowLPAnnouncement.TabIndex = 2;
            flowLPAnnouncement.Paint += flowLPAnnouncement_Paint;
            // 
            // Announcement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1418, 1050);
            Controls.Add(flowLPAnnouncement);
            Controls.Add(btnSendAnnounce);
            Controls.Add(tbAnnounce);
            Margin = new Padding(2);
            Name = "Announcement";
            Text = "Announcement";
            Load += Announcement_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbAnnounce;
        private Button btnSendAnnounce;
        private FlowLayoutPanel flowLPAnnouncement;
    }
}