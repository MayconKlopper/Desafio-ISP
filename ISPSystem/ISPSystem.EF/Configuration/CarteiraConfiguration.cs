using ISPSystem.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ISPSystem.EF.Configuration
{
    public class CarteiraConfiguration : IEntityTypeConfiguration<Carteira>
    {
        public void Configure(EntityTypeBuilder<Carteira> builder)
        {
            builder.ToTable("Carteira");

            builder.HasKey(carteira => carteira.ID);

            builder.Property(carteira => carteira.Composicao);
            builder.Property(carteira => carteira.Descricao);

            #region Relacionamentos

            builder.HasOne(carteira => carteira.Perfil)
                .WithMany(perfil => perfil.Carteiras)
                .HasForeignKey(carteira => carteira.PerfilID)
                .HasConstraintName("FK_Carteira_Perfil")
                .IsRequired();

            #endregion
        }
    }
}
