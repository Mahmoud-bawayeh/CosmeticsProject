using CosmeticsOnlineStore_Core.DTO;
using CosmeticsOnlineStore_Core.DTO.OrderDTO;
using CosmeticsOnlineStore_Core.DTO.productsDTO;
using CosmeticsProject_Core.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CosmeticsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeIController : Controller
    {
        private readonly IEmployeeServicesInterface _services;
        public EmployeeIController(IEmployeeServicesInterface services)
        {
            _services = services;
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CheckoutOrder(CreateOrderDTO dto)
        {
            await _services.CheckoutOrder(dto);
            return Ok();
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> PrintInvoice(Invoicedto invoice)
        {
            await _services.PrintInvoice(invoice);
            return Ok();
        }

    }
    
}
