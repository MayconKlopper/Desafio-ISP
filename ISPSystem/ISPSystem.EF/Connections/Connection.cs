using ISPSystem.DomainEntities;
using ISPSystem.EF.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace ISPSystem.EF.Connections
{
    public class Connection : DbContext
    {
        public DbSet<Participante> Participante { get; private set; }
        public DbSet<Solicitacao> Solicitacao { get; private set; }
        public DbSet<Carteira> Carteira { get; private set; }
        public DbSet<Rentabilidade> Rentabilidade { get; private set; }
        public DbSet<Perfil> Perfil { get; private set; }
        public DbSet<Questao> Questao { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ParticipanteConfiguration());
            modelBuilder.ApplyConfiguration(new SolicitacaoConfiguration());
            modelBuilder.ApplyConfiguration(new CarteiraConfiguration());
            modelBuilder.ApplyConfiguration(new RentabilidadeConfiguration());
            modelBuilder.ApplyConfiguration(new PerfilConfiguration());
            modelBuilder.ApplyConfiguration(new QuestaoConfiguration());

            modelBuilder.Entity<Perfil>().HasData(
                new Perfil { ID = 1, Descricao = "Conservador", Pontuacao = 20 },
                new Perfil { ID = 2, Descricao = "Moderado", Pontuacao = 30 },
                new Perfil { ID = 3, Descricao = "Agressivo", Pontuacao = 40 }
                );

            modelBuilder.Entity<Carteira>().HasData(
                new Carteira { ID = 1, PerfilID = 1, Composicao = "100% Renda Fixa", Descricao = "MAX Renda Fixa" },
                new Carteira { ID = 2, PerfilID = 2, Composicao = "50% Renda Fixa e 50% Renda Variável", Descricao = "MIX Renda Fixa/Renda Variável" },
                new Carteira { ID = 3, PerfilID = 3, Composicao = "100% Renda Variável", Descricao = "MAX Renda Variável" }
                );

            modelBuilder.Entity<Questao>().HasData(
                new Questao { ID = 1, Descricao = "Quanto de interesse você tem em investir em renda variável para o longo prazo?" },
                new Questao { ID = 2, Descricao = "Quanto de interesse você tem em investir em ativos de renda fixa para o longo prazo?" },
                new Questao { ID = 3, Descricao = "Quanto de interese você tem em investir em títulos públicos para o longo prazo?" },
                new Questao { ID = 4, Descricao = "Para o longo prazo e sua aposentadoria, você aceitaria o risco maior da renda variável?" },
                new Questao { ID = 5, Descricao = "Para o longo prazo e sua aposentadoria, você prefere se expor menos a riscos e ficar mais na renda fixa?" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
