using Microsoft.EntityFrameworkCore.Migrations;

namespace ISPSystem.EF.Migrations
{
    public partial class Perfil_Carteira_Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "ID",
                keyValue: 1,
                column: "Pontuacao",
                value: 15);

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "ID", "Descricao", "Pontuacao" },
                values: new object[] { 4, "Ultra Conservador", 0 });

            migrationBuilder.InsertData(
                table: "Carteira",
                columns: new[] { "ID", "Composicao", "Descricao", "PerfilID" },
                values: new object[] { 5, "50% Poupança e 50% Tesouro SELIC simples", "MIX Poupana/Tesouro SELIC", 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carteira",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Perfil",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "ID",
                keyValue: 1,
                column: "Pontuacao",
                value: 20);
        }
    }
}
