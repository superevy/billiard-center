using System.Data;
using aplikasi_billiard_center.Model;

namespace aplikasi_billiard_center.Controllers
{
    public class BookingController
    {
        public bool SimpanBooking(int? id, string meja, string jam, int durasi, out string errorMessage)
        {
            Booking booking = new Booking
            {
                Id = id,
                Meja = meja,
                Jam = jam,
                Durasi = durasi
            };

            return booking.Save(out errorMessage);
        }
        public DataTable GetAllBookings()
        {
            return Booking.GetAll();
        }

        public bool DeleteBooking(int id, out string errorMessage)
        {
            return Booking.Delete(id, out errorMessage);
        }
    }
}
