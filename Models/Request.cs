using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareBiteApp.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public FoodItem FoodItem { get; set; }
        public Penerima Penerima { get; set; }

        public void Approve()
        {
            // Logic to approve request
        }

        public void Reject()
        {
            // Logic to reject request
        }

        public void SchedulePickup(string schedule)
        {
            // Logic to schedule pickup
        }
    }
}
