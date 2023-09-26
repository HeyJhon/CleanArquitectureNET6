using DTOs;

namespace UseCasesPorts
{
    public interface IGetAllProductsOutputPort
    {
        Task Handle(IEnumerable<ProductDTO> products);
    }
}
