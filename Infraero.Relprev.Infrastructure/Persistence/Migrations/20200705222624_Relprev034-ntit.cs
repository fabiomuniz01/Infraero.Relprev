using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev034ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CAD_VINCULO_UNIDADE_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                column: "COD_EMPRESA");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_VINCULO_UNIDADE_EMPRESA_CAD_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                column: "COD_EMPRESA",
                principalTable: "CAD_EMPRESA",
                principalColumn: "SEQ_EMPRESA",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_VINCULO_UNIDADE_EMPRESA_CAD_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA");

            migrationBuilder.DropIndex(
                name: "IX_CAD_VINCULO_UNIDADE_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA");
        }
    }
}
