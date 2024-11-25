namespace junpro_test_ui
{
    partial class requestList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(requestList));
            button1 = new Button();
            dataGridView1 = new DataGridView();
            btnSelect = new Button();
            btnDelete = new Button();
            btnDashboard = new Button();
            btnProduct = new Button();
            btnSchedule = new Button();
            btnSetting = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(246, 81);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(309, 95);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(274, 287);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1008, 420);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.CornflowerBlue;
            btnSelect.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Location = new Point(1132, 741);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(150, 46);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(930, 741);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Location = new Point(27, 81);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(186, 46);
            btnDashboard.TabIndex = 4;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Transparent;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProduct.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Location = new Point(12, 133);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(201, 43);
            btnProduct.TabIndex = 5;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.BackColor = Color.Transparent;
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSchedule.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Location = new Point(12, 234);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(201, 43);
            btnSchedule.TabIndex = 6;
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.Transparent;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSetting.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Location = new Point(3, 882);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(201, 43);
            btnSetting.TabIndex = 7;
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(12, 931);
            button2.Name = "button2";
            button2.Size = new Size(201, 43);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // requestList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1415, 1035);
            Controls.Add(button2);
            Controls.Add(btnSetting);
            Controls.Add(btnSchedule);
            Controls.Add(btnProduct);
            Controls.Add(btnDashboard);
            Controls.Add(btnDelete);
            Controls.Add(btnSelect);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "requestList";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button btnSelect;
        private Button btnDelete;
        private Button btnDashboard;
        private Button btnProduct;
        private Button btnSchedule;
        private Button btnSetting;
        private Button button2;
    }
}