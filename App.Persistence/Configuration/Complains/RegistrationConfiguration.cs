using App.Domain.Entity.Complains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Persistence.Configuration.Complains
{
   public class RegistrationConfiguration : IEntityTypeConfiguration<Registeration>
    {
        public void Configure(EntityTypeBuilder<Registeration> entity)
        {
            entity.ToTable("Registeration", "dbo");

            entity.HasIndex(e => e.ComplainTypeId)
                .HasName("fki_FK_R_ComplainType");

            entity.HasIndex(e => e.StatusId)
                .HasName("fki_FK_R_Status");

            entity.HasIndex(e => e.UnitId)
                .HasName("fki_FK_R_Unit");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Address).HasMaxLength(500);

            entity.Property(e => e.Discription).HasMaxLength(2000);

            entity.Property(e => e.FatherName).HasMaxLength(250);

            entity.Property(e => e.Modifiedby).HasColumnType("character varying");

            entity.Property(e => e.Name).HasMaxLength(250);

            entity.Property(e => e.Phone).HasColumnType("character varying");

            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

            entity.Property(e => e.StatusId).HasColumnName("StatusID");

            entity.Property(e => e.UnitId).HasColumnName("UnitID");

            entity.Property(e => e.IsLastStep).HasColumnName("IsLastStep");

            entity.HasOne(d => d.Profile)
                .WithMany(p => p.Registeration)
                .HasForeignKey(d => d.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_R_Profile");

            entity.HasOne(d => d.Status)
                .WithMany(p => p.Registeration)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_R_Status");

            entity.HasOne(d => d.Unit)
                .WithMany(p => p.Registeration)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK_R_Unit");
        }
    }
}
