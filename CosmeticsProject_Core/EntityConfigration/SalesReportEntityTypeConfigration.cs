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
    public class SalesReportEntityTypeConfigration : IEntityTypeConfiguration<SalesReport>
    {
        public void Configure(EntityTypeBuilder<SalesReport> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            //not null constaints 
            builder.Property(x => x.ReportDate).HasDefaultValue(DateTime.Now);
            builder.ToTable(x => x.HasCheckConstraint("_SalesReport_TotalOrders_CH", "TotalOrders >= 1"));
        }
    }
}
