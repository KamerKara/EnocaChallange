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
    public class CompanyReadRepository : ReadRepository<Company>, ICompanyReadRepository
    {
        public CompanyReadRepository(EnocaChallangeAPIDbContext context) : base(context)
        {
        }
    }
}
