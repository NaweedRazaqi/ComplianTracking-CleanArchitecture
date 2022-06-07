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
    public class BankConfiguration : IEntityTypeConfiguration<Banks>
    {
        public void Configure(EntityTypeBuilder<Banks> entity)
        {
            entity.HasKey(e => e.BankId)
                    .HasName("pk__banks__aa08cb1389db63f8");

            entity.ToTable("Banks", "look");

            entity.Property(e => e.BankId).ValueGeneratedNever();

            entity.Property(e => e.BankName)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
