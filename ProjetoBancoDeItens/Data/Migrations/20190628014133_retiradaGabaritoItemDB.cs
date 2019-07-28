using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBancoDeItens.Data.Migrations
{
    public partial class retiradaGabaritoItemDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gabarito",
                table: "Item");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Gabarito",
                table: "Item",
                nullable: false,
                defaultValue: 0);
        }
    }
}
