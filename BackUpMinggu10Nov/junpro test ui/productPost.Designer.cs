namespace junpro_test_ui
{
    partial class productPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productPost));
            txtNameProduct = new TextBox();
            txtDescriptionProduct = new TextBox();
            txtStockProduct = new TextBox();
            dtpExpiredDateProduct = new DateTimePicker();
            txtImagePathProduct = new TextBox();
            btnInsert = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNameProduct
            // 
            txtNameProduct.BorderStyle = BorderStyle.None;
            txtNameProduct.Font = new Font("Microsoft Tai Le", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameProduct.ForeColor = SystemColors.Desktop;
            txtNameProduct.Location = new Point(686, 177);
            txtNameProduct.Margin = new Padding(4);
            txtNameProduct.Name = "txtNameProduct";
            txtNameProduct.Size = new Size(381, 28);
            txtNameProduct.TabIndex = 0;
            txtNameProduct.TextChanged += textBox1_TextChanged;
            // 
            // txtDescriptionProduct
            // 
            txtDescriptionProduct.BorderStyle = BorderStyle.None;
            txtDescriptionProduct.Font = new Font("Microsoft Tai Le", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescriptionProduct.ForeColor = SystemColors.Desktop;
            txtDescriptionProduct.Location = new Point(686, 236);
            txtDescriptionProduct.Margin = new Padding(4);
            txtDescriptionProduct.Multiline = true;
            txtDescriptionProduct.Name = "txtDescriptionProduct";
            txtDescriptionProduct.Size = new Size(603, 192);
            txtDescriptionProduct.TabIndex = 1;
            // 
            // txtStockProduct
            // 
            txtStockProduct.BorderStyle = BorderStyle.None;
            txtStockProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStockProduct.ForeColor = SystemColors.InactiveCaption;
            txtStockProduct.Location = new Point(859, 458);
            txtStockProduct.Margin = new Padding(4);
            txtStockProduct.Name = "txtStockProduct";
            txtStockProduct.Size = new Size(31, 32);
            txtStockProduct.TabIndex = 2;
            txtStockProduct.TextAlign = HorizontalAlignment.Center;
            // 
            // dtpExpiredDateProduct
            // 
            dtpExpiredDateProduct.Location = new Point(824, 530);
            dtpExpiredDateProduct.Margin = new Padding(4);
            dtpExpiredDateProduct.Name = "dtpExpiredDateProduct";
            dtpExpiredDateProduct.Size = new Size(389, 39);
            dtpExpiredDateProduct.TabIndex = 3;
            dtpExpiredDateProduct.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtImagePathProduct
            // 
            txtImagePathProduct.BorderStyle = BorderStyle.None;
            txtImagePathProduct.Font = new Font("Microsoft Tai Le", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtImagePathProduct.ForeColor = SystemColors.Desktop;
            txtImagePathProduct.Location = new Point(270, 512);
            txtImagePathProduct.Margin = new Padding(4);
            txtImagePathProduct.Multiline = true;
            txtImagePathProduct.Name = "txtImagePathProduct";
            txtImagePathProduct.Size = new Size(381, 40);
            txtImagePathProduct.TabIndex = 4;
            txtImagePathProduct.TextAlign = HorizontalAlignment.Center;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Transparent;
            btnInsert.FlatAppearance.BorderSize = 0;
            btnInsert.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnInsert.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Location = new Point(1145, 948);
            btnInsert.Margin = new Padding(4);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(198, 51);
            btnInsert.TabIndex = 5;
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(-438, -26);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(246, 50);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Tai Le", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(383, 479);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 29);
            label1.TabIndex = 7;
            label1.Text = "Insert image path";
            label1.Click += label1_Click;
            // 
            // productPost
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1374, 1050);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnInsert);
            Controls.Add(txtImagePathProduct);
            Controls.Add(dtpExpiredDateProduct);
            Controls.Add(txtStockProduct);
            Controls.Add(txtDescriptionProduct);
            Controls.Add(txtNameProduct);
            Margin = new Padding(4);
            Name = "productPost";
            Text = "Form1";
            Load += productPost_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNameProduct;
        private TextBox txtDescriptionProduct;
        private TextBox txtStockProduct;
        private DateTimePicker dtpExpiredDateProduct;
        private TextBox txtImagePathProduct;
        private Button btnInsert;
        private Button button1;
        private Label label1;
    }
}