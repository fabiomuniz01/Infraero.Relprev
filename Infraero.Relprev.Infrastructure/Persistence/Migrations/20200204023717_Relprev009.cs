using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev009 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnidadeInfraestrutura_Empresa_EmpresaCodEmpresa",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropIndex(
                name: "IX_UnidadeInfraestrutura_EmpresaCodEmpresa",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropColumn(
                name: "EmpresaCodEmpresa",
                table: "UnidadeInfraestrutura");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpresaCodEmpresa",
                table: "UnidadeInfraestrutura",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UnidadeInfraestrutura_EmpresaCodEmpresa",
                table: "UnidadeInfraestrutura",
                column: "EmpresaCodEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_UnidadeInfraestrutura_Empresa_EmpresaCodEmpresa",
                table: "UnidadeInfraestrutura",
                column: "EmpresaCodEmpresa",
                principalTable: "Empresa",
                principalColumn: "CodEmpresa",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
