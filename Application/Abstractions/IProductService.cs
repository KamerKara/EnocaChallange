using EnocaChallange.domain.Entities;
using EnocaChallange.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallange.Application.Abstractions
{
    //Projeye başlarken swagger uı ı ayağa kaldırmak için açılmış deneme sınıflarından biri
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
