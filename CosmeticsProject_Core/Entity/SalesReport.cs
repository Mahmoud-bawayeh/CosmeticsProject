using CosmeticsProject_Core.SharedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Core.Entity
{
     public class SalesReport: ShaerdEntity
    {
        public DateTime ReportDate { get; set; }
        public double TotalSales { get; set; }
        public double TotalOrders { get; set; }
    }
}
