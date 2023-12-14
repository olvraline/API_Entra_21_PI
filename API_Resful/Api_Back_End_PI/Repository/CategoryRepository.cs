using Dapper;
using Api_Back_End_PI.Contracts.Repository;
using Api_Back_End_PI.DTO;
using Api_Back_End_PI.Entity;
using Api_Back_End_PI.Infrastructure;

namespace Api_Back_End_PI.Repository
{
    public class CategoryRepository : Connection, ICategoryRepository
    {
        public async Task Add(CategoryDTO api_teste)
        {
            string sql = @"
                INSERT INTO CATEGORY (Name)
                            VALUE (@Name)
            ";
            await Execute(sql, api_teste);

        }

        public async Task Delete(int id)
        {
            string sql = "DELETE FROM CATEGORY WHERE Id = @id";
            await Execute(sql, new { id });
        }

        public async Task<IEnumerable<CategoryEntity>> Get()
        {
            string sql = "SELECT * FROM CATEGORY";
            return await GetConnection().QueryAsync<CategoryEntity>(sql);
            
        }

        public async Task<CategoryEntity> GetById(int id)
        {
            string sql = "SELECT * FROM CATEGORY WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<CategoryEntity>(sql, new { id });
        }

        public async Task<CategoryEntity> GetByName(string name)
        {
            string sql = "SELECT * FROM CATEGORY WHERE Name = @name";
            return await GetConnection().QueryFirstAsync<CategoryEntity>(sql, new { name });
        }

        public async Task Update(CategoryEntity api_teste)
        {
            string sql = @"
                UPDATE CATEGORY 
                   SET Name = @Name
                 WHERE Id = @Id
            ";
            await Execute(sql, api_teste);
        }
    }
}
