using ServisAuto.domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisAuto.domain.Entities
{
    internal class User
    {
        //PK
        public Guid UserId { get; set; }

        //basic info
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;    
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }

        //role and status
        public Role Role { get; set; }
        public bool IsActive { get; set; } = true;

        //timestamps
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //Navigation properties
        //TODO odkemntiraj kada uvedemo ove klase
      //  public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
      //  public ICollection<Resirvation> Resirvations { get; set; } = new List<Resirvation>();
    }
}
