namespace ASPTuristicheskaAgencia.Data
{
    public class Reservation
    {
        public int Id { get; set; }

        public string ClientId { get; set; }
        public Client Clients { get; set; }

        public int OfferId { get; set; }
        public Offer Offers { get; set; }
        public ReservationStatus Status { get; set; }
        public DateTime ReservationDate { get; set; }



    }
}
