using CosmeticsOnlineStore_Core.DTO;
using CosmeticsOnlineStore_Core.DTO.OrderDTO;
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
    public class EmployeeRepos : IEmployeeReposInterface
    {
        private readonly CosmeticsOnlineStoreDBContext _dbContext;
        public EmployeeRepos(CosmeticsOnlineStoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CheckoutOrder(CreateOrderDTO dto)
        {
            var or = new Order();
            or.Id = dto.OrderId;
            or.TaxAmount = dto.TaxAmount;
            or.DiscountAmount = dto.DiscountAmount;
            or.TotalPrice = dto.TotalPrice;
            or.PromoCode = dto.PromoCode;
            or.CustomerID = dto.CustomerID;
            or.TotalAmount = dto.TotalAmount;


            await _dbContext.Order.AddAsync(or);
            await _dbContext.SaveChangesAsync();


        }
 
        public async Task PrintInvoice(Invoicedto invoice)
        {
            var prin = new SalesReport();
            prin.TotalSales = invoice.TotalSales;
            prin.TotalOrders = invoice.TotalOrders;
            prin.ReportDate = invoice.ReportDate;
            
            await _dbContext.SalesReport.AddAsync(prin);
            await _dbContext.SaveChangesAsync();

        }
    }
}
