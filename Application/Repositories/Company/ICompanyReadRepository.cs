using EnocaChallange.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EnocaChallange.Application.Repositories
{
    public interface ICompanyReadRepository : IReadRepository<Company>
    {
    }
}
