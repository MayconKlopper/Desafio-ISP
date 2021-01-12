using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ISPSystem.EF.Migrations
{
    public partial class Tabela_Questao_E_Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questao",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questao", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "ID", "Descricao", "Pontuacao" },
                values: new object[,]
                {
                    { 1, "Conservador", 20 },
                    { 2, "Moderado", 30 },
                    { 3, "Agressivo", 40 }
                });

            migrationBuilder.InsertData(
                table: "Questao",
                columns: new[] { "ID", "Descricao" },
                values: new object[,]
                {
                    { 1, "Quanto de interesse você tem em investir em renda variável para o longo prazo?" },
                    { 2, "Quanto de interesse você tem em investir em ativos de renda fixa para o longo prazo?" },
                    { 3, "Quanto de interese você tem em investir em títulos públicos para o longo prazo?" },
                    { 4, "Para o longo prazo e sua aposentadoria, você aceitaria o risco maior da renda variável?" },
                    { 5, "Para o longo prazo e sua aposentadoria, você prefere se expor menos a riscos e ficar mais na renda fixa?" }
                });

            migrationBuilder.InsertData(
                table: "Carteira",
                columns: new[] { "ID", "Composicao", "Descricao", "PerfilID" },
                values: new object[] { 1, "100% Renda Fixa", "MAX Renda Fixa", 1 });

            migrationBuilder.InsertData(
                table: "Carteira",
                columns: new[] { "ID", "Composicao", "Descricao", "PerfilID" },
                values: new object[] { 2, "50% Renda Fixa e 50% Renda Variável", "MIX Renda Fixa/Renda Variável", 2 });

            migrationBuilder.InsertData(
                table: "Carteira",
                columns: new[] { "ID", "Composicao", "Descricao", "PerfilID" },
                values: new object[] { 3, "100% Renda Variável", "MAX Renda Variável", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questao");

            migrationBuilder.DeleteData(
                table: "Carteira",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carteira",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Carteira",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Perfil",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Perfil",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Perfil",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
