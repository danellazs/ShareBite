namespace junpro_test_ui
{
    partial class Inbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inbox));
            listViewNotifications = new ListView();
            btnReadMsg = new Button();
            btnDelete = new Button();
            lblNotifUnread = new Label();
            SuspendLayout();
            // 
            // listViewNotifications
            // 
            listViewNotifications.Location = new Point(301, 287);
            listViewNotifications.Margin = new Padding(2, 2, 2, 2);
            listViewNotifications.Name = "listViewNotifications";
            listViewNotifications.Size = new Size(1086, 726);
            listViewNotifications.TabIndex = 0;
            listViewNotifications.UseCompatibleStateImageBehavior = false;
            listViewNotifications.SelectedIndexChanged += listViewNotifications_SelectedIndexChanged;
            // 
            // btnReadMsg
            // 
            btnReadMsg.BackColor = Color.Transparent;
            btnReadMsg.FlatAppearance.BorderSize = 0;
            btnReadMsg.FlatStyle = FlatStyle.Flat;
            btnReadMsg.Location = new Point(1254, 206);
            btnReadMsg.Margin = new Padding(2, 2, 2, 2);
            btnReadMsg.Name = "btnReadMsg";
            btnReadMsg.Size = new Size(35, 36);
            btnReadMsg.TabIndex = 1;
            btnReadMsg.UseVisualStyleBackColor = false;
            btnReadMsg.Click += btnReadMsg_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(1293, 206);
            btnDelete.Margin = new Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(38, 36);
            btnDelete.TabIndex = 2;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblNotifUnread
            // 
            lblNotifUnread.BackColor = Color.Transparent;
            lblNotifUnread.FlatStyle = FlatStyle.Flat;
            lblNotifUnread.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotifUnread.Location = new Point(175, 150);
            lblNotifUnread.Margin = new Padding(2, 0, 2, 0);
            lblNotifUnread.Name = "lblNotifUnread";
            lblNotifUnread.Size = new Size(128, 128);
            lblNotifUnread.TabIndex = 3;
            // 
            // Inbox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1418, 1050);
            Controls.Add(lblNotifUnread);
            Controls.Add(btnDelete);
            Controls.Add(btnReadMsg);
            Controls.Add(listViewNotifications);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Inbox";
            Text = "Inbox";
            Load += Inbox_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewNotifications;
        private Button btnReadMsg;
        private Button btnDelete;
        private Label lblNotifUnread;
    }
}