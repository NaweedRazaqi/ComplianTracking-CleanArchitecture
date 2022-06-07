using App.Domain.Entity.PMSEntity.prf;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistence.Configuration.PMS
{

    public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> entity)
        {
            entity.ToTable("Profile", "prf");

            entity.HasIndex(e => e.Code)
                .HasName("profile_code_ix");

            entity.HasIndex(e => e.HashKey)
                            .HasName("unique_hashkey")
                            .IsUnique();

            entity.Property(e => e.Id)
                            .HasColumnName("ID")
                            .HasDefaultValueSql("nextval('prf.profile_seq'::regclass)");

            entity.Property(e => e.BiometricId).HasColumnName("BiometricID");

            entity.Property(e => e.BirthLocationId).HasColumnName("BirthLocationID");

            entity.Property(e => e.CensusId).HasColumnName("CensusID");

            entity.Property(e => e.Code).HasMaxLength(500);

            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

            entity.Property(e => e.DoB).HasColumnType("date");

            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");

            entity.Property(e => e.EducationDegreeId).HasColumnName("EducationDegreeID");

            entity.Property(e => e.FatherName)
                            .IsRequired()
                            .HasMaxLength(500);

            entity.Property(e => e.FirstName)
                            .IsRequired()
                            .HasMaxLength(500);

            entity.Property(e => e.GenderId).HasColumnName("GenderID");

            entity.Property(e => e.GrandFatherName)
                            .IsRequired()
                            .HasMaxLength(500);

            entity.Property(e => e.HashKey).HasMaxLength(500);

            entity.Property(e => e.LastName)
                            .IsRequired()
                            .HasMaxLength(500);

            entity.Property(e => e.Nid)
                            .IsRequired()
                            .HasColumnName("NID")
                            .HasMaxLength(500);

            entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");

            //entity.HasOne(d => d.Biometric)
            //                .WithMany(p => p.ProfileNavigation)
            //                .HasForeignKey(d => d.BiometricId)
            //                .HasConstraintName("FK_Profile_BiometricHistory");

            //entity.HasOne(d => d.BirthLocation)
            //                .WithMany(p => p.Profile)
            //                .HasForeignKey(d => d.BirthLocationId)
            //                .OnDelete(DeleteBehavior.ClientSetNull)
            //                .HasConstraintName("FK_Profile_BirthLocationID");

            //entity.HasOne(d => d.District)
            //                .WithMany(p => p.Profile)
            //                .HasForeignKey(d => d.DistrictId)
            //                .OnDelete(DeleteBehavior.ClientSetNull)
            //                .HasConstraintName("FK_Profile_District");

            //entity.HasOne(d => d.DocumentType)
            //                .WithMany(p => p.Profile)
            //                .HasForeignKey(d => d.DocumentTypeId)
            //                .OnDelete(DeleteBehavior.ClientSetNull)
            //                .HasConstraintName("FK_Profile_DocumentTypeID");

            //entity.HasOne(d => d.EducationDegree)
            //                .WithMany(p => p.Profile)
            //                .HasForeignKey(d => d.EducationDegreeId)
            //                .OnDelete(DeleteBehavior.ClientSetNull)
            //                .HasConstraintName("FK_Profile_EducationDegree");

            //entity.HasOne(d => d.Gender)
            //                .WithMany(p => p.Profile)
            //                .HasForeignKey(d => d.GenderId)
            //                .OnDelete(DeleteBehavior.ClientSetNull)
            //                .HasConstraintName("FK_Profile_Gender");

            //entity.HasOne(d => d.Organization)
            //                .WithMany(p => p.Profile)
            //                .HasForeignKey(d => d.OrganizationId)
            //                .HasConstraintName("FK_Profile_Organization");
        }
    }
}
