using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareBiteApp.Models
{
    public class Broadcast
    {
        public int BroadcastId { get; set; }
        public string Message { get; set; }
        public Pemberi Pemberi { get; set; }

        public void SendToFollowers()
        {
            // Logic to send message to followers
        }
    }
}
