using Entities.Interfaces;
using Entities.POCOs;
using RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly Context _context;
        public ProductRepository(Context context)
        {
            this._context = context;
        }
        public void CreateProduct(Product product)
        {
            _context.Add(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }
    }
}
