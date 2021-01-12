using Microsoft.EntityFrameworkCore.Migrations;

namespace ISPSystem.EF.Migrations
{
    public partial class Participante_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Participante",
                columns: new[] { "ID", "CarteiraID", "Idade", "Nome", "PerfilID" },
                values: new object[] { 1, 1, 25, "Maycon Klopper de Carvalho", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Participante",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
