using CosmeticsProject_Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Core.EntityConfigration
{
    public class CartEntityTypeConfigration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {

            //primary key 
            builder.HasKey(x => x.Id); // adding primary key 
            builder.Property(x => x.Id).UseIdentityColumn(); // applaying auto increment
                                                             // 

            //check 
            builder.Property(x => x.Status).IsRequired(true);
            builder.Property(x => x.ProductID).IsRequired(true);
            builder.Property(x => x.CustomerID).IsRequired(true);
            builder.Property(x => x.Quantity).IsRequired(true);



            builder.Property(x => x.IsActive).HasDefaultValue(true);

            builder.Property(x => x.CreationDateTime).HasDefaultValue(DateTime.Now);

        }
    }
}
