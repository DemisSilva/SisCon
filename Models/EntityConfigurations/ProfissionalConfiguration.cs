using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SisCon.Models.Entities;

namespace SisCon.Models.EntityConfigurations
{
    public class ProfissionalConfiguration : IEntityTypeConfiguration<Profissional>
    {
        public void Configure(EntityTypeBuilder<Profissional> builder)
        {
            builder.ToTable("TB_PROFISSIONAL");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.CRM)
                .HasMaxLength(20)
                .IsRequired();

            builder.HasIndex(p => p.CRM)
                .IsUnique();
        }
    }
}