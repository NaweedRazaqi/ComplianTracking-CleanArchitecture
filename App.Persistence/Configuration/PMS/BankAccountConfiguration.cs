using App.Domain.Entity.PMSEntity.prf;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Persistence.Configuration.PMS
{
    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> entity)
        {
            entity.ToTable("BankAccount", "prf");

            entity.HasIndex(e => e.ProfileId)
                .HasName("i_bankaccount_profileid");

            entity.HasIndex(e => new { e.AccountNumber, e.BranchId })
                .HasName("uq_bankaccount");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasDefaultValueSql("nextval('prf.bankaccount_seq'::regclass)");

            entity.Property(e => e.AccountHolderTypeId).HasColumnName("AccountHolderTypeID");

            entity.Property(e => e.AccountNumber).HasMaxLength(150);

            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

            entity.HasOne(d => d.AccountHolderType)
                .WithMany(p => p.BankAccount)
                .HasForeignKey(d => d.AccountHolderTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountHolderType_AccountHolderTypeID");

            entity.HasOne(d => d.Branch)
                .WithMany(p => p.BankAccount)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("BankAccount_BranchId_fkey");

            entity.HasOne(d => d.Profile)
                .WithMany(p => p.BankAccount)
                .HasForeignKey(d => d.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankAccount_Profile");
        }
    }
}
