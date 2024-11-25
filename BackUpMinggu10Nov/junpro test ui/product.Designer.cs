namespace junpro_test_ui
{
    partial class product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product));
            buttonMilk = new Button();
            btngeneralSetting = new Button();
            panelContainer = new Panel();
            lblName = new Label();
            lblStock = new Label();
            lblNotifUnread = new Label();
            button1 = new Button();
            button2 = new Button();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // buttonMilk
            // 
            buttonMilk.BackColor = Color.Transparent;
            buttonMilk.FlatAppearance.BorderSize = 0;
            buttonMilk.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMilk.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMilk.FlatStyle = FlatStyle.Flat;
            buttonMilk.Location = new Point(211, 420);
            buttonMilk.Name = "buttonMilk";
            buttonMilk.Size = new Size(274, 405);
            buttonMilk.TabIndex = 0;
            buttonMilk.UseVisualStyleBackColor = false;
            buttonMilk.Click += buttonMilk_Click;
            // 
            // btngeneralSetting
            // 
            btngeneralSetting.BackColor = Color.Transparent;
            btngeneralSetting.FlatAppearance.BorderSize = 0;
            btngeneralSetting.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btngeneralSetting.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btngeneralSetting.FlatStyle = FlatStyle.Flat;
            btngeneralSetting.Location = new Point(21, 691);
            btngeneralSetting.Margin = new Padding(2);
            btngeneralSetting.Name = "btngeneralSetting";
            btngeneralSetting.Size = new Size(151, 36);
            btngeneralSetting.TabIndex = 1;
            btngeneralSetting.UseVisualStyleBackColor = false;
            btngeneralSetting.Click += btngeneralSetting_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.Transparent;
            panelContainer.Controls.Add(lblName);
            panelContainer.Controls.Add(lblStock);
            panelContainer.Location = new Point(260, 533);
            panelContainer.Margin = new Padding(2);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1147, 506);
            panelContainer.TabIndex = 2;
            panelContainer.Paint += panel1_Paint;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(22, 269);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 25);
            lblName.TabIndex = 2;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(12, 361);
            lblStock.Margin = new Padding(2, 0, 2, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(0, 25);
            lblStock.TabIndex = 1;
            // 
            // lblNotifUnread
            // 
            lblNotifUnread.BackColor = Color.Transparent;
            lblNotifUnread.FlatStyle = FlatStyle.Flat;
            lblNotifUnread.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotifUnread.Location = new Point(160, 133);
            lblNotifUnread.Margin = new Padding(2, 0, 2, 0);
            lblNotifUnread.Name = "lblNotifUnread";
            lblNotifUnread.Size = new Size(148, 128);
            lblNotifUnread.TabIndex = 3;
            lblNotifUnread.Click += lblNotifUnread_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(28, 181);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(144, 36);
            button1.TabIndex = 4;
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
            button2.Location = new Point(24, 133);
            button2.Name = "button2";
            button2.Size = new Size(194, 43);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1418, 1050);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblNotifUnread);
            Controls.Add(panelContainer);
            Controls.Add(btngeneralSetting);
            Controls.Add(buttonMilk);
            Name = "product";
            Text = "Form1";
            Load += product_Load;
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonMilk;
        private Button btngeneralSetting;
        private Panel panelContainer;
        private Label lblStock;
        private Label lblName;
        private Label lblNotifUnread;
        private Button button1;
        private Button button2;
    }
}