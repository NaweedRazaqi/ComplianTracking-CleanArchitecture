using App.Domain.Entity.doc;
using App.Domain.Entity.look;
using Clean.Common;
using Clean.Domain.Entity.look;
using Clean.Persistence.Context;
using Clean.Persistence.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Persistence.Context
{
    public class AppDbContext : BaseContext
    {
        public static readonly ILoggerFactory DbLogger = LoggerFactory.Create(ex => ex.AddConsole());

        public AppDbContext(DbContextOptions<AppDbContext> options, UserManager<AppUser> manager) : base(options, manager)
        {

        }

        public virtual DbSet<Clean.Domain.Entity.look.Country> Countries { get; set; }

        public virtual DbSet<Clean.Domain.Entity.look.District> Districts { get; set; }

        public virtual DbSet<Occupation> Occupations { get; set; }
        // public virtual DbSet<Office> Offices { get; set; }
        //  public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Domain.Entity.look.Organization> Organizations { get; set; }
        public virtual DbSet<Clean.Domain.Entity.look.Province> Provinces { get; set; }
        public virtual DbSet<App.Domain.Entity.look.Unit> Units { get; set; }
        public virtual DbSet<Clean.Domain.Entity.prc.ComplainType> ComplainTypes { get; set; }
        public virtual DbSet<App.Domain.Entity.look.Status> CaseStatus { get; set; }
        public virtual DbSet<App.Domain.Entity.Complains.Registeration> CaseRegister { get; set; }
        // screens

        //public virtual DbSet<Module> Modules { get; set; }
        //public virtual DbSet<RoleScreen> RoleScreens { get; set; }
        //public virtual DbSet<Screen> Screens { get; set; }
        //   public virtual DbSet<App.Domain.Entity.Complains.Profile> Profiles { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseLoggerFactory(DbLogger);
                options.EnableSensitiveDataLogging(true);
                //options.UseNpgsql("Server=localhost;Port=5432;Database=ComplainsTracking;User Id=postgres;Password=nSia@123#$;");
                options.UseNpgsql(AppConfig.BaseConnectionString, (opts) =>
                {

                });
            }
            base.OnConfiguring(options);
        }
    }
}
