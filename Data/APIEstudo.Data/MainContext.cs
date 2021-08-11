
using APIEstudos.Domain;
using Microsoft.EntityFrameworkCore;

namespace APIEstudo.Data
{
    public class MainContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<TipoCliente> TipoCliente { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            if (!option.IsConfigured)
            {
                // var config = ConfigurationBuilder().
                option.UseSqlServer("Server=localhost;Database=APIEstudosDB;Trusted_Connection=True");

            }
        }
        public MainContext(DbContextOptions<MainContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(MainContext).Assembly);

        }



    }
}
