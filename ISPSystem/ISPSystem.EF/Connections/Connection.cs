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
                new Perfil { ID = 1, Descricao = "Conservador", Pontuacao = 15 },
                new Perfil { ID = 2, Descricao = "Moderado", Pontuacao = 30 },
                new Perfil { ID = 3, Descricao = "Agressivo", Pontuacao = 40 },
                new Perfil { ID = 4, Descricao = "Ultra Conservador", Pontuacao = 0 }
                );

            modelBuilder.Entity<Carteira>().HasData(
                new Carteira { ID = 1, PerfilID = 1, Composicao = "100% Renda Fixa", Descricao = "MAX Renda Fixa" },
                new Carteira { ID = 2, PerfilID = 2, Composicao = "50% Renda Fixa e 50% Renda Variável", Descricao = "MIX Renda Fixa/Renda Variável" },
                new Carteira { ID = 3, PerfilID = 3, Composicao = "100% Renda Variável", Descricao = "MAX Renda Variável" },
                new Carteira { ID = 4, PerfilID = 3, Composicao = "80% Renda Variável e 20% Criptomoeda", Descricao = "MIX Renda Variável/Criptomoeda" },
                new Carteira { ID = 5, PerfilID = 4, Composicao = "50% Poupança e 50% Tesouro SELIC simples", Descricao = "MIX Poupana/Tesouro SELIC" }
                );

            modelBuilder.Entity<Questao>().HasData(
                new Questao { ID = 1, Descricao = "Quanto de interesse você tem em investir em renda variável para o longo prazo?" },
                new Questao { ID = 2, Descricao = "Quanto de interesse você tem em investir em ativos de renda fixa para o longo prazo?" },
                new Questao { ID = 3, Descricao = "Quanto de interese você tem em investir em títulos públicos para o longo prazo?" },
                new Questao { ID = 4, Descricao = "Para o longo prazo e sua aposentadoria, você aceitaria o risco maior da renda variável?" },
                new Questao { ID = 5, Descricao = "Para o longo prazo e sua aposentadoria, você prefere se expor menos a riscos e ficar mais na renda fixa?" }
                );

            modelBuilder.Entity<Rentabilidade>().HasData(
                new Rentabilidade { ID = 1, CarteiraID = 1, Ano = 2020, Mes = "Janeiro", Porcentagem = -0.05m },
                new Rentabilidade { ID = 2, CarteiraID = 1, Ano = 2020, Mes = "Fevereiro", Porcentagem = -0.07m },
                new Rentabilidade { ID = 3, CarteiraID = 1, Ano = 2020, Mes = "Março", Porcentagem = -0.08m },
                new Rentabilidade { ID = 4, CarteiraID = 1, Ano = 2020, Mes = "Abril", Porcentagem = -0.10m },
                new Rentabilidade { ID = 5, CarteiraID = 1, Ano = 2020, Mes = "Maio", Porcentagem = 0.10m },
                new Rentabilidade { ID = 6, CarteiraID = 1, Ano = 2020, Mes = "Junho", Porcentagem = 0.024m },
                new Rentabilidade { ID = 7, CarteiraID = 1, Ano = 2020, Mes = "Julho", Porcentagem = 0.136m },
                new Rentabilidade { ID = 8, CarteiraID = 1, Ano = 2020, Mes = "Agosto", Porcentagem = -0.035m },
                new Rentabilidade { ID = 9, CarteiraID = 1, Ano = 2020, Mes = "Setembro", Porcentagem = -0.054m },
                new Rentabilidade { ID = 10, CarteiraID = 1, Ano = 2020, Mes = "Outubro", Porcentagem = 0.03m },
                new Rentabilidade { ID = 11, CarteiraID = 1, Ano = 2020, Mes = "Novembro", Porcentagem = 0.07m },
                new Rentabilidade { ID = 12, CarteiraID = 1, Ano = 2020, Mes = "Dezembro", Porcentagem = 0.08m },
                new Rentabilidade { ID = 13, CarteiraID = 2, Ano = 2020, Mes = "Janeiro", Porcentagem = -0.14m },
                new Rentabilidade { ID = 14, CarteiraID = 2, Ano = 2020, Mes = "Fevereiro", Porcentagem = -0.16m },
                new Rentabilidade { ID = 15, CarteiraID = 2, Ano = 2020, Mes = "Março", Porcentagem = -0.086m },
                new Rentabilidade { ID = 16, CarteiraID = 2, Ano = 2020, Mes = "Abril", Porcentagem = -0.102m },
                new Rentabilidade { ID = 17, CarteiraID = 2, Ano = 2020, Mes = "Maio", Porcentagem = 0.02m },
                new Rentabilidade { ID = 18, CarteiraID = 2, Ano = 2020, Mes = "Junho", Porcentagem = 0.038m },
                new Rentabilidade { ID = 19, CarteiraID = 2, Ano = 2020, Mes = "Julho", Porcentagem = 0.266m },
                new Rentabilidade { ID = 20, CarteiraID = 2, Ano = 2020, Mes = "Agosto", Porcentagem = -0.065m },
                new Rentabilidade { ID = 21, CarteiraID = 2, Ano = 2020, Mes = "Setembro", Porcentagem = -0.084m },
                new Rentabilidade { ID = 22, CarteiraID = 2, Ano = 2020, Mes = "Outubro", Porcentagem = 0.06m },
                new Rentabilidade { ID = 23, CarteiraID = 2, Ano = 2020, Mes = "Novembro", Porcentagem = 0.16m },
                new Rentabilidade { ID = 24, CarteiraID = 2, Ano = 2020, Mes = "Dezembro", Porcentagem = 0.145m },
                new Rentabilidade { ID = 25, CarteiraID = 3, Ano = 2020, Mes = "Janeiro", Porcentagem = -0.234m },
                new Rentabilidade { ID = 26, CarteiraID = 3, Ano = 2020, Mes = "Fevereiro", Porcentagem = -0.236m },
                new Rentabilidade { ID = 27, CarteiraID = 4, Ano = 2020, Mes = "Janeiro", Porcentagem = 0.143m },
                new Rentabilidade { ID = 28, CarteiraID = 4, Ano = 2020, Mes = "Fevereiro", Porcentagem = 0.165m }
                );

            modelBuilder.Entity<Participante>().HasData(
                new Participante { ID = 1, PerfilID = 1, CarteiraID = 1, Nome = "Maycon Klopper de Carvalho", Idade = 25 }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
