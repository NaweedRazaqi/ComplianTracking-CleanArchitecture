using System;
using App.Domain.Entity.PMSEntity.look;
using App.Domain.Entity.PMSEntity.prf;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App.Persistence.Context
{
    public partial class PMSDbContext : DbContext
    {
        public PMSDbContext()
        {
        }

        public PMSDbContext(DbContextOptions<PMSDbContext> options)
            : base(options)
        {
        }

      
        public virtual DbSet<AccountHolderType> AccountHolderType { get; set; }
        public virtual DbSet<BankAccount> BankAccount { get; set; }
        public virtual DbSet<BankAccountQueue> BankAccountQueue { get; set; }
        public virtual DbSet<BankBranches> BankBranches { get; set; }
        public virtual DbSet<Banks> Banks { get; set; }
      
        public virtual DbSet<Profile> Profiles { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Server=localhost; port=5432; Database=PMS; Username=postgres; Password=newmOOn@16;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountHolderType>(entity =>
            {
                entity.ToTable("AccountHolderType", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<BankAccount>(entity =>
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
            });

            modelBuilder.Entity<BankAccountQueue>(entity =>
            {
                entity.HasKey(e => e.ProfileId)
                    .HasName("BankAccountQueue_pkey");

                entity.ToTable("BankAccountQueue", "prf");

                entity.HasIndex(e => e.ProfileId)
                    .HasName("i_bankaccountqueue_profileid");

                entity.Property(e => e.ProfileId)
                    .HasColumnName("ProfileID")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<BankBranches>(entity =>
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
            });

            modelBuilder.Entity<Banks>(entity =>
            {
                entity.HasKey(e => e.BankId)
                    .HasName("pk__banks__aa08cb1389db63f8");

                entity.ToTable("Banks", "look");

                entity.Property(e => e.BankId).ValueGeneratedNever();

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(200);
            });
            modelBuilder.Entity<Profile>(entity =>
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

               
            });

            modelBuilder.HasSequence("profile_seq", "prf").StartsAt(5013);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
