using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Koi.Data.Base;

namespace Koi.Data.Model
{
    public class Supplier : BaseModel
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string? Address { get; set; }

        [MaxLength(15)]
        public string? ContactNumber { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(500)]
        public string? WebsiteUrl { get; set; }

        [Required]
        public int OwnerId { get; set; }

        public virtual ICollection<Fish> Fishes { get; set; }
    }
}
