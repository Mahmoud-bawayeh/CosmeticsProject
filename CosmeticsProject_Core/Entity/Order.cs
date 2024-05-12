using CosmeticsProject_Core.SharedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Core.Entity
{
    public class Order : ShaerdEntity
    {
        public float TaxAmount { get; set; }
        public float DiscountAmount { get; set; }
        public float TotalPrice { get; set; }
        public float PromoCode { get; set; }
        public int CustomerID { get; set; }
        public double TotalAmount { get; set; }
        public virtual List<ProductOrder> Products { get; set; }
    }
}
