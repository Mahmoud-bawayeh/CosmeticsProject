using CosmeticsProject_Core.Entity;
using CosmeticsProject_Core.EntityConfigration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Core.Context
{
    public class CosmeticsOnlineStoreDBContext : DbContext
    {
        public CosmeticsOnlineStoreDBContext(DbContextOptions options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new LoginEntityConfiguration());
            modelBuilder.ApplyConfiguration(new DiscountEntityTypeConfigration());
            modelBuilder.ApplyConfiguration(new OrderEntityTypeConfigration());
            modelBuilder.ApplyConfiguration(new ProductEntityTypeConfigration());
            modelBuilder.ApplyConfiguration(new SalesReportEntityTypeConfigration());
            modelBuilder.ApplyConfiguration(new UsersEntityTypeConfigration());
            modelBuilder.ApplyConfiguration(new CartEntityTypeConfigration());



        }

        
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Discount> Discount { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<SalesReport> SalesReport { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<login> Login { get; set; }
    }
}
