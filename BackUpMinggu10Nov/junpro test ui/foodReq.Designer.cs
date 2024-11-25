namespace junpro_test_ui
{
    partial class foodReq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foodReq));
            button1 = new Button();
            tbQty = new TextBox();
            lblStock = new Label();
            lblProductName = new Label();
            dateTimePicker = new DateTimePicker();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(657, 591);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(146, 44);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbQty
            // 
            tbQty.BackColor = Color.FromArgb(72, 128, 255);
            tbQty.BorderStyle = BorderStyle.None;
            tbQty.Location = new Point(744, 311);
            tbQty.Margin = new Padding(4);
            tbQty.Name = "tbQty";
            tbQty.Size = new Size(295, 32);
            tbQty.TabIndex = 1;
            tbQty.TextChanged += textBox1_TextChanged;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(396, 530);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(22, 32);
            lblStock.TabIndex = 2;
            lblStock.Text = "\u007f";
            lblStock.Click += this.lblStock_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(393, 447);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(0, 32);
            lblProductName.TabIndex = 3;
            lblProductName.Click += this.lblProductName_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(744, 392);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(326, 39);
            dateTimePicker.TabIndex = 4;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(339, 243);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(270, 188);
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            pictureBox.Click += this.pictureBox_Click;
            // 
            // foodReq
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1414, 1035);
            Controls.Add(pictureBox);
            Controls.Add(dateTimePicker);
            Controls.Add(lblProductName);
            Controls.Add(lblStock);
            Controls.Add(tbQty);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "foodReq";
            Text = "Form1";
            Load += foodReq_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbQty;
        private Label lblStock;
        private Label lblProductName;
        private DateTimePicker dateTimePicker;
        private PictureBox pictureBox;
    }
}