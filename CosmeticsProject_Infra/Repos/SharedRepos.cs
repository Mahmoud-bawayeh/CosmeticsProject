using CosmeticsOnlineStore_Core.DTO;
using CosmeticsProject_Core.Context;
using CosmeticsProject_Core.Entity;
using CosmeticsProject_Core.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Infra.Repos
{
    public class SharedRepos : ISharedReposInterface
    {
        private readonly CosmeticsOnlineStoreDBContext _dbContext;
        public SharedRepos(CosmeticsOnlineStoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAccount(RegistrationDTO dto)
        {
            var A = new Users();
            A.FirstName = dto.FirstName;
            A.LastName = dto.LastName;
            A.Email = dto.Email;
            A.Password = dto.Password;
            A.Phone = dto.Phone;
            A.Birthday = dto.Birthday;
            
            await _dbContext.Users.AddAsync(A);
            await _dbContext.SaveChangesAsync();
        }

        public Task GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public async Task Login(LoginReqDTO loginReqDTO)
        {
            var log = new login();
            log.UserName=loginReqDTO.UserName;
            log.Password=loginReqDTO.Password;
            await _dbContext.Login.AddAsync(log);
            await _dbContext.SaveChangesAsync();


                  }

        public Task Logout(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task ResetPassword(ResetPasswordDTO dto)
        {
            throw new NotImplementedException();

        }

        public async Task UpdateProfile(UpdateProfileDTO dto)
        {
            throw new NotImplementedException();

        }
    }
}
