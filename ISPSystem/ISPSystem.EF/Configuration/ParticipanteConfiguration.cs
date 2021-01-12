using ISPSystem.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ISPSystem.EF.Configuration
{
    public class ParticipanteConfiguration : IEntityTypeConfiguration<Participante>
    {

        public void Configure(EntityTypeBuilder<Participante> builder)
        {
            builder.ToTable("Participante");

            builder.HasKey(participante => participante.ID);

            builder.Property(participante => participante.Idade);
            builder.Property(participante => participante.Nome);

            #region Relacionamentos

            builder.HasOne(participante => participante.Carteira)
                .WithOne(carteira => carteira.Participante)
                .HasForeignKey<Participante>(participante => participante.CarteiraID)
                .HasConstraintName("FK_Participante_Carteira")
                .IsRequired(false);

            builder.HasOne(participante => participante.Perfil)
                .WithOne(perfil => perfil.Participante)
                .HasForeignKey<Participante>(participante => participante.PerfilID)
                .HasConstraintName("FK_Participante_Perfil")
                .IsRequired(false);

            #endregion
        }
    }
}
