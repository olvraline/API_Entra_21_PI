using Api_Back_End_PI.DTO;
using Api_Back_End_PI.Entity;

namespace Api_Back_End_PI.Contracts.Repository
{
    public interface IStoreRepository
    {
            Task AddStore(StoreDTO store);
            Task UpdateStore(StoreEntity store);
            Task DeleteStore(int id);
            Task<StoreEntity> GetByIdStore(int id);
            Task<StoreEntity> GetByNameStore(string name);
            Task<StoreEntity> GetByCEP(int CEP);
            Task<StoreEntity> GetByCNPJ(int CNPJ);
            Task<IEnumerable<StoreEntity>> GetStore();
    }
}
