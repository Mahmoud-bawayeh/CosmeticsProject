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
    public class EmployeeServices : IEmployeeServicesInterface
    {
        private readonly IEmployeeReposInterface _repo;
        public EmployeeServices(IEmployeeReposInterface repo)
        {
            _repo = repo;
        }

        public Task CheckoutOrder(CreateOrderDTO dto)
        {
            return _repo.CheckoutOrder(dto);
        }

        public Task PrintInvoice(Invoicedto invoice)
        {
            return _repo.PrintInvoice(invoice);
        }
    }
}
