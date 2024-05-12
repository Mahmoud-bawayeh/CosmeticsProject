using CosmeticsOnlineStore_Core.DTO;
using CosmeticsOnlineStore_Core.DTO.OrderDTO;
using CosmeticsProject_Core.IRepos;
using CosmeticsProject_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Infra.Services
{
    public class ClintServices : IClientIServicesnterface
    {
        private readonly IClientReposInterface _repos;
        public ClintServices(IClientReposInterface repos)
        {
            _repos = repos;
        }
        public Task CreateOrder(CreateOrderByClint dto)
        {
            return _repos.CreateOrder(dto);

        }

        public Task<OrderDetailsDTO> GetOrderDetailsByOrderId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
