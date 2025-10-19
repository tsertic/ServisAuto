using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisAuto.domain.Entities
{
    public class Service
    {
        //pk
        public int ServiceId { get; set; }

        //basic informations
        public string Name { get; set; } = string.Empty;
        public string? Descritpion { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int DurationMinutes { get; set; }

        //status
        public bool IsActive { get; set; } = true;

        //timestamps

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //navigation properties

        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        
    }
}
