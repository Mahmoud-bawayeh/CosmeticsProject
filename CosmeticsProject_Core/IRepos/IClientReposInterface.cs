﻿using CosmeticsOnlineStore_Core.DTO.OrderDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Core.IRepos
{
    public interface IClientReposInterface
    {
        Task CreateOrder(CreateOrderByClint dto);
        Task<OrderDetailsDTO> GetOrderDetailsByOrderId(int Id);
    }
}