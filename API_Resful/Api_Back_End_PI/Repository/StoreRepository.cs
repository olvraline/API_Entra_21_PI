using Dapper;
using Api_Back_End_PI.Contracts.Repository;
using Api_Back_End_PI.DTO;
using Api_Back_End_PI.Entity;
using Api_Back_End_PI.Infrastructure;


namespace Api_Back_End_PI.Repository
{
    public class StoreRepository : Connection, IStoreRepository
    {
        public async Task AddStore(StoreDTO store)
        {
            string sql = @"
                INSERT INTO STORE (Name)
                            VALUE (@name)
            ";
            await Execute(sql, store);

        }

        public async Task DeleteStore(int id)
        {
            string sql = "DELETE FROM STORE WHERE Id = @id";
            await Execute(sql, new { id });
        }

        public async Task<IEnumerable<StoreEntity>> GetStore()
        {
            string sql = "SELECT * FROM STORE";
            return await GetConnection().QueryAsync<StoreEntity>(sql);

        }

        public async Task<StoreEntity> GetByIdStore(int id)
        {
            string sql = "SELECT * FROM STORE WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<StoreEntity>(sql, new { id });
        }

        public async Task<StoreEntity> GetByNameStore(string name)
        {
            string sql = "SELECT * FROM STORE WHERE Name = @name";
            return await GetConnection().QueryFirstAsync<StoreEntity>(sql, new { name });
        }
        public async Task<StoreEntity> GetByCEP(int CEP)
        {
            string sql = "SELECT * FROM STORE WHERE CEP = @cep";
            return await GetConnection().QueryFirstAsync<StoreEntity>(sql, new { CEP });
        }

        public async Task<StoreEntity> GetByCNPJ(int CNPJ)
        {
            string sql = "SELECT * FROM STORE WHERE CNPJ = @cnpj";
            return await GetConnection().QueryFirstAsync<StoreEntity>(sql, new { CNPJ });
        }

        public async Task UpdateStore(StoreEntity store)
        {
            string sql = @"
                 UPDATE STORE 
                   SET Name = @Name, 
                       CEP = @cep,
                       CNPJ = @cnpj
                 WHERE Id = @Id
            ";
            await Execute(sql, store);
        }

    }
}
