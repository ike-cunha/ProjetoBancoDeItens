using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBancoDeItens.Data.Migrations
{
    public partial class alteracaoConteudoItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Item",
                table: "ConteudoItem");

            migrationBuilder.CreateIndex(
                name: "IX_ConteudoItem_ItemId",
                table: "ConteudoItem",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConteudoItem_Item_ItemId",
                table: "ConteudoItem",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConteudoItem_Item_ItemId",
                table: "ConteudoItem");

            migrationBuilder.DropIndex(
                name: "IX_ConteudoItem_ItemId",
                table: "ConteudoItem");

            migrationBuilder.AddColumn<int>(
                name: "Item",
                table: "ConteudoItem",
                nullable: false,
                defaultValue: 0);
        }
    }
}
