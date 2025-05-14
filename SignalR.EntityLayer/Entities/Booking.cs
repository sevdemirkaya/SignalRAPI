namespace SignalR.EntityLayer.Entities
{ 

    public class Booking
    {
        public int BookingID { get; set; }
        public string Name { get; set; } = string.Empty;

        public int Phone { get; set; }

        public string Mail { get; set; } = string.Empty;

        public int PersonCount { get; set; }

        public DateTime Date { get; set; }

    }
}
