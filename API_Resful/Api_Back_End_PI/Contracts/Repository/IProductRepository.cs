using Api_Back_End_PI.DTO;
using Api_Back_End_PI.Entity;

namespace Api_Back_End_PI.Contracts.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductEntity>> GetProduct();
        Task AddProduct(ProductDTO product);
        Task UpdateProduct(ProductEntity product);
        Task DeleteProduct(int id);
        Task<ProductEntity> GetByIdProduct(int id);
        Task<ProductEntity> GetByNameProduct(string name);
        Task<ProductEntity> GetByDescription(decimal Description);
        Task<ProductEntity> GetByOriginalPrice(decimal OriginalPrice);
        Task<ProductEntity> GetByCurrentPrice(decimal CurrentPrice);
        Task<ProductEntity> GetByDiscount(decimal Discount);
        Task<ProductEntity> GetByBuyers(int Buyers);
        
    }
}
