using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiDeliveryManagement.Repository.Base
{
    public class BaseModel
    {
        protected BaseModel()
        {
            CreatedTime = LastUpdateTime = DateTime.UtcNow;
            Status = 1;
        }

        [Key]
        public int Id { get; set; }

        public int? CreatedBy { get; set; }
        public DateTimeOffset? CreatedTime { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTimeOffset? LastUpdateTime { get; set; }
        public int? DeletedBy { get; set; }
        public DateTimeOffset? DeletedTime { get; set; }
        public int Status { get; set; }
    }
}
