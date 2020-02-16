using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_UnidadeInfraestrutura_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Usuario");

            migrationBuilder.AlterColumn<string>(
                name: "CodPerfil",
                table: "Usuario",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CodEmpresa",
                table: "Usuario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CodUsuarioLogin",
                table: "Usuario",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VinculoUnidadeEmpresa_CodEmpresa",
                table: "VinculoUnidadeEmpresa",
                column: "CodEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_VinculoUnidadeEmpresa_Empresa_CodEmpresa",
                table: "VinculoUnidadeEmpresa",
                column: "CodEmpresa",
                principalTable: "Empresa",
                principalColumn: "CodEmpresa",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VinculoUnidadeEmpresa_Empresa_CodEmpresa",
                table: "VinculoUnidadeEmpresa");

            migrationBuilder.DropIndex(
                name: "IX_VinculoUnidadeEmpresa_CodEmpresa",
                table: "VinculoUnidadeEmpresa");

            migrationBuilder.DropColumn(
                name: "CodEmpresa",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "CodUsuarioLogin",
                table: "Usuario");

            migrationBuilder.AlterColumn<int>(
                name: "CodPerfil",
                table: "Usuario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Usuario",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Usuario",
                column: "UnidadeInfraestruturaCodUnidadeInfraestrutura");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_UnidadeInfraestrutura_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Usuario",
                column: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                principalTable: "UnidadeInfraestrutura",
                principalColumn: "CodUnidadeInfraestrutura",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
