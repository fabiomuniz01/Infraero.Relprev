using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev037ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TAB_FUNCIONALIDADE_Modulo_COD_MODULO",
                table: "TAB_FUNCIONALIDADE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modulo",
                table: "Modulo");

            migrationBuilder.RenameTable(
                name: "Modulo",
                newName: "TAB_MODULO");

            migrationBuilder.RenameColumn(
                name: "NomModulo",
                table: "TAB_MODULO",
                newName: "NOM_Modulo");

            migrationBuilder.RenameColumn(
                name: "FlagAtivo",
                table: "TAB_MODULO",
                newName: "FLG_ATIVO");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "TAB_MODULO",
                newName: "DTH_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "TAB_MODULO",
                newName: "DTH_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "TAB_MODULO",
                newName: "NOM_USU_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "AlteradoPor",
                table: "TAB_MODULO",
                newName: "NOM_USU_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CodModulo",
                table: "TAB_MODULO",
                newName: "SEQ_MODULO");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_Modulo",
                table: "TAB_MODULO",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TAB_MODULO",
                table: "TAB_MODULO",
                column: "SEQ_MODULO");

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_FUNCIONALIDADE_TAB_MODULO_COD_MODULO",
                table: "TAB_FUNCIONALIDADE",
                column: "COD_MODULO",
                principalTable: "TAB_MODULO",
                principalColumn: "SEQ_MODULO",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TAB_FUNCIONALIDADE_TAB_MODULO_COD_MODULO",
                table: "TAB_FUNCIONALIDADE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TAB_MODULO",
                table: "TAB_MODULO");

            migrationBuilder.RenameTable(
                name: "TAB_MODULO",
                newName: "Modulo");

            migrationBuilder.RenameColumn(
                name: "NOM_Modulo",
                table: "Modulo",
                newName: "NomModulo");

            migrationBuilder.RenameColumn(
                name: "FLG_ATIVO",
                table: "Modulo",
                newName: "FlagAtivo");

            migrationBuilder.RenameColumn(
                name: "DTH_INCLUSAO",
                table: "Modulo",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DTH_ALTERACAO",
                table: "Modulo",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_INCLUSAO",
                table: "Modulo",
                newName: "CriadoPor");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_ALTERACAO",
                table: "Modulo",
                newName: "AlteradoPor");

            migrationBuilder.RenameColumn(
                name: "SEQ_MODULO",
                table: "Modulo",
                newName: "CodModulo");

            migrationBuilder.AlterColumn<string>(
                name: "NomModulo",
                table: "Modulo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modulo",
                table: "Modulo",
                column: "CodModulo");

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_FUNCIONALIDADE_Modulo_COD_MODULO",
                table: "TAB_FUNCIONALIDADE",
                column: "COD_MODULO",
                principalTable: "Modulo",
                principalColumn: "CodModulo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
