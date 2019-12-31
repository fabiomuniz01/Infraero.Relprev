using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Local_CodUnidadeInfraestrutura",
                table: "Local",
                column: "CodUnidadeInfraestrutura");

            migrationBuilder.AddForeignKey(
                name: "FK_Local_UnidadeInfraestruturas_CodUnidadeInfraestrutura",
                table: "Local",
                column: "CodUnidadeInfraestrutura",
                principalTable: "UnidadeInfraestruturas",
                principalColumn: "CodUnidadeInfraestrutura",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Local_UnidadeInfraestruturas_CodUnidadeInfraestrutura",
                table: "Local");

            migrationBuilder.DropIndex(
                name: "IX_Local_CodUnidadeInfraestrutura",
                table: "Local");
        }
    }
}
