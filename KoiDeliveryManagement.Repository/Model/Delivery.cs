using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoiDeliveryManagement.Repository.Base;

namespace KoiDeliveryManagement.Repository.Model
{
    public class Delivery : BaseModel
    {
        [Required]
        public int OrderId { get; set; }

        [Required]
        public int DeliveryStaffId { get; set; }

        [MaxLength(200), Required]
        public string Location { get; set; }

        public DateTime? EstimatedArrivalDate { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [MaxLength(50)]
        public string? DeliveryMethod { get; set; }

        [MaxLength(50)]
        public string? TrackingCode { get; set; }

        [MaxLength(100)]
        public string? PackageType { get; set; }

        [MaxLength(500)]
        public string? Feedback { get; set; }

        [Range(1, 5)]
        public int? Rating { get; set; }

        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; }

        [ForeignKey(nameof(DeliveryStaffId))]
        public virtual User DeliveryStaff { get; set; }
    }
}
