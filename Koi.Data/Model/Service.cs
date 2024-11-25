using System;
using System.ComponentModel.DataAnnotations;
using Koi.Data.Base;

namespace Koi.Data.Model
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
        public string Category { get; set; } // e.g., "Health Check", "Maintenance"

        public bool IsActive { get; set; } = true;
    }
}
