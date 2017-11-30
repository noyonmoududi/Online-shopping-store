using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.Domain.Entities;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EfProductRepossitory : IProductRepository
    {
        private readonly EfDbContext _context=new EfDbContext();

        public IEnumerable<Product> Products
        {
            get { return _context.Products; }
            
        }
    }
}
