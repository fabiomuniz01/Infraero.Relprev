using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev026ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DSC_MOTIVO_DEVOLUCAO",
                table: "CAD_RELATO",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DSC_NOVO_PARECER_TECNICO",
                table: "CAD_RELATO",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DSC_PARECER_TECNICO_RESPONDIDO",
                table: "CAD_RELATO",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DSC_MOTIVO_DEVOLUCAO",
                table: "CAD_RELATO");

            migrationBuilder.DropColumn(
                name: "DSC_NOVO_PARECER_TECNICO",
                table: "CAD_RELATO");

            migrationBuilder.DropColumn(
                name: "DSC_PARECER_TECNICO_RESPONDIDO",
                table: "CAD_RELATO");
        }
    }
}
