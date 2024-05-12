using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Core.SharedEntity
{
    public class ShaerdEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool Status { get; set; }
        public DateTime CreationDateTime { get; set; }
    }
}
