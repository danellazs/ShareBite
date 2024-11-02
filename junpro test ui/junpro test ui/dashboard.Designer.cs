namespace junpro_test_ui
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            button1 = new Button();
            productPemberi = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Tai Le", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(34, 232);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(208, 58);
            button1.TabIndex = 0;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // productPemberi
            // 
            productPemberi.BackColor = Color.Transparent;
            productPemberi.FlatAppearance.BorderSize = 0;
            productPemberi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            productPemberi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            productPemberi.FlatStyle = FlatStyle.Flat;
            productPemberi.Location = new Point(34, 174);
            productPemberi.Margin = new Padding(4);
            productPemberi.Name = "productPemberi";
            productPemberi.Size = new Size(246, 50);
            productPemberi.TabIndex = 1;
            productPemberi.UseVisualStyleBackColor = false;
            productPemberi.Click += productPemberi_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1437, 1344);
            Controls.Add(productPemberi);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "dashboard";
            Text = "Form3";
            Load += dashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button productPemberi;
    }
}