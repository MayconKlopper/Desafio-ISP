using ISPSystem.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ISPSystem.EF.Configuration
{
    public class SolicitacaoConfiguration : IEntityTypeConfiguration<Solicitacao>
    {
        public void Configure(EntityTypeBuilder<Solicitacao> builder)
        {
            builder.ToTable("Solicitacao");

            builder.HasKey(solicitacao => solicitacao.ID);

            builder.Property(solicitacao => solicitacao.Status);

            #region Relacionamentos

            builder.HasOne(solicitacao => solicitacao.Participante)
                .WithMany(participante => participante.Solicitacoes)
                .HasForeignKey(solicitacao => solicitacao.ParticipanteID)
                .HasConstraintName("FK_Solicitacao_Participante")
                .IsRequired();

            #endregion
        }
    }
}
