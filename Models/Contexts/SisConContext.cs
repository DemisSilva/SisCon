using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SisCon.Models.Entities;
using SisCon.Models.EntityConfigurations;

namespace SisCon.Models.Contexts
{
    public class SisConContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public SisConContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Profissional> Profissionais => Set<Profissional>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DB_SIS_CON"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProfissionalConfiguration());
        }

    }
}