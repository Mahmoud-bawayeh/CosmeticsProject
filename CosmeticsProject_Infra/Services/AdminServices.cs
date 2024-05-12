using CosmeticsOnlineStore_Core.DTO.OrderRecordDTO;
using CosmeticsOnlineStore_Core.DTO.productsDTO;
using CosmeticsOnlineStore_Core.DTO.UserDTO;
using CosmeticsProject_Core.IRepos;
using CosmeticsProject_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Infra.Services
{
    public class AdminServices : IAdminServicesInterface
    {
        private readonly IAdminReposInterface _repos;
        public AdminServices(IAdminReposInterface repos)
        {
            _repos = repos;
        }
        public Task CreateProduct(CreateProductDTO product)
        {
            return _repos.CreateProduct(product);
        }

        public Task DeleteProduct(int Id)
        {
            return _repos.DeleteProduct(Id);
        }

        public async Task<Task<object>> DeleteUser(int Id)
        {
            return _repos.DeleteUser(Id);
        }

        public async Task<List<OrderRecordDTO>> GetAllOrder()
        {
           return await _repos.GetAllOrder();
        }

        public Task<List<ProductDTO>> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserRecordDTO>> GetAllUsers()
        {
            return await _repos.GetAllUsers();

        }

        public Task<object> GetOrderById(int Id)
        {
             return _repos.GetOrderById(Id);

        }

        public Task<productDetalsDto> GetproductById(int Id)
        {
           return _repos.GetproductById(Id);
        }

        public async Task<object> GeUserById(int Id)
        {
           return _repos.GeUserById(Id);
        }

        public Task<object> UpdateProduct(UpdateProductDTO dto)
        {
            return _repos.UpdateProduct(dto);
        }

    
    }
}
