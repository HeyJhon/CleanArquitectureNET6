using DTOs;

namespace UseCasesPorts
{
    public interface ICreateProductInputPort
    {
        Task Handle(CreateProductDTO product);
    }
}
