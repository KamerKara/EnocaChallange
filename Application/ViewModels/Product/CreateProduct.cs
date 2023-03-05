using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallange.Application.ViewModels.Product
{
    public class CreateProduct
    {
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public string ProductName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
