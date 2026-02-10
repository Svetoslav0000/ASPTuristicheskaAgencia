using Microsoft.AspNetCore.Identity;
using System.Data;

namespace ASPTuristicheskaAgencia.Data
{
    public class Client : IdentityUser  
    {
       

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
