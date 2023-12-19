using Api_Back_End_PI.DTO;
using Api_Back_End_PI.Entity;
using global::Api_Back_End_PI.Contracts.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api_Back_End_PI.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _userRepository.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _userRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserDTO user)
        {
            await _userRepository.Add(user);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserEntity user)
        {
            await _userRepository.Update(user);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _userRepository.Delete(id);
            return Ok();
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LogIn(UserLoginDTO user)
        {
            try
            {
                return Ok(await _userRepository.LogIn(user));
            }
            catch (Exception ex)
            {
                return Unauthorized("Usuário ou senha invalidos");
            }
        }
    }
}
