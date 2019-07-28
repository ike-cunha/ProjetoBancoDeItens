using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBancoDeItens.Data.Migrations
{
    public partial class GabaritoItemDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RespostaItem");

            migrationBuilder.CreateTable(
                name: "GabaritoItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Texto = table.Column<byte[]>(nullable: true),
                    Imagem = table.Column<byte[]>(nullable: true),
                    Posicao = table.Column<int>(nullable: false),
                    Resposta = table.Column<bool>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GabaritoItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GabaritoItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GabaritoItem_ItemId",
                table: "GabaritoItem",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GabaritoItem");

            migrationBuilder.CreateTable(
                name: "RespostaItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(nullable: false),
                    Resposta = table.Column<int>(nullable: false)
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
    }
}
