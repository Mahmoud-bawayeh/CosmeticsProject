using CosmeticsOnlineStore_Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Core.IRepos
{
    public interface ISharedReposInterface
    {
        Task Login(LoginReqDTO loginReqDTO);
        Task Logout(int userId);
        Task CreateAccount(RegistrationDTO dto);
        Task ResetPassword(ResetPasswordDTO dto);
        Task UpdateProfile(UpdateProfileDTO dto);
        Task GetAllProducts();
    }
}
