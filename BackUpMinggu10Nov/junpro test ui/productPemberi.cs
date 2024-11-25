using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace junpro_test_ui
{
    public partial class productPemberi : Form
    {
        public productPemberi()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.productPemberi_Load);
        }

        private void productPost_Click(object sender, EventArgs e)
        {
            productPost form11 = new productPost();
            form11.Show();
            this.Close();
        }

        private PictureBox CreateRoundedPictureBox(Image image, int width, int height, int cornerRadius)
        {
            PictureBox pictureBox = new PictureBox
            {
                Width = width,
                Height = height,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            pictureBox.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                    path.AddArc(width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                    path.AddArc(width - cornerRadius, height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                    path.AddArc(0, height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                    path.CloseFigure();

                    pictureBox.Region = new Region(path);
                    g.DrawImage(image, new Rectangle(0, 0, width, height));
                }
            };

            pictureBox.Image = image;
            return pictureBox;
        }

        private void LoadData()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            List<ProductItem> products = dbHelper.GetProductsByGiver(Program.UserSession.LoggedInUsername);
            int x = 10, y = 10, counter = 0;

            foreach (var product in products)
            {
                Panel panel = new Panel
                {
                    Width = 361,
                    Height = 497,
                    Location = new Point(x, y)
                };

                // Create PictureBox with rounded corners
                PictureBox pictureBox = CreateRoundedPictureBox(
                    Image.FromFile(product.ImagePath), 361, 317, 20 // 20 is the corner radius
                );
                pictureBox.Location = new Point(0, 0); // Position at the top of the panel

                // Set up labels with Times New Roman font
                Label lblName = new Label
                {
                    Text = product.Name,
                    Location = new Point(10, 338),
                    AutoSize = true,
                    Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold) // Change font to Times New Roman
                };

                Label lblStock = new Label
                {
                    Text = "Stock: " + product.Stock,
                    Location = new Point(24, 441), // Increased vertical position by 10 pixels
                    AutoSize = true,
                    Font = new Font("Microsoft Tai Le", 8, FontStyle.Bold) // Change font to Times New Roman
                };

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(lblName);
                panel.Controls.Add(lblStock);
                panelContainer.Controls.Add(panel);

                x += 389; // Adjust horizontal position
                counter++;

                if (counter % 3 == 0)
                {
                    x = 0;
                    y += 526; // Adjust vertical position for new row
                }

                panel.Click += (s, e) => OpenEditForm(product);
                pictureBox.Click += (s, e) => OpenEditForm(product);
                lblName.Click += (s, e) => OpenEditForm(product);
                lblStock.Click += (s, e) => OpenEditForm(product);

                panel.Tag = product.ID; // Save product ID as Tag
                panel.Click += panel_Click;
            }
        }

        private void panel_Click(object sender, EventArgs e)
        {
            string productID = ((Panel)sender).Tag.ToString();
            OpenEditForm(productID);
        }

        private void OpenEditForm(string productID)
        {
            var dbHelper = new DatabaseHelper();
            ProductItem product = dbHelper.GetProductById(productID);

            if (product != null)
            {
                var editForm = new productEditDelete(product);
                editForm.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }

        private void productPemberi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void OpenEditForm(ProductItem product)
        {
            var editForm = new productEditDelete(product);
            editForm.ShowDialog();
            LoadData();
        }

        private void productPemberi_Load_1(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productPemberi_Load_2(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard form10 = new dashboard();
            form10.Show();
            this.Close();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            requestList form13 = new requestList();
            form13.Show();
            this.Close();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ScheduleListReceiver form14 = new ScheduleListReceiver();
            form14.Show();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ViewgeneralSetting form15 = new ViewgeneralSetting();
            form15.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Begin form16 = new Begin();
            form16.Show();
            this.Close();
        }
    }
}