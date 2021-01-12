using Microsoft.EntityFrameworkCore.Migrations;

namespace ISPSystem.EF.Migrations
{
    public partial class Alter_Table_Rentabilidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Porcentagem",
                table: "Rentabilidade",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Porcentagem",
                table: "Rentabilidade");
        }
    }
}
