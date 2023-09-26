using Microsoft.Extensions.DependencyInjection;
using UseCases.CreateProduct;
using UseCases.GetAllProducts;
using UseCasesPorts;

namespace UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            services.AddTransient<ICreateProductInputPort, CreateProductInteractor>();
            services.AddTransient<IGetAllProductsInputPort, GetAllProductsInteractor>();

            return services;
        }

    }
}
