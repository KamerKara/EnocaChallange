using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using EnocaChallange.Application.Repositories;
using EnocaChallange.Persistence.Repositories;
using EnocaChallange.Persistence;
using EnocaChallange.Persistence.Contexts;

namespace EnocaChallange.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            //services.AddDbContext<FirmaSiparisAPIDbContext>(options => options.UseSqlServer("Server=DESKTOP-90EA4VD;Database=EnocaChallangeAPIDb;Trusted_Connection=True;TrustServerCertificate=True;"));
            services.AddDbContext<EnocaChallangeAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString), ServiceLifetime.Singleton);
            services.AddScoped<ICompanyReadRepository, CompanyReadRepository>();
            services.AddScoped<ICompanyWriteRepository, CompanyWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository,ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
