namespace junpro_test_ui
{
    partial class requestAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(requestAcc));
            button1 = new Button();
            tbSlot = new TextBox();
            tbPlace = new TextBox();
            pickupDate = new MonthCalendar();
            tbProduct = new TextBox();
            tbReceiver = new TextBox();
            tbRequestedDate = new TextBox();
            button2 = new Button();
            btnAcc = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(1470, 936);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(198, 60);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += requestAcc_Click;
            // 
            // tbSlot
            // 
            tbSlot.BackColor = Color.FromArgb(241, 244, 249);
            tbSlot.BorderStyle = BorderStyle.None;
            tbSlot.Font = new Font("Microsoft Tai Le", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSlot.Location = new Point(594, 512);
            tbSlot.Name = "tbSlot";
            tbSlot.Size = new Size(47, 35);
            tbSlot.TabIndex = 1;
            tbSlot.TextChanged += tbSlot_TextChanged;
            // 
            // tbPlace
            // 
            tbPlace.BackColor = Color.FromArgb(241, 244, 249);
            tbPlace.BorderStyle = BorderStyle.None;
            tbPlace.Font = new Font("Microsoft Tai Le", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPlace.Location = new Point(325, 607);
            tbPlace.Name = "tbPlace";
            tbPlace.Size = new Size(316, 35);
            tbPlace.TabIndex = 2;
            tbPlace.TextChanged += tbPlace_TextChanged;
            // 
            // pickupDate
            // 
            pickupDate.Location = new Point(871, 561);
            pickupDate.Name = "pickupDate";
            pickupDate.TabIndex = 3;
            pickupDate.DateChanged += pickupDate_DateChanged;
            // 
            // tbProduct
            // 
            tbProduct.BackColor = Color.White;
            tbProduct.BorderStyle = BorderStyle.None;
            tbProduct.Font = new Font("Microsoft Tai Le", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbProduct.Location = new Point(575, 236);
            tbProduct.Name = "tbProduct";
            tbProduct.Size = new Size(393, 55);
            tbProduct.TabIndex = 4;
            // 
            // tbReceiver
            // 
            tbReceiver.BorderStyle = BorderStyle.None;
            tbReceiver.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbReceiver.Location = new Point(640, 325);
            tbReceiver.Name = "tbReceiver";
            tbReceiver.Size = new Size(200, 41);
            tbReceiver.TabIndex = 5;
            tbReceiver.TextChanged += tbReceiver_TextChanged;
            // 
            // tbRequestedDate
            // 
            tbRequestedDate.BackColor = SystemColors.HighlightText;
            tbRequestedDate.BorderStyle = BorderStyle.None;
            tbRequestedDate.Font = new Font("Microsoft Tai Le", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbRequestedDate.Location = new Point(1134, 279);
            tbRequestedDate.Name = "tbRequestedDate";
            tbRequestedDate.Size = new Size(126, 35);
            tbRequestedDate.TabIndex = 6;
            tbRequestedDate.TextChanged += tbRequestedDate_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(883, 108);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnAcc
            // 
            btnAcc.BackColor = Color.Transparent;
            btnAcc.FlatStyle = FlatStyle.Flat;
            btnAcc.ForeColor = Color.Transparent;
            btnAcc.Location = new Point(1134, 942);
            btnAcc.Name = "btnAcc";
            btnAcc.Size = new Size(150, 46);
            btnAcc.TabIndex = 8;
            btnAcc.UseVisualStyleBackColor = false;
            btnAcc.Click += btnAcc_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(931, 942);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 9;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // requestAcc
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1415, 1035);
            Controls.Add(btnCancel);
            Controls.Add(btnAcc);
            Controls.Add(button2);
            Controls.Add(tbRequestedDate);
            Controls.Add(tbReceiver);
            Controls.Add(tbProduct);
            Controls.Add(pickupDate);
            Controls.Add(tbPlace);
            Controls.Add(tbSlot);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "requestAcc";
            Text = "Form2";
            Load += requestAcc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbSlot;
        private TextBox tbPlace;
        private MonthCalendar pickupDate;
        private TextBox tbProduct;
        private TextBox tbReceiver;
        private TextBox tbRequestedDate;
        private Button button2;
        private Button btnAcc;
        private Button btnCancel;
    }
}