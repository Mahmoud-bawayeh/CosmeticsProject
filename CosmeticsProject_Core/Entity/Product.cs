using CosmeticsProject_Core.SharedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Core.Entity
{
    public class Product : ShaerdEntity
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double Price { get; set; }
        public int AvailableQuantity { get; set; }
        public string Image { get; set; }
        public virtual List<ProductCart> Carts { get; set; }
        public virtual List<ProductOrder> Orders { get; set; }
    }
}
