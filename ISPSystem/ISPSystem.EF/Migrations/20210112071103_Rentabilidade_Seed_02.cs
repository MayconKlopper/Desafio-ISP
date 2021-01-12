using Microsoft.EntityFrameworkCore.Migrations;

namespace ISPSystem.EF.Migrations
{
    public partial class Rentabilidade_Seed_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rentabilidade",
                columns: new[] { "ID", "Ano", "CarteiraID", "Mes", "Porcentagem" },
                values: new object[,]
                {
                    { 25, 2020, 3, "Janeiro", -0.234m },
                    { 26, 2020, 3, "Fevereiro", -0.236m },
                    { 27, 2020, 4, "Janeiro", 0.143m },
                    { 28, 2020, 4, "Fevereiro", 0.165m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 28);
        }
    }
}
