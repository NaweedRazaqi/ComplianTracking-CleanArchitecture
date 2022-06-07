using App.Domain.Entity.PMSEntity.look;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Persistence.Configuration.PMS
{
    public class AccountHolderTypeConfiguration : IEntityTypeConfiguration<AccountHolderType>
    {
        public void Configure(EntityTypeBuilder<AccountHolderType> entity)
        {
            entity.ToTable("AccountHolderType", "look");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .ValueGeneratedNever();

            entity.Property(e => e.Identifier)
                            .IsRequired()
                            .HasMaxLength(200);
        }
    }

    
}
