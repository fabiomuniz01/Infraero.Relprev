using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev033ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_PARECER_CAD_RELATO_COD_RELATO",
                table: "CAD_PARECER");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_PARECER_ARQUIVO_CAD_PARECER_COD_PARECER",
                table: "CAD_PARECER_ARQUIVO");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionalidade_Modulo_CodModulo",
                table: "Funcionalidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionalidade",
                table: "Funcionalidade");

            migrationBuilder.RenameTable(
                name: "Funcionalidade",
                newName: "TAB_FUNCIONALIDADE");

            migrationBuilder.RenameColumn(
                name: "NomFuncionalidade",
                table: "TAB_FUNCIONALIDADE",
                newName: "NOM_FUNCIONALIDADE");

            migrationBuilder.RenameColumn(
                name: "FlagAtivo",
                table: "TAB_FUNCIONALIDADE",
                newName: "FLG_ATIVO");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "TAB_FUNCIONALIDADE",
                newName: "DTH_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "TAB_FUNCIONALIDADE",
                newName: "DTH_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "TAB_FUNCIONALIDADE",
                newName: "NOM_USU_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "CodModulo",
                table: "TAB_FUNCIONALIDADE",
                newName: "COD_MODULO");

            migrationBuilder.RenameColumn(
                name: "AlteradoPor",
                table: "TAB_FUNCIONALIDADE",
                newName: "NOM_USU_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CodFuncionalidade",
                table: "TAB_FUNCIONALIDADE",
                newName: "SEQ_Funcionalidade");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionalidade_CodModulo",
                table: "TAB_FUNCIONALIDADE",
                newName: "IX_TAB_FUNCIONALIDADE_COD_MODULO");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_FUNCIONALIDADE",
                table: "TAB_FUNCIONALIDADE",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TAB_FUNCIONALIDADE",
                table: "TAB_FUNCIONALIDADE",
                column: "SEQ_Funcionalidade");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_PARECER_CAD_RELATO_COD_RELATO",
                table: "CAD_PARECER",
                column: "COD_RELATO",
                principalTable: "CAD_RELATO",
                principalColumn: "SEQ_RELATO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_PARECER_ARQUIVO_CAD_PARECER_COD_PARECER",
                table: "CAD_PARECER_ARQUIVO",
                column: "COD_PARECER",
                principalTable: "CAD_PARECER",
                principalColumn: "SEQ_PARECER",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_FUNCIONALIDADE_Modulo_COD_MODULO",
                table: "TAB_FUNCIONALIDADE",
                column: "COD_MODULO",
                principalTable: "Modulo",
                principalColumn: "CodModulo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_PARECER_CAD_RELATO_COD_RELATO",
                table: "CAD_PARECER");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_PARECER_ARQUIVO_CAD_PARECER_COD_PARECER",
                table: "CAD_PARECER_ARQUIVO");

            migrationBuilder.DropForeignKey(
                name: "FK_TAB_FUNCIONALIDADE_Modulo_COD_MODULO",
                table: "TAB_FUNCIONALIDADE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TAB_FUNCIONALIDADE",
                table: "TAB_FUNCIONALIDADE");

            migrationBuilder.RenameTable(
                name: "TAB_FUNCIONALIDADE",
                newName: "Funcionalidade");

            migrationBuilder.RenameColumn(
                name: "NOM_FUNCIONALIDADE",
                table: "Funcionalidade",
                newName: "NomFuncionalidade");

            migrationBuilder.RenameColumn(
                name: "FLG_ATIVO",
                table: "Funcionalidade",
                newName: "FlagAtivo");

            migrationBuilder.RenameColumn(
                name: "DTH_INCLUSAO",
                table: "Funcionalidade",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DTH_ALTERACAO",
                table: "Funcionalidade",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_INCLUSAO",
                table: "Funcionalidade",
                newName: "CriadoPor");

            migrationBuilder.RenameColumn(
                name: "COD_MODULO",
                table: "Funcionalidade",
                newName: "CodModulo");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_ALTERACAO",
                table: "Funcionalidade",
                newName: "AlteradoPor");

            migrationBuilder.RenameColumn(
                name: "SEQ_Funcionalidade",
                table: "Funcionalidade",
                newName: "CodFuncionalidade");

            migrationBuilder.RenameIndex(
                name: "IX_TAB_FUNCIONALIDADE_COD_MODULO",
                table: "Funcionalidade",
                newName: "IX_Funcionalidade_CodModulo");

            migrationBuilder.AlterColumn<string>(
                name: "NomFuncionalidade",
                table: "Funcionalidade",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionalidade",
                table: "Funcionalidade",
                column: "CodFuncionalidade");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_PARECER_CAD_RELATO_COD_RELATO",
                table: "CAD_PARECER",
                column: "COD_RELATO",
                principalTable: "CAD_RELATO",
                principalColumn: "SEQ_RELATO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_PARECER_ARQUIVO_CAD_PARECER_COD_PARECER",
                table: "CAD_PARECER_ARQUIVO",
                column: "COD_PARECER",
                principalTable: "CAD_PARECER",
                principalColumn: "SEQ_PARECER",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionalidade_Modulo_CodModulo",
                table: "Funcionalidade",
                column: "CodModulo",
                principalTable: "Modulo",
                principalColumn: "CodModulo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
