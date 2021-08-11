
using APIEstudos.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIEstudo.Data.EntityConfiguration
{
    public class TipoClienteConfiguration : IEntityTypeConfiguration<TipoCliente>
    {
        public void Configure(EntityTypeBuilder<TipoCliente> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).HasMaxLength(255).IsRequired();
            builder.HasData(
                new TipoCliente() { ID = 1, Nome = "Desenvolvedor" },
                new TipoCliente() { ID = 2, Nome = "Jogador" },
                new TipoCliente() { ID = 3, Nome = "Allien" }
                );


        }
    }
}
