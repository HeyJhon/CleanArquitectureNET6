using Entities.POCOs;

namespace Entities.Interfaces
{
    public interface IProductRepository
    {
        void CreateProduct(Product product);
        IEnumerable<Product> GetAll();
     }
}
