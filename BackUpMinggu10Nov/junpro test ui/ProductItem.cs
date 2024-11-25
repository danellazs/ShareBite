using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace junpro_test_ui
{
    public class ProductItem
    {
        public string ID { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int Stock { get; set; }
        public string Giver { get; set; } // Properti Giver ditambahkan
        public DateTime ExpiredDate { get; set; }

        public ProductItem() { }

        public ProductItem(string id, string name, string description, string imagePath, int stock, DateTime expiredDate)
        {
            ID = id;
            Name = name;
            Description = description;
            ImagePath = imagePath;
            Stock = stock;
            ExpiredDate = expiredDate;
        }

    }
}