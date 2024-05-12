using CosmeticsOnlineStore_Core.DTO.OrderDTO;
using CosmeticsOnlineStore_Core.DTO.productsDTO;
using CosmeticsProject_Core.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CosmeticsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : Controller
    {

        private readonly IAdminServicesInterface _services;
        public AdminController(IAdminServicesInterface services)
        {
            _services = services;
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateProduct(CreateProductDTO product)
        {
            await _services.CreateProduct(product);
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await _services.GetAllUsers();
            return Ok(result);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetOrderById(int Id)
        {
            var result = await _services.GetOrderById(Id);
            return Ok(result);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllOrder()
        {
            var result = await _services.GetAllOrder();
            return Ok(result);
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<IActionResult> DeleteProduct(int Id)
        {
            var result = _services.DeleteProduct(Id);
            return Ok(result);
        }
        [HttpDelete]
        [Route("[action]")]
        public async Task<IActionResult> DeleteUser(int Id)
        {
            var result = _services.DeleteUser(Id);
            return Ok(result);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetproductById(int Id)
        {
            var result = await _services.GetproductById(Id);
            return Ok(result);
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GeUserById(int Id)
        {
            var result = await _services.GeUserById(Id);
            return Ok(result);
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateProduct(UpdateProductDTO dto)
        {
            var result = await _services.UpdateProduct(dto);
            return Ok(result);
        }


    }
    }


