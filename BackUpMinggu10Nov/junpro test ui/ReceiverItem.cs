using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace junpro_test_ui
{
    public class ReceiverItem
    {
        public int Id { get; set; }  // Properti Id ditambahkan
        public string ProductName { get; set; }
        public string ReceiverName { get; set; }
        public int Slot { get; set; }
        public string Place { get; set; }
        public DateTime PickupDate { get; set; }
    }
}
