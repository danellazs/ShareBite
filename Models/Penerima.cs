using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareBiteApp.Models
{
    public class Penerima : User
    {
        public List<Pemberi> FollowedPemberi { get; set; }

        public void SearchFood(string keyword)
        {
            // Logic to search food
        }

        public void RequestFood(FoodItem foodItem)
        {
            // Logic to request food
        }

        public void FollowPemberi(Pemberi pemberi)
        {
            // Logic to follow Pemberi
        }

        public void ReceiveBroadcast(string message)
        {
            // Logic to receive broadcast
        }
    }
}
