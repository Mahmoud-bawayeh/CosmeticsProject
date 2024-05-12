using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CosmeticsOnlineStore_Core.DTO.OrderDTO
{
    public class CreateOrderByClint
    {
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public DateTime AddedDate { get; set; }
        public int Quantity { get; set; }


    }
}
