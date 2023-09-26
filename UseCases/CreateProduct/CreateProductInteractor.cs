using DTOs;
using Entities.Interfaces;
using Entities.POCOs;
using UseCasesPorts;

namespace UseCases.CreateProduct
{
    public class CreateProductInteractor : ICreateProductInputPort
    {
        readonly IProductRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        readonly ICreateProductOutputPort _outputPort;

        public CreateProductInteractor(IProductRepository productRepository, 
            IUnitOfWork unitOfWork, ICreateProductOutputPort createProductOutputPort)
        {
            _repository = productRepository;
            _unitOfWork = unitOfWork;
            _outputPort = createProductOutputPort;
        }
        public async Task Handle(CreateProductDTO product)
        {
            Product newProduct = new Product { Name = product.ProductName };
            _repository.CreateProduct(newProduct);

            await _unitOfWork.SaveChanges();
            await _outputPort.Handle(new ProductDTO 
            { 
              Id = newProduct.Id,
              Name = newProduct.Name 
            });
        }
    }
}
