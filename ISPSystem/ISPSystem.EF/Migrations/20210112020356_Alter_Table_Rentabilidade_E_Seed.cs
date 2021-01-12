using Microsoft.EntityFrameworkCore.Migrations;

namespace ISPSystem.EF.Migrations
{
    public partial class Alter_Table_Rentabilidade_E_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentagem",
                table: "Rentabilidade",
                type: "decimal(18,3)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.InsertData(
                table: "Rentabilidade",
                columns: new[] { "ID", "Ano", "CarteiraID", "Mes", "Porcentagem" },
                values: new object[,]
                {
                    { 1, 2020, 1, "Janeiro", -0.05m },
                    { 22, 2020, 2, "Outubro", 0.06m },
                    { 21, 2020, 2, "Setembro", -0.084m },
                    { 20, 2020, 2, "Agosto", -0.065m },
                    { 19, 2020, 2, "Julho", 0.266m },
                    { 18, 2020, 2, "Junho", 0.038m },
                    { 17, 2020, 2, "Maio", 0.02m },
                    { 16, 2020, 2, "Abril", -0.102m },
                    { 15, 2020, 2, "Março", -0.086m },
                    { 14, 2020, 2, "Fevereiro", -0.16m },
                    { 13, 2020, 2, "Janeiro", -0.14m },
                    { 12, 2020, 1, "Dezembro", 0.08m },
                    { 11, 2020, 1, "Novembro", 0.07m },
                    { 10, 2020, 1, "Outubro", 0.03m },
                    { 9, 2020, 1, "Setembro", -0.054m },
                    { 8, 2020, 1, "Agosto", -0.035m },
                    { 7, 2020, 1, "Julho", 0.136m },
                    { 6, 2020, 1, "Junho", 0.024m },
                    { 5, 2020, 1, "Maio", 0.10m },
                    { 4, 2020, 1, "Abril", -0.10m },
                    { 3, 2020, 1, "Março", -0.08m },
                    { 2, 2020, 1, "Fevereiro", -0.07m },
                    { 23, 2020, 2, "Novembro", 0.16m },
                    { 24, 2020, 2, "Dezembro", 0.145m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rentabilidade",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.AlterColumn<decimal>(
                name: "Porcentagem",
                table: "Rentabilidade",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,3)");
        }
    }
}
