using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev036ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_RESPONSAVEL_TECNICO_COD_RESPONSAVEL_TECNICO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_RESPONSAVEL_TECNICO_COD_RESPONSAVEL_TECNICO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                column: "COD_RESPONSAVEL_TECNICO",
                principalTable: "CAD_RESPONSAVEL_TECNICO",
                principalColumn: "SEQ_RESPONSAVEL_TECNICO",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_RESPONSAVEL_TECNICO_COD_RESPONSAVEL_TECNICO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_RESPONSAVEL_TECNICO_COD_RESPONSAVEL_TECNICO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                column: "COD_RESPONSAVEL_TECNICO",
                principalTable: "CAD_RESPONSAVEL_TECNICO",
                principalColumn: "SEQ_RESPONSAVEL_TECNICO",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
