using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBancoDeItens.Data.Migrations
{
    public partial class alteracaoAlternativaItemEItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GabaritoItem");

            migrationBuilder.RenameColumn(
                name: "FlAtivo",
                table: "Item",
                newName: "Ativo");

            migrationBuilder.AddColumn<int>(
                name: "Gabarito",
                table: "Item",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Sigla",
                table: "Competencia",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(3)");

            migrationBuilder.CreateTable(
                name: "AlternativaItem",
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
                    table.PrimaryKey("PK_AlternativaItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlternativaItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlternativaItem_ItemId",
                table: "AlternativaItem",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlternativaItem");

            migrationBuilder.DropColumn(
                name: "Gabarito",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "Ativo",
                table: "Item",
                newName: "FlAtivo");

            migrationBuilder.AlterColumn<string>(
                name: "Sigla",
                table: "Competencia",
                type: "VARCHAR(3)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "GabaritoItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Imagem = table.Column<byte[]>(nullable: true),
                    ItemId = table.Column<int>(nullable: false),
                    Posicao = table.Column<int>(nullable: false),
                    Resposta = table.Column<bool>(nullable: false),
                    Texto = table.Column<byte[]>(nullable: true)
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
    }
}
