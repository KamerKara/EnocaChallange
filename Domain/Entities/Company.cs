using EnocaChallange.domain.Entities;
using EnocaChallange.domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallange.Domain.Entities
{
    public class Company : BaseEntity
    {
        public int OrderId { get; set; }
        public bool ApprovalStatus { get; set; } //bool
        public DateTime OrderStartTime { get; set; } //DateTime
        public DateTime OrderFinishTime { get; set; } //DateTime

        //public Order Order { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
