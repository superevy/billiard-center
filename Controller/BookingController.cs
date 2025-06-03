using aplikasi_billiard_center.Model;

namespace aplikasi_billiard_center.Controllers
{
    public class BookingController
    {
        public bool SimpanBooking(int? id, string meja, string jam, int durasi)
        {
            Booking booking = new Booking
            {
                Id = id,
                Meja = meja,
                Jam = jam,
                Durasi = durasi

            };

            return booking.Save();
        }

    }

}
