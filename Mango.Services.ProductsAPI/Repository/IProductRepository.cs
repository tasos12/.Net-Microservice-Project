using Mango.Services.ProductsAPI.Models.Dto;

namespace Mango.Services.ProductsAPI.Repository
{
    public interface IProductRepository
    {
        Task<List<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productDd);
    }
}
