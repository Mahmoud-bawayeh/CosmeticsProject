using CosmeticsProject_Core.SharedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Core.Entity
{
    public class ProductOrder : ShaerdEntity
    {
        public int cartID { get; set; }
        public virtual Product Products { get; set; }
        public virtual Order Orders { get; set; }

    }
}
