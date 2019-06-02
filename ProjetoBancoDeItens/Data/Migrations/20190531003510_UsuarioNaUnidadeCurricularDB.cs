using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBancoDeItens.Data.Migrations
{
    public partial class UsuarioNaUnidadeCurricularDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsuarioNaUnidadeCurricular",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<string>(nullable: false),
                    UnidadeCurricularId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioNaUnidadeCurricular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioNaUnidadeCurricular_UnidadeCurricular_UnidadeCurricularId",
                        column: x => x.UnidadeCurricularId,
                        principalTable: "UnidadeCurricular",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioNaUnidadeCurricular_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioNaUnidadeCurricular_UnidadeCurricularId",
                table: "UsuarioNaUnidadeCurricular",
                column: "UnidadeCurricularId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioNaUnidadeCurricular_UsuarioId",
                table: "UsuarioNaUnidadeCurricular",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioNaUnidadeCurricular");
        }
    }
}
