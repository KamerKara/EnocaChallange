using EnocaChallange.Application.Repositories;
using EnocaChallange.Domain.Entities;
using EnocaChallange.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallange.Persistence.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(EnocaChallangeAPIDbContext context) : base(context)
        {
        }

        public object GetApproval()
        {
            throw new NotImplementedException();
        }

        public object GetByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
