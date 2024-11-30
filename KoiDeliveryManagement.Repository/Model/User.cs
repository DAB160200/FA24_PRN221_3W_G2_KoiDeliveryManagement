using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoiDeliveryManagement.Repository.Base;

namespace KoiDeliveryManagement.Repository.Model
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

        public DateTime Dob { get; set; }

        public bool Gender { get; set; }

        [MaxLength(500)]
        public string? Address { get; set; }

        public bool IsEmailVerified { get; set; } = false;

        [MaxLength(500)]
        public string? ProfileImageUrl { get; set; }

        [MaxLength(100)]
        public string? Role { get; set; } // e.g., "Admin", "Customer", "Staff"

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Delivery> Delivery { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
