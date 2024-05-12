using CosmeticsOnlineStore_Core.DTO;
using CosmeticsProject_Core.IRepos;
using CosmeticsProject_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Infra.Services
{
    public class SharedServices : ISharedServicesInterface
    {
        private readonly ISharedReposInterface _repos;
        public SharedServices(ISharedReposInterface repos)
        {
            _repos = repos;
        }

        public Task CreateAccount(RegistrationDTO dto)
        {
            return _repos.CreateAccount(dto);
        }

        public Task GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task Login(LoginReqDTO loginReqDTO)
        {
            return _repos.Login(loginReqDTO);
        }

        public Task Logout(int userId)
        {
            throw new NotImplementedException();
        }

        public Task ResetPassword(ResetPasswordDTO dto)
        {
            return _repos.ResetPassword(dto);
        }

        public Task UpdateProfile(UpdateProfileDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
