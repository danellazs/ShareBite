namespace junpro_test_ui
{
    partial class productEditDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productEditDelete));
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtStock = new TextBox();
            txtImagePath = new TextBox();
            dtpExpiredDate = new DateTimePicker();
            btnSave = new Button();
            btnDelete = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.HotTrack;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Microsoft Tai Le", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(953, 230);
            txtName.Margin = new Padding(4, 4, 4, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(402, 28);
            txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Location = new Point(953, 334);
            txtDescription.Margin = new Padding(4, 4, 4, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(745, 192);
            txtDescription.TabIndex = 1;
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.None;
            txtStock.Location = new Point(1104, 591);
            txtStock.Margin = new Padding(4, 4, 4, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(38, 32);
            txtStock.TabIndex = 2;
            txtStock.TextAlign = HorizontalAlignment.Center;
            // 
            // txtImagePath
            // 
            txtImagePath.BorderStyle = BorderStyle.None;
            txtImagePath.Location = new Point(402, 658);
            txtImagePath.Margin = new Padding(4, 4, 4, 4);
            txtImagePath.Multiline = true;
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(395, 40);
            txtImagePath.TabIndex = 3;
            txtImagePath.TextChanged += txtImagePath_TextChanged;
            // 
            // dtpExpiredDate
            // 
            dtpExpiredDate.Location = new Point(1069, 689);
            dtpExpiredDate.Margin = new Padding(4, 4, 4, 4);
            dtpExpiredDate.Name = "dtpExpiredDate";
            dtpExpiredDate.Size = new Size(389, 39);
            dtpExpiredDate.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(1499, 1220);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(216, 59);
            btnSave.TabIndex = 5;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(1225, 1220);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(199, 59);
            btnDelete.TabIndex = 6;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(38, 178);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(231, 50);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // productEditDelete
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1447, 1344);
            Controls.Add(button1);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(dtpExpiredDate);
            Controls.Add(txtImagePath);
            Controls.Add(txtStock);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Margin = new Padding(4, 4, 4, 4);
            Name = "productEditDelete";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtStock;
        private TextBox txtImagePath;
        private DateTimePicker dtpExpiredDate;
        private Button btnSave;
        private Button btnDelete;
        private Button button1;
    }
}