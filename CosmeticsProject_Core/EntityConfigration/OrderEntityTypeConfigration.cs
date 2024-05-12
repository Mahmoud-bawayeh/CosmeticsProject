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
    public class OrderEntityTypeConfigration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            //not null constaints
            //not null constaints
            builder.Property(x => x.CustomerID).IsRequired(true);
            builder.HasCheckConstraint("Ch_Order_TotalAmount", "TotalAmount >= 1");

            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreationDateTime).HasDefaultValue(DateTime.Now);
        }
    }
}
