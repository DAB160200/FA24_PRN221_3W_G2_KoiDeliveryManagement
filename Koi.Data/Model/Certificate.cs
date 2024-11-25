using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Koi.Data.Base;

namespace Koi.Data.Model
{
    public class Certificate : BaseModel
    {
        public int FishId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public string? Url { get; set; }

        [Required, MaxLength(100)]
        public string IssueBy { get; set; }

        public DateTime IssueDate { get; set; }

        [Required, MaxLength(50)]
        public string CertificateType { get; set; }

        public DateTime? ExpirationDate { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [MaxLength(100)]
        public string? AuthorityName { get; set; }

        public string? AuthorityUrl { get; set; }

        [MaxLength(200)]
        public string? AuthorityAddress { get; set; }

        [MaxLength(15)]
        public string? AuthorityContact { get; set; }

        [ForeignKey(nameof(FishId))]
        public virtual Fish Fish { get; set; }
    }
}
