using DTOs;
using Microsoft.AspNetCore.Mvc;
using Presenters;
using UseCasesPorts;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllProductsController
    {
        readonly IGetAllProductsInputPort _inputPort;
        readonly IGetAllProductsOutputPort _outputPort;

        public GetAllProductsController(
            IGetAllProductsInputPort InputPort, IGetAllProductsOutputPort OutputPort)
            => (_, _) = (_inputPort= InputPort, _outputPort= OutputPort);

        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            await _inputPort.Handle();
            return ((IPresenter<IEnumerable<ProductDTO>>)_outputPort).Content;
        }
    }
}
