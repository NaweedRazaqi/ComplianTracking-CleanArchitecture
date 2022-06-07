using Clean.Domain.Entity.look;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Persistence.Configuration.Look
{

    public class RoleScreenConfiguration : IEntityTypeConfiguration<RoleScreen>
    {
        public void Configure(EntityTypeBuilder<RoleScreen> entity)
        {
            entity.ToTable("RoleScreen", "look");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .UseIdentityAlwaysColumn();

            entity.Property(e => e.RoleId).HasColumnName("RoleID");

            entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

            entity.HasOne(d => d.Screen)
                .WithMany(p => p.RoleScreen)
                .HasForeignKey(d => d.ScreenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("_RoleScreen__FK");
        }
    }
}
