using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallange.Application.ViewModels.Order
{
    public class CreateOrder
    {
        public int ProductId { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string OrdersName { get; set; }
    }
}
