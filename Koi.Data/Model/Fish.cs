using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Koi.Data.Base;

namespace Koi.Data.Model
{
    public class Fish : BaseModel
    {
        [MaxLength(50), MinLength(5), Required]
        public string Name { get; set; }

        [MaxLength(200), MinLength(5)]
        public string? Description { get; set; }

        [MaxLength(50), MinLength(5), Required]
        public string Breed { get; set; }

        [Range(0.1f, 100f)]
        public float Size { get; set; }

        [Range(0.1f, 100f)]
        public float Weight { get; set; }

        [Required]
        public int SupplierId { get; set; }

        [Required]
        public DateTime Dob { get; set; }

        [MaxLength(100)]
        public string? HealthStatus { get; set; }

        [MaxLength(20)]
        public string? TagNumber { get; set; } // Unique Identifier for Fish

        [Required, Range(10f, 1000000000f)]
        public float? Price { get; set; }

        [ForeignKey(nameof(SupplierId))]
        public virtual Supplier Supplier { get; set; }

        public string? ImageUrl { get; set; }

        public virtual Certificate? Certificate { get; set; }
    }
}
