using ETicaret.Application.Abstractions;
using ETicaret.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
         => new()
         {
             new() { Id = Guid.NewGuid(), Name = "prod1", Price = 100, Stock = 10, CreatedDate = DateTime.Now  },
             new() { Id = Guid.NewGuid(), Name = "prod2", Price = 200, Stock = 11, CreatedDate = DateTime.Now  },
             new() { Id = Guid.NewGuid(), Name = "prod3", Price = 300, Stock = 12, CreatedDate = DateTime.Now  },
             new() { Id = Guid.NewGuid(), Name = "prod4", Price = 400, Stock = 12, CreatedDate = DateTime.Now  }
         };
    }
}
