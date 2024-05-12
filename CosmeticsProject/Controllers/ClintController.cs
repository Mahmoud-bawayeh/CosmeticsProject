using CosmeticsOnlineStore_Core.DTO.OrderDTO;
using CosmeticsOnlineStore_Core.DTO.productsDTO;
using CosmeticsProject_Core.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CosmeticsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClintController : Controller
    {
        private readonly IClientIServicesnterface _client;
        public ClintController(IClientIServicesnterface client)
        {
            _client = client;
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateOrder(CreateOrderByClint dto)
        {
            await _client.CreateOrder(dto);
            return Ok();
        }

    }
    
}
