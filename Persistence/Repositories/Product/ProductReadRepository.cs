using EnocaChallange.Application.Repositories;
using EnocaChallange.domain.Entities;
using EnocaChallange.Persistence.Contexts;
using EnocaChallange.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallange.Persistence.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(EnocaChallangeAPIDbContext context) : base(context)
        {
        }
    }
}
