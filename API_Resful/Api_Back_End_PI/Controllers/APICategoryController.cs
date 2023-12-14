using Microsoft.AspNetCore.Mvc;
using Api_Back_End_PI.Contracts.Repository;
using Api_Back_End_PI.DTO;
using Api_Back_End_PI.Entity;

namespace Api_Back_End_PI.Controllers
{
    [ApiController]
    [Route("category")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _categoryRepository.Get());
        }

        [HttpGet("byidcategory/{id}", Name = "GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _categoryRepository.GetById(id));
        }

        [HttpGet("bynamecategory/{name}", Name = "GetByName")]
        public async Task<IActionResult> GetByName(string name)
        {
            return Ok(await _categoryRepository.GetByName(name));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryDTO category)
        {
            await _categoryRepository.Add(category);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(CategoryEntity category)
        {
            await _categoryRepository.Update(category);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryRepository.Delete(id);
            return Ok();
        }
    }
}
