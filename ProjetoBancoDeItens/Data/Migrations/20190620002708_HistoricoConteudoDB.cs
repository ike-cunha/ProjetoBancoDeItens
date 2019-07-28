using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBancoDeItens.Data.Migrations
{
    public partial class HistoricoConteudoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoricoConteudoItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConteudoItemId = table.Column<int>(nullable: false),
                    Texto = table.Column<byte[]>(nullable: true),
                    Imagem = table.Column<byte[]>(nullable: true),
                    Posicao = table.Column<int>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoConteudoItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoConteudoItem_ConteudoItem_ConteudoItemId",
                        column: x => x.ConteudoItemId,
                        principalTable: "ConteudoItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoConteudoItem_ConteudoItemId",
                table: "HistoricoConteudoItem",
                column: "ConteudoItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricoConteudoItem");
        }
    }
}
