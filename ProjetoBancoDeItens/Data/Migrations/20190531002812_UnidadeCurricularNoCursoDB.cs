using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBancoDeItens.Data.Migrations
{
    public partial class UnidadeCurricularNoCursoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnidadeCurricularNoCurso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CursoId = table.Column<int>(nullable: false),
                    UnidadeCurricularId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeCurricularNoCurso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnidadeCurricularNoCurso_Curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnidadeCurricularNoCurso_UnidadeCurricular_UnidadeCurricularId",
                        column: x => x.UnidadeCurricularId,
                        principalTable: "UnidadeCurricular",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnidadeCurricularNoCurso_CursoId",
                table: "UnidadeCurricularNoCurso",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_UnidadeCurricularNoCurso_UnidadeCurricularId",
                table: "UnidadeCurricularNoCurso",
                column: "UnidadeCurricularId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnidadeCurricularNoCurso");
        }
    }
}
