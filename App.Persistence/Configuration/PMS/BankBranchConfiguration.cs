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

    public class BankBranchConfiguration : IEntityTypeConfiguration<BankBranches>
    {
        public void Configure(EntityTypeBuilder<BankBranches> entity)
        {
            entity.HasKey(e => e.BranchId)
                    .HasName("pk__bankbran__a1682fc5ade460d8");

            entity.ToTable("BankBranches", "look");

            entity.Property(e => e.BranchId).ValueGeneratedNever();

            entity.Property(e => e.Address).HasMaxLength(500);

            entity.Property(e => e.BranchName)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

            entity.HasOne(d => d.Bank)
                .WithMany(p => p.BankBranches)
                .HasForeignKey(d => d.BankId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("BankBranches_BankId_fkey");
        }
    }
}
