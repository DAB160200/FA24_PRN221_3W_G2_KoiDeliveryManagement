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
    public class Transaction : BaseModel
    {
        [Required]
        public int OrderId { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        public float Amount { get; set; }

        [MaxLength(50)]
        public string? PaymentMethod { get; set; } // e.g., "Credit Card", "PayPal"

        public string? PaymentId { get; set; }

        [MaxLength(500)]
        public string? Notes { get; set; }

        [Required]
        public bool IsSuccessful { get; set; }

        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; }
    }
}
