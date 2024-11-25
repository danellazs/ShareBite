/*using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace junpro_test_ui
{
    public partial class AddEditMovie : Form
    {
        private bool IsEdit;
        private Movie OriginalMovie;
        public Movie EditedMovie;
        public Movie NewMovie;
        public bool DataSaved;

        public AddEditMovie()
        {
            InitializeComponent();
            IsEdit = false;
        }

        public AddEditMovie(Movie movie)
        {
            InitializeComponent();
            IsEdit = true;
            OriginalMovie = movie;
        }

        private void AddEditMovie_Load(object sender, EventArgs e)
        {
            DataSaved = false;

            if (IsEdit)
            {
                PopulateOriginalMovie();
                this.Text = "Edit";
            }
            else
            {
                ClearInput();
                this.Text = "Add";
            }
        }

        private void PopulateOriginalMovie()
        {
            TxtTitle.Text = OriginalMovie.Title;
            TxtImagePath.Text = OriginalMovie.ImagePath;
            DtpReleaseDate.Value = OriginalMovie.ExpiredDate; // Pastikan Anda menggunakan Value, bukan Text
        }

        private void ClearInput()
        {
            TxtTitle.Clear();
            TxtImagePath.Clear();
            DtpReleaseDate.Value = DateTime.Now; // Pastikan menggunakan Value, bukan Text
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            List<string> errors;

            errors = ValidateInput();

            if (errors.Count > 0)
            {
                ShowErrors(errors, 5);
                return;
            }

            StoreInput();
            DataSaved = true;
            this.Close();
        }

        private List<string> ValidateInput()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(TxtTitle.Text))
                errors.Add("Title required");

            if (string.IsNullOrWhiteSpace(TxtImagePath.Text))
                errors.Add("Image Path required");

            return errors;
        }

        private void StoreInput()
        {
            string title = TxtTitle.Text;
            string imgPath = TxtImagePath.Text;
            DateTime expiredDate = DtpReleaseDate.Value; // Pastikan menggunakan Value, bukan Text

            if (IsEdit)
            {
                EditedMovie = new Movie(OriginalMovie.Id, title, imgPath, expiredDate);
            }
            else
            {
                int id = Convert.ToInt32(DateTime.Now.ToString("ddHHmmss"));
                NewMovie = new Movie(id, title, imgPath, expiredDate);
            }
        }

        private void ShowErrors(List<string> errors, int max)
        {
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string text = null;

            if (max > errors.Count)
                max = errors.Count;

            for (int i = 0; i < max; i++)
            {
                text += errors[i] + "\n";
            }

            MessageBox.Show(text, "", buttons, icon);
        }
    }
}*/