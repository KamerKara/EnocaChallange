using EnocaChallange.Application.Repositories;
using EnocaChallange.Domain.Entities;
using EnocaChallange.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallange.Persistence.Repositories
{
    public class CompanyWriteRepository : WriteRepository<Company>, ICompanyWriteRepository
    {
        public CompanyWriteRepository(EnocaChallangeAPIDbContext context) : base(context)
        {
        }

    }
}
