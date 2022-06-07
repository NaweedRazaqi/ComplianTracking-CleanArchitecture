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
    public class BankAccountQueueConfiguration : IEntityTypeConfiguration<BankAccountQueue>
    {
        public void Configure(EntityTypeBuilder<BankAccountQueue> entity)
        {
            entity.HasKey(e => e.ProfileId)
                     .HasName("BankAccountQueue_pkey");

            entity.ToTable("BankAccountQueue", "prf");

            entity.HasIndex(e => e.ProfileId)
                .HasName("i_bankaccountqueue_profileid");

            entity.Property(e => e.ProfileId)
                .HasColumnName("ProfileID")
                .ValueGeneratedNever();
        }
    }
}
