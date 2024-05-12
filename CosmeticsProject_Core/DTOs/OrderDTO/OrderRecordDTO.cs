﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.DTO.OrderRecordDTO
{
    public class OrderRecordDTO
    {
        public int OrderId { get; set; }
        public float TaxAmount { get; set; }
        public float DiscountAmount { get; set; }
        public float TotalPrice { get; set; }
        public int CustomerID { get; set; }
        public double TotalAmount { get; set; }
    }
}
