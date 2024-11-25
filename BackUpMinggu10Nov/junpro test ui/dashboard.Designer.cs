namespace junpro_test_ui
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            button1 = new Button();
            productPemberi = new Button();
            btngeneralSetting = new Button();
            button2 = new Button();
            btnLogout = new Button();
            button3 = new Button();
            lblTotProduct = new Label();
            lblTotRequest = new Label();
            lblTotReceived = new Label();
            dataGVRecentReceiver = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGVRecentReceiver).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Tai Le", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(-7, 181);
            button1.Name = "button1";
            button1.Size = new Size(186, 45);
            button1.TabIndex = 0;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // productPemberi
            // 
            productPemberi.BackColor = Color.Transparent;
            productPemberi.FlatAppearance.BorderSize = 0;
            productPemberi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            productPemberi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            productPemberi.FlatStyle = FlatStyle.Flat;
            productPemberi.Location = new Point(25, 90);
            productPemberi.Name = "productPemberi";
            productPemberi.Size = new Size(184, 31);
            productPemberi.TabIndex = 1;
            productPemberi.UseVisualStyleBackColor = false;
            productPemberi.Click += productPemberi_Click;
            // 
            // btngeneralSetting
            // 
            btngeneralSetting.BackColor = Color.Transparent;
            btngeneralSetting.FlatAppearance.BorderSize = 0;
            btngeneralSetting.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btngeneralSetting.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btngeneralSetting.FlatStyle = FlatStyle.Flat;
            btngeneralSetting.Location = new Point(9, 691);
            btngeneralSetting.Margin = new Padding(2);
            btngeneralSetting.Name = "btngeneralSetting";
            btngeneralSetting.Size = new Size(153, 36);
            btngeneralSetting.TabIndex = 2;
            btngeneralSetting.TextAlign = ContentAlignment.TopLeft;
            btngeneralSetting.UseVisualStyleBackColor = false;
            btngeneralSetting.Click += btngeneralSetting_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(9, 142);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(170, 34);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(9, 732);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(153, 36);
            btnLogout.TabIndex = 4;
            btnLogout.TextAlign = ContentAlignment.TopLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(25, 223);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(138, 36);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // lblTotProduct
            // 
            lblTotProduct.AutoSize = true;
            lblTotProduct.BackColor = Color.Transparent;
            lblTotProduct.FlatStyle = FlatStyle.Flat;
            lblTotProduct.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotProduct.Location = new Point(336, 241);
            lblTotProduct.Name = "lblTotProduct";
            lblTotProduct.Size = new Size(86, 70);
            lblTotProduct.TabIndex = 6;
            lblTotProduct.Text = "    ";
            lblTotProduct.Click += lblTotProduct_Click;
            // 
            // lblTotRequest
            // 
            lblTotRequest.AutoSize = true;
            lblTotRequest.BackColor = Color.Transparent;
            lblTotRequest.FlatStyle = FlatStyle.Flat;
            lblTotRequest.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotRequest.Location = new Point(731, 241);
            lblTotRequest.Name = "lblTotRequest";
            lblTotRequest.Size = new Size(86, 70);
            lblTotRequest.TabIndex = 7;
            lblTotRequest.Text = "    ";
            lblTotRequest.Click += lblTotRequest_Click;
            // 
            // lblTotReceived
            // 
            lblTotReceived.AutoSize = true;
            lblTotReceived.BackColor = Color.Transparent;
            lblTotReceived.FlatStyle = FlatStyle.Flat;
            lblTotReceived.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotReceived.Location = new Point(1137, 241);
            lblTotReceived.Name = "lblTotReceived";
            lblTotReceived.Size = new Size(86, 70);
            lblTotReceived.TabIndex = 8;
            lblTotReceived.Text = "    ";
            lblTotReceived.Click += lblTotReceived_Click;
            // 
            // dataGVRecentReceiver
            // 
            dataGVRecentReceiver.BackgroundColor = SystemColors.ButtonHighlight;
            dataGVRecentReceiver.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVRecentReceiver.Location = new Point(309, 542);
            dataGVRecentReceiver.Name = "dataGVRecentReceiver";
            dataGVRecentReceiver.RowHeadersWidth = 62;
            dataGVRecentReceiver.Size = new Size(1063, 267);
            dataGVRecentReceiver.TabIndex = 9;
            dataGVRecentReceiver.CellContentClick += dataGVRecentReceiver_CellContentClick;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1418, 1050);
            Controls.Add(dataGVRecentReceiver);
            Controls.Add(lblTotReceived);
            Controls.Add(lblTotRequest);
            Controls.Add(lblTotProduct);
            Controls.Add(button3);
            Controls.Add(btnLogout);
            Controls.Add(button2);
            Controls.Add(btngeneralSetting);
            Controls.Add(productPemberi);
            Controls.Add(button1);
            Name = "dashboard";
            Load += dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGVRecentReceiver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button productPemberi;
        private Button btngeneralSetting;
        private Button button2;
        private Button btnLogout;
        private Button button3;
        private Label lblTotProduct;
        private Label lblTotRequest;
        private Label lblTotReceived;
        private DataGridView dataGVRecentReceiver;
    }
}