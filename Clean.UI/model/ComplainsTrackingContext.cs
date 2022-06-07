using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Clean.UI.model
{
    public partial class ComplainsTrackingContext : DbContext
    {
        public ComplainsTrackingContext()
        {
        }

        public ComplainsTrackingContext(DbContextOptions<ComplainsTrackingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Case> Case { get; set; }
        public virtual DbSet<Module> Module { get; set; }
        public virtual DbSet<Process> Process { get; set; }
        public virtual DbSet<ProcessConnection> ProcessConnection { get; set; }
        public virtual DbSet<ProcessTrack> ProcessTrack { get; set; }
        public virtual DbSet<ProcessTracking> ProcessTracking { get; set; }
        public virtual DbSet<Registeration> Registeration { get; set; }
        public virtual DbSet<Screen> Screen { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=localhost; Database = ComplainsTracking; password= newmOOn@16 ; port = 5432; Username = postgres;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Case>(entity =>
            {
                entity.ToTable("Case", "look");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasColumnType("character varying");
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.ToTable("Module", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Process>(entity =>
            {
                entity.ToTable("Process", "prc");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

                entity.Property(e => e.Sorter).HasMaxLength(10);

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.Process)
                    .HasForeignKey(d => d.ScreenId)
                    .HasConstraintName("Process_FK");
            });

            modelBuilder.Entity<ProcessConnection>(entity =>
            {
                entity.ToTable("ProcessConnection", "prc");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.HasOne(d => d.ConnectedToNavigation)
                    .WithMany(p => p.ProcessConnectionConnectedToNavigation)
                    .HasForeignKey(d => d.ConnectedTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ProcessConnection_FK_1");

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.ProcessConnectionProcess)
                    .HasForeignKey(d => d.ProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ProcessConnection_FK");
            });

            modelBuilder.Entity<ProcessTrack>(entity =>
            {
                entity.ToTable("ProcessTrack", "prc");

                entity.HasIndex(e => e.CaseId)
                    .HasName("fki_FK_PT_Case");

                entity.HasIndex(e => e.StatusId)
                    .HasName("fki_FK_PT_Status");

                entity.HasIndex(e => e.UnitId)
                    .HasName("fki_FK_PT_Unit");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.ProcessTrack)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("FK_PT_Case");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ProcessTrack)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_PT_Status");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.ProcessTrack)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_PT_Unit");
            });

            modelBuilder.Entity<ProcessTracking>(entity =>
            {
                entity.ToTable("ProcessTracking", "prc");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CreatedOn).HasColumnType("timestamp with time zone");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.ReferedProcessId).HasColumnName("ReferedProcessID");

                entity.Property(e => e.Remarks).HasMaxLength(1000);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.ToUserId).HasColumnName("ToUserID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.ProcessTracking)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ProcessTracking_FK_2");

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.ProcessTracking)
                    .HasForeignKey(d => d.ProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ProcessTracking_FK");
            });

            modelBuilder.Entity<Registeration>(entity =>
            {
                entity.ToTable("Registeration", "dbo");

                entity.HasIndex(e => e.CaseId)
                    .HasName("fki_FK_R_Case");

                entity.HasIndex(e => e.StatusId)
                    .HasName("fki_FK_R_Status");

                entity.HasIndex(e => e.UnitId)
                    .HasName("fki_FK_R_Unit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.Discription).HasMaxLength(2000);

                entity.Property(e => e.Modifiedby).HasColumnType("character varying");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.Registeration)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_R_Case");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Registeration)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_R_Status");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Registeration)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_R_Unit");
            });

            modelBuilder.Entity<Screen>(entity =>
            {
                entity.ToTable("Screen", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DirectoryPath)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Screen)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("screen_fk");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("screen_parent_fk");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status", "look");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasColumnType("character varying");
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.ToTable("Unit", "look");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasColumnType("character varying");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
