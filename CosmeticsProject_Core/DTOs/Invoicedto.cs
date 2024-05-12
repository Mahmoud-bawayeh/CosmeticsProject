using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.DTO
{
    public class Invoicedto
    {
        public DateTime ReportDate { get; set; }
        public double TotalSales { get; set; }
        public double TotalOrders { get; set; }
    }
}
