using CosmeticsOnlineStore_Core.DTO.OrderRecordDTO;
using CosmeticsOnlineStore_Core.DTO.productsDTO;
using CosmeticsOnlineStore_Core.DTO.UserDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Core.IServices
{
    public interface IAdminServicesInterface
    {
        Task<productDetalsDto> GetproductById(int Id);
        Task CreateProduct(CreateProductDTO product);
        Task<object> UpdateProduct(UpdateProductDTO dto);
        Task DeleteProduct(int Id);

        Task<List<UserRecordDTO>> GetAllUsers();
        Task<object> GeUserById(int Id);
        Task<Task<object>> DeleteUser(int Id);
        Task<List<OrderRecordDTO>> GetAllOrder();
        Task<object> GetOrderById(int Id);

    }
}
