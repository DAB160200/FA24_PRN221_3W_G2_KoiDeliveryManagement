using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Koi.Data.Base;

namespace Koi.Data.Model
{
    public class User : BaseModel
    {
        [Required, MaxLength(50)]
        public string Username { get; set; }

        [Required, MaxLength(100)]
        public string FullName { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(15)]
        public string? PhoneNumber { get; set; }

        [Required, MaxLength(100)]
        public string PasswordHash { get; set; }

        public bool IsEmailVerified { get; set; } = false;

        [MaxLength(500)]
        public string? ProfileImageUrl { get; set; }

        [MaxLength(100)]
        public string? Role { get; set; } // e.g., "Admin", "Customer", "Staff"

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Delivery> Delivery { get; set; }
    }
}
