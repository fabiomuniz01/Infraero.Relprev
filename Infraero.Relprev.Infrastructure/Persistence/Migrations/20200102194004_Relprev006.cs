using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev006 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResponsavelTecnicoCodResponsavelTecnico",
                table: "UnidadeInfraestrutura",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodEmpresaResponsavelTecnico",
                table: "ResponsavelTecnico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CodUnidadeInfraestrutura",
                table: "ResponsavelTecnico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UnidadeInfraestrutura_ResponsavelTecnicoCodResponsavelTecnico",
                table: "UnidadeInfraestrutura",
                column: "ResponsavelTecnicoCodResponsavelTecnico");

            migrationBuilder.AddForeignKey(
                name: "FK_UnidadeInfraestrutura_ResponsavelTecnico_ResponsavelTecnicoCodResponsavelTecnico",
                table: "UnidadeInfraestrutura",
                column: "ResponsavelTecnicoCodResponsavelTecnico",
                principalTable: "ResponsavelTecnico",
                principalColumn: "CodResponsavelTecnico",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnidadeInfraestrutura_ResponsavelTecnico_ResponsavelTecnicoCodResponsavelTecnico",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropIndex(
                name: "IX_UnidadeInfraestrutura_ResponsavelTecnicoCodResponsavelTecnico",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropColumn(
                name: "ResponsavelTecnicoCodResponsavelTecnico",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropColumn(
                name: "CodEmpresaResponsavelTecnico",
                table: "ResponsavelTecnico");

            migrationBuilder.DropColumn(
                name: "CodUnidadeInfraestrutura",
                table: "ResponsavelTecnico");
        }
    }
}
