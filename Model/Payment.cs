using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikasi_billiard_center.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int BookingId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } // "BRI" atau "Mandiri"
        public string VirtualAccount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; } // "Pending", "Paid", "Failed"
    }
}
