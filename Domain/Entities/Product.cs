
using EnocaChallange.domain.Entities.Common;
using EnocaChallange.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallange.domain.Entities
{
    public class Product : BaseEntity
    {
        public int CompanyId { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public Company company { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
