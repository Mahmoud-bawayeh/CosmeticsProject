using CosmeticsProject_Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Core.EntityConfigration
{
    public class LoginEntityConfiguration : IEntityTypeConfiguration<login>
    {
        public void Configure(EntityTypeBuilder<login> builder)
        {
            builder.HasKey(x => x.Id); // assuming Id is of type int
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.IsActive).HasDefaultValue(true);
    
        }
    }
}
