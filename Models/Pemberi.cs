using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareBiteApp.Models
{
    public class Pemberi : User
    {
        public List<FoodItem> FoodItems { get; set; }

        public void PostFood(FoodItem foodItem)
        {
            // Logic to post food
        }

        public void ApproveRequest(Request request)
        {
            // Logic to approve request
        }

        public void SchedulePickup(Request request, string schedule)
        {
            // Logic to schedule pickup
        }

        public void BroadcastMessage(string message)
        {
            // Logic to broadcast message
        }
    }
}
