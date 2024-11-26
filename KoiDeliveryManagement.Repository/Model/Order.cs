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
    public class Order : BaseModel
    {
        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [Required]
        public int FishId { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        [Range(1, 5)]
        public int? Rating { get; set; }

        [MaxLength(1000), MinLength(20)]
        public string? Feedback { get; set; }

        [Required, Range(10000f, 10000000000f)]
        public float Total { get; set; }

        [MaxLength(1000), MinLength(20)]
        public string? IssueReported { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public virtual User Customer { get; set; }

        [ForeignKey(nameof(ServiceId))]
        public virtual Service Service { get; set; }

        [ForeignKey(nameof(FishId))]
        public virtual Fish Fish { get; set; }

        public virtual Delivery Delivery { get; set; }
    }
}
