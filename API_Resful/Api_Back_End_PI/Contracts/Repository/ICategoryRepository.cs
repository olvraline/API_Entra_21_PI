using Api_Back_End_PI.DTO;
using Api_Back_End_PI.Entity;

namespace Api_Back_End_PI.Contracts.Repository
{
    public interface ICategoryRepository
    {
        Task Add(CategoryDTO api_teste);
        Task Update(CategoryEntity api_teste);
        Task Delete(int id);
        Task<CategoryEntity> GetById(int id);
        Task<CategoryEntity> GetByName(string name);
        Task<IEnumerable<CategoryEntity>> Get();

    }
}
