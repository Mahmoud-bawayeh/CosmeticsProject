using CosmeticsProject_Core.SharedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Core.Entity
{
    public class Cart : ShaerdEntity 
    {
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public DateTime AddedDate { get; set; }
        public int Quantity { get; set; }
        public virtual List<ProductCart> Products { get; set; }
        public virtual Users User { get; set; }
    }
}
