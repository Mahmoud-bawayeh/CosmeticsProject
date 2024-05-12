using CosmeticsOnlineStore_Core.DTO;
using CosmeticsOnlineStore_Core.DTO.productsDTO;
using CosmeticsProject_Core.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CosmeticsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharedController : Controller
    {
        private readonly ISharedServicesInterface _services;
        public SharedController(ISharedServicesInterface services)
        {
            _services = services;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateAccount(RegistrationDTO dto)
        {
            await _services.CreateAccount(dto);
            return Ok();
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Login(LoginReqDTO loginReqDTO)
        {
            await _services.Login(loginReqDTO);
            return Ok();
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> ResetPassword(ResetPasswordDTO dto)

        {
            await _services.ResetPassword(dto);
;
            return Ok();
        }
    }
}
