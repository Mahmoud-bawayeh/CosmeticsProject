using CosmeticsProject_Core.SharedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Core.Entity
{
    public class Users : ShaerdEntity
    {
        public string ProfileImagePath;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string Image { get; set; }
        public string NationalNo { get; set; }
        public string UserType { get; set; }
        public double TotalSpent { get; set; }
        public virtual List<Cart> Carts {  get; set; } 
        public virtual List<Discount> Discounts { get; set; }
        public virtual List<login> Login { get; set; }
    }
}
