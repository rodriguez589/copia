using Parcial02.Entities.Users;
using Parcial02.Entities.Specialties;


namespace Parcial02.Entities.Reservations
{
    public class Reservation
    {
        public int IdReser{ get; set; } // propiedad que incrementa 
        
        public string Datetime { get; set; }
        
        public User user { get; set; }
        
        public Specialty Specialty { get; set; }
    }
}