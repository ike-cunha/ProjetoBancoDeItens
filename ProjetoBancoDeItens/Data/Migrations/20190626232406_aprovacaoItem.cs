using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBancoDeItens.Data.Migrations
{
    public partial class aprovacaoItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Aprovado",
                table: "Item",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aprovado",
                table: "Item");
        }
    }
}
