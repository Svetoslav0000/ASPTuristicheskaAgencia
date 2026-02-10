namespace ASPTuristicheskaAgencia.Data
{
    public class Offer
    {
        public int Id { get; set; } 

        public string Name { get; set; }
        public string Destination { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string IncludedServices { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedOn { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
