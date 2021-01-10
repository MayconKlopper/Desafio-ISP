using ISPSystem.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ISPSystem.EF.Configuration
{
    public class RentabilidadeConfiguration : IEntityTypeConfiguration<Rentabilidade>
    {
        public void Configure(EntityTypeBuilder<Rentabilidade> builder)
        {
            builder.ToTable("Rentabilidade");

            builder.HasKey(rentabilidade => rentabilidade.ID);

            builder.Property(rentabilidade => rentabilidade.Ano);
            builder.Property(rentabilidade => rentabilidade.Mes);

            #region Relacionamentos

            builder.HasOne(rentabilidade => rentabilidade.Carteira)
                .WithMany(carteira => carteira.Rentabilidades)
                .HasForeignKey(rentabilidade => rentabilidade.CarteiraID)
                .HasConstraintName("FK_Rentabilidade_Carteira")
                .IsRequired();

            #endregion
        }
    }
}
