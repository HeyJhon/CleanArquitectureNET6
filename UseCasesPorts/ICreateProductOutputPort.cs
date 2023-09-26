using DTOs;

namespace UseCasesPorts
{
    public interface ICreateProductOutputPort
    {
        Task Handle(ProductDTO product);
    }
}
