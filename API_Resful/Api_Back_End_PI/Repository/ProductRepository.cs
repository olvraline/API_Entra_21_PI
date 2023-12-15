using Dapper;
using Api_Back_End_PI.Contracts.Repository;
using Api_Back_End_PI.DTO;
using Api_Back_End_PI.Entity;
using Api_Back_End_PI.Infrastructure;


namespace Api_Back_End_PI.Repository
{
    public class ProductRepository : Connection, IProductRepository
    {
        public async Task AddProduct(ProductDTO product)
        {
            string sql = @"
                INSERT INTO PRODUCT (Name,Description,OriginalPrice, CurrentPrice, Discount, Buyers)
                            VALUES (@name,@Description, @OriginalPrice, @CurrentPrice, @Discount, @Buyers)
            ";
            await Execute(sql, product);

        }

        public async Task DeleteProduct(int id)
        {
            string sql = "DELETE FROM PRODUCT WHERE Id = @id";
            await Execute(sql, new { id });
        }

        public async Task<IEnumerable<ProductEntity>> GetProduct()
        {
            string sql = "SELECT * FROM PRODUCT";
            return await GetConnection().QueryAsync<ProductEntity>(sql);

        }

        public async Task<ProductEntity> GetByIdProduct(int id)
        {
            string sql = "SELECT * FROM PRODUCT WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<ProductEntity>(sql, new { id });
        }

        public async Task<ProductEntity> GetByNameProduct(string name)
        {
            string sql = "SELECT * FROM PRODUCT WHERE Name = @name";
            return await GetConnection().QueryFirstAsync<ProductEntity>(sql, new { name });
        }
        public async Task<ProductEntity> GetByDescription(decimal description)
        {
            string sql = "SELECT * FROM PRODUCT WHERE Description = @description";
            return await GetConnection().QueryFirstAsync<ProductEntity>(sql, new { description });
        }

        public async Task<ProductEntity> GetByOriginalPrice(decimal originalprice)
        {
            string sql = "SELECT * FROM PRODUCT WHERE OriginalPrice = @originalprice";
            return await GetConnection().QueryFirstAsync<ProductEntity>(sql, new { originalprice });
        }

        public async Task<ProductEntity> GetByCurrentPrice(decimal currentprice)
        {
            string sql = "SELECT * FROM PRODUCT WHERE CurrentPrice = @currentprice";
            return await GetConnection().QueryFirstAsync<ProductEntity>(sql, new { currentprice });
        }

        public async Task<ProductEntity> GetByDiscount(decimal discount)
        {
            string sql = "SELECT * FROM PRODUCT WHERE Discount = @discount";
            return await GetConnection().QueryFirstAsync<ProductEntity>(sql, new { discount });
        }

        public async Task<ProductEntity> GetByBuyers(int buyers)
        {
            string sql = "SELECT * FROM PRODUCT WHERE Buyers = @buyers";
            return await GetConnection().QueryFirstAsync<ProductEntity>(sql, new { buyers });
        }

        public async Task UpdateProduct(ProductEntity product)
        {
            string sql = @"
                 UPDATE PRODUCT 
                   SET Name = @name,
                       Description = @Description,
                       OriginalPrice = @OriginalPrice,
                       CurrentPrice = @CurrentPrice,
                       Discount = @Discount,
                       Buyers = @Buyers
                 WHERE Id = @Id
            ";
            await Execute(sql, product);
        }

    }
}
