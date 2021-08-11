using APIEstudos.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIEstudo.Data.EntityConfiguration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Idade).IsRequired().HasMaxLength(3);
            builder.Property(x => x.Ativo).IsRequired();
            builder.HasOne(x => x.TipoCliente)
                .WithMany(x => x.Clientes)
                .HasForeignKey(x => x.TipoClienteID);

        }
    }
}
