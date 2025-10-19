using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisAuto.domain.Entities
{
    public class Vehicle
    {
        //pk
        public int VehicleId { get; set; }

        //fk
        public Guid UserId { get; set; }

        //basic info

        public string LicensePlate { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; } = 1900;

        public string? VIN { get; set; }

        //timestamps

        public DateTime CreatedAt { get; set; }=DateTime.UtcNow;

        //Navigation properties
        public User User { get; set; } = null!;
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
