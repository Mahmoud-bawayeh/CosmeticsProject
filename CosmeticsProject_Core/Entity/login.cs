using CosmeticsProject_Core.SharedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Core.Entity
{
    public class login: ShaerdEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual Users Users { get; set; }
    }
}
