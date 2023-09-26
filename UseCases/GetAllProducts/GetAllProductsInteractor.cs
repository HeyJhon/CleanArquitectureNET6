using DTOs;
using Entities.Interfaces;
using UseCasesPorts;

namespace UseCases.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        readonly IProductRepository _repository;
        readonly IGetAllProductsOutputPort _outputPort;
        public GetAllProductsInteractor(
            IProductRepository productRepository, 
            IGetAllProductsOutputPort getAllProductsOutputPort) => 
            (_, _) = (_repository= productRepository, _outputPort= getAllProductsOutputPort);
        public Task Handle()
        {
            var products = _repository.GetAll().Select(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name
            });

            _outputPort.Handle(products);
            return Task.CompletedTask;
        }

        
    }
}
