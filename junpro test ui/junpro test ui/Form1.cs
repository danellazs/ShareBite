/*using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Npgsql;

namespace junpro_test_ui
{
    public partial class Form1 : Form
    {
        private List<Movie> Movies = new List<Movie>();

        // Connection string PostgreSQL
        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=ella123;Database=sharebite";

        public Form1()
        {
            InitializeComponent();
        }

        private void AddMovieToUI(Movie movie)
        {
            Panel panel = new Panel
            {
                Name = $"PnlMovie{movie.Id}",
                BackColor = Color.White,
                Size = new Size(125, 205),
                Margin = new Padding(10),
                Tag = movie.Id
            };

            PictureBox picBox = new PictureBox
            {
                Name = $"PbMovieImage{movie.Id}",
                Size = new Size(100, 148),
                Location = new Point(12, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                Tag = movie.Id
            };
            if (File.Exists(movie.ImagePath))
                picBox.Image = Image.FromFile(movie.ImagePath);

            Label labelTitle = new Label
            {
                Name = $"LblMovieTitle{movie.Id}",
                Text = movie.Title,
                Location = new Point(12, 165),
                ForeColor = Color.Black,
                Font = new Font(this.Font.FontFamily, 9.5f, FontStyle.Regular),
                AutoSize = true,
                Tag = movie.Id
            };

            Label labelYear = new Label
            {
                Name = $"LblMovieYear{movie.Id}",
                Text = movie.ExpiredDate.Year.ToString(),
                Location = new Point(12, 185),
                ForeColor = Color.Gray,
                Font = new Font(this.Font.FontFamily, 9.5f, FontStyle.Regular),
                Tag = movie.Id
            };

            panel.ContextMenuStrip = contextMenuStrip1;

            panel.Controls.Add(picBox);
            panel.Controls.Add(labelTitle);
            panel.Controls.Add(labelYear);

            panel.DoubleClick += new EventHandler(Edit_DoubleClick);
            foreach (Control c in panel.Controls)
            {
                c.DoubleClick += new EventHandler(Edit_DoubleClick);
            }

            flowLayoutPanel1.Controls.Add(panel);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddEditMovie form = new AddEditMovie();
            form.ShowDialog();

            if (form.DataSaved)
            {
                Movie newMovie = form.NewMovie;

                // Simpan ke database
                bool isInserted = InsertProductToDatabase(newMovie);

                if (isInserted)
                {
                    Movies.Add(newMovie);
                    AddMovieToUI(newMovie);
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan produk ke database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool InsertProductToDatabase(Movie movie)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Menggunakan fungsi st_insert untuk menyimpan data movie
                    using (var cmd = new NpgsqlCommand("SELECT st_insert(@name, @description, @imagePath, @stock, @expiredDate);", connection))
                    {
                        cmd.Parameters.AddWithValue("name", movie.Title);
                        cmd.Parameters.AddWithValue("description", movie.Description);
                        cmd.Parameters.AddWithValue("imagePath", movie.ImagePath);
                        cmd.Parameters.AddWithValue("stock", movie.Stock);
                        cmd.Parameters.AddWithValue("expiredDate", movie.ExpiredDate);

                        // Pastikan hasil dari eksekusi fungsi st_insert adalah 1 (menunjukkan berhasil)
                        int result = (int)cmd.ExecuteScalar();
                        return result == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void UpdateMovieInUI(Movie movie)
        {
            string name = $"PbMovieImage{movie.Id}";
            Control control = this.Controls.Find(name, true).FirstOrDefault();
            PictureBox picBox = (PictureBox)control;

            if (File.Exists(movie.ImagePath))
                picBox.Image = Image.FromFile(movie.ImagePath);
            else
                picBox.Image = null;

            name = $"LblMovieTitle{movie.Id}";
            control = this.Controls.Find(name, true).FirstOrDefault();
            control.Text = movie.Title;

            name = $"LblMovieYear{movie.Id}";
            control = this.Controls.Find(name, true).FirstOrDefault();
            control.Text = movie.ExpiredDate.Year.ToString();
        }

        private void Edit_DoubleClick(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            int id = (int)c.Tag;
            Movie movie = Movies.Find(x => x.Id == id);

            AddEditMovie form = new AddEditMovie(movie);
            form.ShowDialog();

            if (form.DataSaved)
            {
                int index = Movies.FindIndex(x => x.Id == id);
                Movies[index].Copy(form.EditedMovie);
                UpdateMovieInUI(Movies[index]);
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip menuStrip = (ContextMenuStrip)menuItem.GetCurrentParent();
            Control control = menuStrip.SourceControl;

            int id = (int)control.Tag;
            Movie movie = Movies.Find(x => x.Id == id);

            int index = Movies.FindIndex(x => x.Id == id);
            Movies.RemoveAt(index);

            DeleteMovieFromUI(movie);
        }

        private void DeleteMovieFromUI(Movie movie)
        {
            string name = $"PnlMovie{movie.Id}";
            Control panel = this.Controls.Find(name, true).FirstOrDefault();

            panel.DoubleClick -= new EventHandler(Edit_DoubleClick);
            foreach (Control c in panel.Controls)
            {
                c.DoubleClick -= new EventHandler(Edit_DoubleClick);
            }

            flowLayoutPanel1.Controls.Remove(panel);
            panel.Dispose();
        }
    }
}
*/