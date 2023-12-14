using Microsoft.AspNetCore.Mvc;
using Api_Back_End_PI.Contracts.Repository;
using Api_Back_End_PI.DTO;
using Api_Back_End_PI.Entity;

namespace Api_Back_End_PI.Controllers
{
    [ApiController]
    [Route("store")]
    public class StoreController : ControllerBase
    {
        private readonly IStoreRepository _storeRepository;

        public StoreController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetStore()
        {
            return Ok(await _storeRepository.GetStore());
        }

        [HttpGet("byidstore/{id}", Name = "GetByIdStore")]
        public async Task<IActionResult> GetByIdStore(int id)
        {
            return Ok(await _storeRepository.GetByIdStore(id));
        }

        [HttpGet("bynamestore/{name}", Name = "GetByNameStore")]
        public async Task<IActionResult> GetByNameStore(string name)
        {
            return Ok(await _storeRepository.GetByNameStore(name));
        }

        [HttpPost]
        public async Task<IActionResult> AddStore(StoreDTO store)
        {
            await _storeRepository.AddStore(store);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStore(StoreEntity store)
        {
            await _storeRepository.UpdateStore(store);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteStore(int id)
        {
            await _storeRepository.DeleteStore(id);
            return Ok();
        }
    }
}
