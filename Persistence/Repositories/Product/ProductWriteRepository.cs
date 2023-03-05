using EnocaChallange.Persistence.Contexts;
using EnocaChallange.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnocaChallange.domain.Entities;

namespace EnocaChallange.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(EnocaChallangeAPIDbContext context) : base(context)
        {
        }
    }
}
