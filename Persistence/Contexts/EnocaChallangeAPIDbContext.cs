using EnocaChallange.domain.Entities;
using EnocaChallange.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallange.Persistence.Contexts
{
    public class EnocaChallangeAPIDbContext : DbContext
    {
        public EnocaChallangeAPIDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Company> Companies{ get; set; }
    }
}
