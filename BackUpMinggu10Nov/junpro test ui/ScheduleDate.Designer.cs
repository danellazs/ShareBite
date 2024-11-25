namespace junpro_test_ui
{
    partial class ScheduleDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleDate));
            EditPickupDate = new MonthCalendar();
            lblReceiver = new Label();
            lblProductName = new Label();
            lblQty = new Label();
            btnSetDate = new Button();
            SuspendLayout();
            // 
            // EditPickupDate
            // 
            resources.ApplyResources(EditPickupDate, "EditPickupDate");
            EditPickupDate.Name = "EditPickupDate";
            // 
            // lblReceiver
            // 
            resources.ApplyResources(lblReceiver, "lblReceiver");
            lblReceiver.Name = "lblReceiver";
            // 
            // lblProductName
            // 
            resources.ApplyResources(lblProductName, "lblProductName");
            lblProductName.Name = "lblProductName";
            // 
            // lblQty
            // 
            resources.ApplyResources(lblQty, "lblQty");
            lblQty.Name = "lblQty";
            // 
            // btnSetDate
            // 
            btnSetDate.BackColor = Color.Transparent;
            resources.ApplyResources(btnSetDate, "btnSetDate");
            btnSetDate.Name = "btnSetDate";
            btnSetDate.UseVisualStyleBackColor = false;
            btnSetDate.Click += btnSetDate_Click;
            // 
            // ScheduleDate
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSetDate);
            Controls.Add(lblQty);
            Controls.Add(lblProductName);
            Controls.Add(lblReceiver);
            Controls.Add(EditPickupDate);
            Name = "ScheduleDate";
            Load += ScheduleDate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar EditPickupDate;
        private Label lblReceiver;
        private Label lblProductName;
        private Label lblQty;
        private Button btnSetDate;
    }
}