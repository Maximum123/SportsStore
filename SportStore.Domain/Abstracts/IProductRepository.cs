using SportStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Domain.Abstracts
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }

        void Edit(Product product);
    }
}
