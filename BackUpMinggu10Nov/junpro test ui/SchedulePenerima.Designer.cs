namespace junpro_test_ui
{
    partial class SchedulePenerima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulePenerima));
            monthCalenderSchedulePicker = new MonthCalendar();
            dataGVScheduleDetail = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGVScheduleDetail).BeginInit();
            SuspendLayout();
            // 
            // monthCalenderSchedulePicker
            // 
            monthCalenderSchedulePicker.Location = new Point(284, 214);
            monthCalenderSchedulePicker.Name = "monthCalenderSchedulePicker";
            monthCalenderSchedulePicker.TabIndex = 0;
            monthCalenderSchedulePicker.DateChanged += monthCalenderSchedulePicker_DateChanged;
            // 
            // dataGVScheduleDetail
            // 
            dataGVScheduleDetail.BackgroundColor = SystemColors.ButtonHighlight;
            dataGVScheduleDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVScheduleDetail.Location = new Point(669, 282);
            dataGVScheduleDetail.Name = "dataGVScheduleDetail";
            dataGVScheduleDetail.RowHeadersWidth = 62;
            dataGVScheduleDetail.Size = new Size(719, 726);
            dataGVScheduleDetail.TabIndex = 1;
            dataGVScheduleDetail.CellContentClick += dataGVScheduleDetail_CellContentClick;
            // 
            // SchedulePenerima
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1418, 1050);
            Controls.Add(dataGVScheduleDetail);
            Controls.Add(monthCalenderSchedulePicker);
            Name = "SchedulePenerima";
            Text = "SchedulePenerima";
            ((System.ComponentModel.ISupportInitialize)dataGVScheduleDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalenderSchedulePicker;
        private DataGridView dataGVScheduleDetail;
    }
}