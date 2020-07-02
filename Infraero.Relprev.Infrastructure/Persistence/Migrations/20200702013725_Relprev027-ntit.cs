using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev027ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_RESPONSAVEL_TECNICO_COD_EMPRESA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_VINCULO_UNIDADE_EMPRESA_CAD_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA");

            migrationBuilder.DropIndex(
                name: "IX_CAD_VINCULO_UNIDADE_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA");

            migrationBuilder.DropColumn(
                name: "CodVinculoUnidadeEmpresa",
                table: "CAD_EMPRESA");

            migrationBuilder.RenameColumn(
                name: "CodUnidadeInfraestrutura",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "COD_UNIDADE_INFRAESTRUTURA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "CodUnidadeInfraestrutura");

            migrationBuilder.AddColumn<int>(
                name: "CodVinculoUnidadeEmpresa",
                table: "CAD_EMPRESA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CAD_VINCULO_UNIDADE_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                column: "COD_EMPRESA");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_RESPONSAVEL_TECNICO_COD_EMPRESA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                column: "COD_EMPRESA",
                principalTable: "CAD_RESPONSAVEL_TECNICO",
                principalColumn: "SEQ_RESPONSAVEL_TECNICO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_VINCULO_UNIDADE_EMPRESA_CAD_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                column: "COD_EMPRESA",
                principalTable: "CAD_EMPRESA",
                principalColumn: "SEQ_EMPRESA",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
