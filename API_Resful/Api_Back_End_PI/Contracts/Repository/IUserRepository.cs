using Api_Back_End_PI.DTO;
using Api_Back_End_PI.Entity;

namespace Api_Back_End_PI.Contracts.Repository
{
    public interface IUserRepository
    {
        Task Add(UserDTO user);
        Task Update(UserEntity user);
        Task Delete(int id);
        Task<UserEntity> GetById(int id);
        Task<IEnumerable<UserEntity>> Get();

        Task<UserTokenDTO> LogIn(UserLoginDTO user);
    }
}
