using CosmeticsOnlineStore_Core.DTO.OrderDTO;
using CosmeticsOnlineStore_Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Core.IRepos
{
    public interface IEmployeeReposInterface
    {
        Task CheckoutOrder(CreateOrderDTO dto);
        Task PrintInvoice(Invoicedto invoice);
    }
}
