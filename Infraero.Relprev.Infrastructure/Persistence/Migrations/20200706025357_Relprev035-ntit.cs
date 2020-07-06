using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev035ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SIG_UNIDADE",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "SIG_UNIDADE_INFRAESTRUTURA");

            migrationBuilder.RenameColumn(
                name: "NomUnidadeÌnfraestrutura",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "NOM_UNIDADE_INFRAESTRUTURA");

            migrationBuilder.RenameColumn(
                name: "Endereco",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "END_UNIDADE_INFRAESTRUTURA");

            migrationBuilder.RenameColumn(
                name: "DtIniVigencia",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "DTH_INI_VIGENCIA");

            migrationBuilder.RenameColumn(
                name: "DtFimVigencia",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "DTH_FIM_VIGENCIA");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "DSC_UNIDADE_INFRAESTRUTURA");

            migrationBuilder.RenameColumn(
                name: "COD_UNIDADE",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "COD_UNIDADE_INFRAESTRUTURA");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "END_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SIG_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "SIG_UNIDADE");

            migrationBuilder.RenameColumn(
                name: "NOM_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "NomUnidadeÌnfraestrutura");

            migrationBuilder.RenameColumn(
                name: "END_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "Endereco");

            migrationBuilder.RenameColumn(
                name: "DTH_INI_VIGENCIA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "DtIniVigencia");

            migrationBuilder.RenameColumn(
                name: "DTH_FIM_VIGENCIA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "DtFimVigencia");

            migrationBuilder.RenameColumn(
                name: "DSC_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "COD_UNIDADE");

            migrationBuilder.AlterColumn<string>(
                name: "NomUnidadeÌnfraestrutura",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
