using ISPSystem.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ISPSystem.EF.Configuration
{
    public class QuestaoConfiguration : IEntityTypeConfiguration<Questao>
    {
        public void Configure(EntityTypeBuilder<Questao> builder)
        {
            builder.ToTable("Questao");

            builder.HasKey(questao => questao.ID);

            builder.Property(questao => questao.Descricao);
        }
    }
}
