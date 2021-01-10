using ISPSystem.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ISPSystem.EF.Configuration
{
    public class PerfilConfiguration : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.ToTable("Perfil");

            builder.HasKey(perfil => perfil.ID);

            builder.Property(perfil => perfil.Descricao);
            builder.Property(perfil => perfil.Pontuacao);
        }
    }
}
