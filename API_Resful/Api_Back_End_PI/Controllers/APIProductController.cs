using Microsoft.AspNetCore.Mvc;
using Api_Back_End_PI.Contracts.Repository;
using Api_Back_End_PI.DTO;
using Api_Back_End_PI.Entity;

namespace Api_Back_End_PI.Controllers
{
    [ApiController]
    [Route("product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            return Ok(await _productRepository.GetProduct());
        }

        [HttpGet("byidproduct/{id}", Name = "GetByIdProduct")]
        public async Task<IActionResult> GetByIdProduct(int id)
        {
            return Ok(await _productRepository.GetByIdProduct(id));
        }

        [HttpGet("bynameproduct/{name}", Name = "GetByNameProduct")]
        public async Task<IActionResult> GetByNameProduct(string name)
        {
            return Ok(await _productRepository.GetByNameProduct(name));
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductDTO product)
        {
            await _productRepository.AddProduct(product);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStore(ProductEntity product)
        {
            await _productRepository.UpdateProduct(product);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productRepository.DeleteProduct(id);
            return Ok();
        }
    }
}
