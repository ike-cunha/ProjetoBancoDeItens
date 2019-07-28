using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBancoDeItens.Data.Migrations
{
    public partial class RespostaItemDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RespostaCorreta",
                table: "ConteudoItem");

            migrationBuilder.CreateTable(
                name: "RespostaItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Resposta = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespostaItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RespostaItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RespostaItem_ItemId",
                table: "RespostaItem",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RespostaItem");

            migrationBuilder.AddColumn<int>(
                name: "RespostaCorreta",
                table: "ConteudoItem",
                nullable: false,
                defaultValue: 0);
        }
    }
}
