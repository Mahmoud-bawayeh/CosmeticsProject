using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Core.Enums
{
    public class cosmaticsLookups
    {
        public class CosmaticsLookup
        {
            public enum UserType
            {
                Admin = 10,
                Employee,
                Client
            }

            public enum PaymentMethod
            {
                MasterCard = 20,
                ZainCash,
                OrangeMoney,
                paypal
            }
            public enum ProductRequestStatus
            {
                Pending = 30,
                Approved,
                Rejected
            }
            public enum ProductStatus
            {
                Active = 40,
                Inactive
            }

            public enum OrderStatus
            {
                Pending = 50,
                Shipped,
                Delivered
            }
            public enum City
            {
                Amman = 60,
                Irbid,
                Zarqa,
                Aqaba,
                Salt,
                Karak,
                Ajlon,
                Mafraq,
                Tafila

            }
        }
    }
}