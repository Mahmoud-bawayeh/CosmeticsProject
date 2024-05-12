using CosmeticsProject_Core.SharedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Core.Entity
{
    public class ProductCart: ShaerdEntity
    {
        public virtual Cart Carts { get; set; }
        public virtual Product Products { get; set; }
        public int qtn { get; set; }  
        public string? Note { get; set; }
    }
}
