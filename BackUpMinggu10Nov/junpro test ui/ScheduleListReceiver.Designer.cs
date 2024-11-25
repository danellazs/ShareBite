namespace junpro_test_ui
{
    partial class ScheduleListReceiver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleListReceiver));
            btnSelect = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // 
            // btnSelect
            // 
            btnSelect.BackColor = SystemColors.HotTrack;
            btnSelect.ForeColor = SystemColors.ButtonHighlight;
            btnSelect.Location = new Point(1208, 928);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(150, 46);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;

            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(279, 325);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1104, 597);
            dataGridView1.TabIndex = 1;

            // Bind event CellClick to dataGridView1_CellClick
            dataGridView1.CellClick += dataGridView1_CellClick;

            // 
            // ScheduleListReceiver
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1415, 1035);
            Controls.Add(dataGridView1);
            Controls.Add(btnSelect);
            Name = "ScheduleListReceiver";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScheduleListReceiver";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelect;
        private DataGridView dataGridView1;
    }
}
