using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RegistroCandidatura.Infra.Data.Context.Mappers;

namespace RegistroCandidatura.Infra.Data.Context
{
    public class RegistroCandidaturaContext : DbContext
    {
        private readonly IConfiguration _configuration;

        private const string DefaultConnectionString =
            "User ID=postgres;Password=admin@123;Host=db;Port=5432;Database=registro_candidatura;Pooling=true;";
        
        public DbSet<Domain.Entities.RegistroCandidatura> RegistrosCandidaturas { get; set; }

        public RegistroCandidaturaContext()
        {
            
        }

        public RegistroCandidaturaContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql(_configuration.GetConnectionString("Postgres"),b => b.SetPostgresVersion(9,6));
            optionsBuilder.UseNpgsql(DefaultConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RegistroCandidaturaMap());
        }
    }
}