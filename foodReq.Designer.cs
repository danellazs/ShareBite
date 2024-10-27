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
            tbrcname = new TextBox();
            tbqty = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(681, 595);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbrcname
            // 
            tbrcname.BackColor = Color.FromArgb(72, 128, 255);
            tbrcname.BorderStyle = BorderStyle.None;
            tbrcname.Location = new Point(751, 315);
            tbrcname.Name = "tbrcname";
            tbrcname.Size = new Size(301, 24);
            tbrcname.TabIndex = 1;
            tbrcname.TextChanged += textBox1_TextChanged;
            // 
            // tbqty
            // 
            tbqty.BackColor = Color.FromArgb(72, 128, 255);
            tbqty.BorderStyle = BorderStyle.None;
            tbqty.Location = new Point(751, 400);
            tbqty.Name = "tbqty";
            tbqty.Size = new Size(301, 24);
            tbqty.TabIndex = 2;
            // 
            // foodReq
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1418, 1050);
            Controls.Add(tbqty);
            Controls.Add(tbrcname);
            Controls.Add(button1);
            Name = "foodReq";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbrcname;
        private TextBox tbqty;
    }
}