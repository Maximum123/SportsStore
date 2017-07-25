using SportStore.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportStore.Domain.Models;
using SportStore.Domain.Concrete;

namespace SportStore.Domain.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<Product> Products
        {
            get
            {
                return context.Products;
            }
        }
    }
}
