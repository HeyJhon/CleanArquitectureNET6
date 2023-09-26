using DTOs;
using Microsoft.AspNetCore.Mvc;
using Presenters;
using UseCasesPorts;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateProductController
    {
        readonly ICreateProductInputPort _inputPort;
        readonly ICreateProductOutputPort _outputPort;

        public CreateProductController(
            ICreateProductInputPort InputPort, ICreateProductOutputPort OutputPort) 
            => (InputPort, OutputPort) = (_inputPort = InputPort, _outputPort= OutputPort);

        [HttpPost]
        public async Task<ProductDTO> CreateProduct(CreateProductDTO product)
        {
            await _inputPort.Handle(product);
            return ((IPresenter<ProductDTO>)_outputPort).Content;
        }
    }
}
