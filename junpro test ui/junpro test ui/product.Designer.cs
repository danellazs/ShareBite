namespace junpro_test_ui
{
    partial class product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product));
            buttonMilk = new Button();
            SuspendLayout();
            // 
            // buttonMilk
            // 
            buttonMilk.BackColor = Color.Transparent;
            buttonMilk.FlatAppearance.BorderSize = 0;
            buttonMilk.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMilk.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMilk.FlatStyle = FlatStyle.Flat;
            buttonMilk.Location = new Point(286, 553);
            buttonMilk.Name = "buttonMilk";
            buttonMilk.Size = new Size(336, 485);
            buttonMilk.TabIndex = 0;
            buttonMilk.UseVisualStyleBackColor = false;
            buttonMilk.Click += buttonMilk_Click;
            // 
            // product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1419, 1050);
            Controls.Add(buttonMilk);
            Name = "product";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonMilk;
    }
}