using Clean.Domain.Entity.prc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.Persistence.Configuration.Prc
{
    public class ComplianTypeConfiguration : IEntityTypeConfiguration<ComplainType>
    {
        public void Configure(EntityTypeBuilder<ComplainType> entity)
        {

            entity.ToTable("ComplainType", "prc");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Name).HasColumnType("character varying");
        }
    }
}
