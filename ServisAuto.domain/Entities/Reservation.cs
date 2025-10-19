using ServisAuto.domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisAuto.domain.Entities
{
    public class Reservation
    {
        //pk
        public int ReservationId { get; set; }

        //fk
        public Guid UserId { get; set; } // customer who made reservation
        public int VehicleId { get; set; }
        public int ServiceId { get; set; }

        //Reservation Details
        public DateTime ReservationDateTime { get; set; }
        public ReservationStatus Status { get; set; } = ReservationStatus.Pending;

        //notes
        public string? CustomerNote { get; set; }
        public string? ServicerNote { get; set; }

        //responsable person
        public Guid? HandledByUserId { get; set; }

        //timestamps
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        //navigation properties

        public User Customer { get; set; } = null!;
        public Vehicle Vehicle { get; set; } = null!;
        public Service Service { get; set; } = null!;
        public User? HandledBy { get; set; }

    }
}
