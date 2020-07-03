using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev012rbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DscMotivoDevolucao",
                table: "CAD_RELATO");

            migrationBuilder.DropColumn(
                name: "DscNovoParecerTecnico",
                table: "CAD_RELATO");

            migrationBuilder.DropColumn(
                name: "DscParecerTecnicoRespondido",
                table: "CAD_RELATO");

            migrationBuilder.RenameColumn(
                name: "DscAcoesCorretivasRecomendadas",
                table: "CAD_RELATO",
                newName: "DSC_ACOES_CORRETIVAS_RECOMENDADAS");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ACOES_CORRETIVAS_RECOMENDADAS",
                table: "CAD_RELATO",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DSC_ACOES_CORRETIVAS_RECOMENDADAS",
                table: "CAD_RELATO",
                newName: "DscAcoesCorretivasRecomendadas");

            migrationBuilder.AlterColumn<string>(
                name: "DscAcoesCorretivasRecomendadas",
                table: "CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DscMotivoDevolucao",
                table: "CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DscNovoParecerTecnico",
                table: "CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DscParecerTecnicoRespondido",
                table: "CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
