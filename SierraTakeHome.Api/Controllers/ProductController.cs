using Microsoft.AspNetCore.Mvc;
using SierraTakeHome.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SierraTakeHome.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id, [FromServices] IProductRepository productRepository)
        {
            return Ok(await productRepository.GetByIdAsync(id));
        }
    }
}
