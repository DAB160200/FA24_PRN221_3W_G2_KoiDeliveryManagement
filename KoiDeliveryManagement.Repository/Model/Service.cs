using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoiDeliveryManagement.Repository.Base;

namespace KoiDeliveryManagement.Repository.Model
{
    public class Service : BaseModel
    {
        [Required, MaxLength(100), MinLength(5)]
        public string Name { get; set; }

        [MaxLength(500), MinLength(20)]
        public string? Description { get; set; }

        [Required, Range(0.01f, 100000f)]
        public float Price { get; set; }

        [Required, MaxLength(50)]
        public string Category { get; set; }

        public bool IsActive { get; set; } = true;

        [Required, MaxLength(20)]
        public string ServiceCode { get; set; }

        [Required, Range(0.1f, 24f)]
        public float DurationInHours { get; set; }


        [MaxLength(200)]
        public string? ImageUrl { get; set; }

        [MaxLength(1000)]
        public string? TermsAndConditions { get; set; } 
        [Range(0f, 5f)]
        public float? Rating { get; set; }

        public bool IsFeatured { get; set; } = false;

        [MaxLength(50)]
        public string Availability { get; set; }

        [Range(0f, 100f)]
        public float? DiscountPercentage { get; set; }
    }
}
