using CosmeticsOnlineStore_Core.DTO.OrderDTO;
using CosmeticsProject_Core.Context;
using CosmeticsProject_Core.Entity;
using CosmeticsProject_Core.IRepos;
using CosmeticsProject_Infra.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Infra.Repos
{
    
    public class ClientRepos : IClientReposInterface
    {
        private readonly CosmeticsOnlineStoreDBContext _dbContext;
        public ClientRepos(CosmeticsOnlineStoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateOrder(CreateOrderByClint dto)
        {
            var or = new Cart();
            or.CustomerID = dto.CustomerID;
            or.AddedDate = dto.AddedDate;
            or.ProductID = dto.ProductID;
            or.Quantity = dto.Quantity;
            await _dbContext.Cart.AddAsync(or);
            await _dbContext.SaveChangesAsync();
        }
        
        public Task<OrderDetailsDTO> GetOrderDetailsByOrderId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
