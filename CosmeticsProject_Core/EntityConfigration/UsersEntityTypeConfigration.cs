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
    public class UsersEntityTypeConfigration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            ////not null constaints 
            builder.Property(x => x.FirstName).IsRequired(true);
            builder.Property(x => x.LastName).IsRequired(true);
            builder.Property(x => x.Email).IsRequired(true);
            builder.Property(x => x.Phone).IsRequired(true);
            builder.Property(x => x.Password).IsRequired(true);
            builder.Property(x => x.Image).IsRequired(false);
            builder.Property(x => x.Address).IsRequired(false);
            builder.Property(x => x.Birthday).IsRequired(true);
            builder.Property(x => x.NationalNo).IsRequired(false);
            builder.Property(x => x.UserType).IsRequired(false);

            //set fixed size for string property 
            builder.Property(x => x.FirstName).HasMaxLength(15);
            builder.Property(x => x.LastName).HasMaxLength(15);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.Phone).HasMaxLength(20);
            builder.Property(x => x.Password).HasMaxLength(20);
            //unique
            builder.HasIndex(x => x.Email).IsUnique(true);
            builder.HasIndex(x => x.Phone).IsUnique(true);
            builder.HasIndex(x => x.NationalNo).IsUnique(true);

            //Check Constraint 
            builder.ToTable(x => x.HasCheckConstraint("CH_Users_name", "len(FirstName)>5"));
            builder.ToTable(x => x.HasCheckConstraint("CH_Users_name", "len(LastName)>5"));

            builder.ToTable(x => x.HasCheckConstraint("Ch_Users_phone", "(len([Phone])=(10) AND ([Phone] like '079%' OR [Phone] like '078%' OR [Phone] like '077%'))"));
            builder.ToTable(x => x.HasCheckConstraint("CH_Users_Email", "Email Like '%@gmail.com%' Or Email Like  '%@outlook.com%' or Email Like '%@yahoo.com%'"));
            builder.ToTable(x => x.HasCheckConstraint("Ch_Users_password", "LEN(password) >= 8 AND LEN(password) <= 16"));
            //Default Constraint
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreationDateTime).HasDefaultValue(DateTime.Now);

        }
    }
}
