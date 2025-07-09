public class StatusMejaModel
{
    public string NomorMeja { get; set; }
    public TimeSpan? Jam { get; set; }          // jam mulai
    public int? Durasi { get; set; }            // durasi dalam menit
    public decimal? Harga { get; set; }
    public string NamaCustomer => "-";

    public string Status
    {
        get
        {
            if (Jam.HasValue && Durasi.HasValue)
            {
                var now = DateTime.Now.TimeOfDay;
                var mulai = Jam.Value;
                var selesai = mulai.Add(TimeSpan.FromMinutes(Durasi.Value));

                if (now >= mulai && now < selesai)
                {
                    return "In Use";
                }
            }
            return "Available";
        }
    }
}
