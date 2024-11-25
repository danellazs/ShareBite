namespace junpro_test_ui
{
    partial class Begin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Begin));
            btnBegin = new Button();
            SuspendLayout();
            // 
            // btnBegin
            // 
            btnBegin.BackColor = Color.Transparent;
            btnBegin.FlatStyle = FlatStyle.Flat;
            btnBegin.ForeColor = Color.Transparent;
            btnBegin.Location = new Point(9, 0);
            btnBegin.Margin = new Padding(2, 2, 2, 2);
            btnBegin.Name = "btnBegin";
            btnBegin.Size = new Size(1083, 811);
            btnBegin.TabIndex = 0;
            btnBegin.UseVisualStyleBackColor = false;
            btnBegin.Click += btnBegin_Click;
            // 
            // Begin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1428, 809);
            Controls.Add(btnBegin);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Begin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Begin";
            Load += Begin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBegin;
    }
}