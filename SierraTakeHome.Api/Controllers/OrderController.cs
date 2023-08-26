using Microsoft.AspNetCore.Mvc;
using SierraTakeHome.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SierraTakeHome.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // GET api/<OrderController>/5
        [HttpPost()]
        public async Task<IActionResult> Post([FromBody]NewOrder newOrder, [FromServices] IOrderRepository orderRepository, [FromServices]IUnitOfWork unitOfWork)
        {
            if(!ModelState.IsValid)            
                return BadRequest(ModelState);           

            var order = new Order(newOrder);
            await orderRepository.AddAsync(order);
            await unitOfWork.CommitAsync();
            return Ok(order);
        }
    }
}
