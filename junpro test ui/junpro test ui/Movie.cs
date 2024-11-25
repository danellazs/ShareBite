/*using System;

namespace junpro_test_ui
{
    public class Movie
    {
        public int Id { get; set; }              // ID Produk
        public string Title { get; set; }        // Nama Produk
        public string Description { get; set; }  // Deskripsi Produk
        public string ImagePath { get; set; }    // Lokasi Gambar
        public int Stock { get; set; }           // Jumlah Stok
        public DateTime ExpiredDate { get; set; } // Tanggal Kadaluwarsa

        // Konstruktor baru untuk membuat objek Movie dengan parameter
        public Movie(int id, string title, string imagePath, DateTime expiredDate)
        {
            Id = id;
            Title = title;
            ImagePath = imagePath;
            ExpiredDate = expiredDate;
            Description = string.Empty; // Default value
            Stock = 0; // Default value
        }

        // Salin data dari movie lain
        public void Copy(Movie movie)
        {
            Title = movie.Title;
            Description = movie.Description;
            ImagePath = movie.ImagePath;
            Stock = movie.Stock;
            ExpiredDate = movie.ExpiredDate;
        }
    }
}*/