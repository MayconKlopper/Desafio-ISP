using Microsoft.EntityFrameworkCore.Migrations;

namespace ISPSystem.EF.Migrations
{
    public partial class Alter_Table_Perfil_Solicitacao_AND_Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Carteira_PerfilID",
                table: "Carteira");

            migrationBuilder.AddColumn<int>(
                name: "CarteiraID",
                table: "Solicitacao",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Solicitacao",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PerfilID",
                table: "Solicitacao",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Carteira",
                columns: new[] { "ID", "Composicao", "Descricao", "PerfilID" },
                values: new object[] { 4, "80% Renda Variável e 20% Criptomoeda", "MIX Renda Variável/Criptomoeda", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Carteira_PerfilID",
                table: "Carteira",
                column: "PerfilID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Carteira_PerfilID",
                table: "Carteira");

            migrationBuilder.DeleteData(
                table: "Carteira",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "CarteiraID",
                table: "Solicitacao");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Solicitacao");

            migrationBuilder.DropColumn(
                name: "PerfilID",
                table: "Solicitacao");

            migrationBuilder.CreateIndex(
                name: "IX_Carteira_PerfilID",
                table: "Carteira",
                column: "PerfilID",
                unique: true);
        }
    }
}
