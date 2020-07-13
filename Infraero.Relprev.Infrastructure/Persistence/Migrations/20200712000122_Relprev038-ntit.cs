using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev038ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerfilFuncao_Perfil_CodPerfilNavigationCodPerfil",
                table: "PerfilFuncao");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilUsuario_Perfil_CodPerfilNavigationCodPerfil",
                table: "PerfilUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Perfil",
                table: "Perfil");

            migrationBuilder.DropColumn(
                name: "FlgAtivo",
                table: "Perfil");

            migrationBuilder.RenameTable(
                name: "Perfil",
                newName: "CAD_PERFIL");

            migrationBuilder.RenameColumn(
                name: "SEQ_Funcionalidade",
                table: "TAB_FUNCIONALIDADE",
                newName: "SEQ_FUNCIONALIDADE");

            migrationBuilder.RenameColumn(
                name: "NomPerfil",
                table: "CAD_PERFIL",
                newName: "NOM_PERFIL");

            migrationBuilder.RenameColumn(
                name: "FlagAtivo",
                table: "CAD_PERFIL",
                newName: "FLG_ATIVO");

            migrationBuilder.RenameColumn(
                name: "DscPerfil",
                table: "CAD_PERFIL",
                newName: "DSC_PERFIL");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "CAD_PERFIL",
                newName: "DTH_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "CAD_PERFIL",
                newName: "DTH_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "CAD_PERFIL",
                newName: "NOM_USU_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "AlteradoPor",
                table: "CAD_PERFIL",
                newName: "NOM_USU_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CodPerfil",
                table: "CAD_PERFIL",
                newName: "SEQ_PERFIL");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_PERFIL",
                table: "CAD_PERFIL",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_PERFIL",
                table: "CAD_PERFIL",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAD_PERFIL",
                table: "CAD_PERFIL",
                column: "SEQ_PERFIL");

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilFuncao_CAD_PERFIL_CodPerfilNavigationCodPerfil",
                table: "PerfilFuncao",
                column: "CodPerfilNavigationCodPerfil",
                principalTable: "CAD_PERFIL",
                principalColumn: "SEQ_PERFIL",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilUsuario_CAD_PERFIL_CodPerfilNavigationCodPerfil",
                table: "PerfilUsuario",
                column: "CodPerfilNavigationCodPerfil",
                principalTable: "CAD_PERFIL",
                principalColumn: "SEQ_PERFIL",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerfilFuncao_CAD_PERFIL_CodPerfilNavigationCodPerfil",
                table: "PerfilFuncao");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilUsuario_CAD_PERFIL_CodPerfilNavigationCodPerfil",
                table: "PerfilUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAD_PERFIL",
                table: "CAD_PERFIL");

            migrationBuilder.RenameTable(
                name: "CAD_PERFIL",
                newName: "Perfil");

            migrationBuilder.RenameColumn(
                name: "SEQ_FUNCIONALIDADE",
                table: "TAB_FUNCIONALIDADE",
                newName: "SEQ_Funcionalidade");

            migrationBuilder.RenameColumn(
                name: "NOM_PERFIL",
                table: "Perfil",
                newName: "NomPerfil");

            migrationBuilder.RenameColumn(
                name: "FLG_ATIVO",
                table: "Perfil",
                newName: "FlagAtivo");

            migrationBuilder.RenameColumn(
                name: "DSC_PERFIL",
                table: "Perfil",
                newName: "DscPerfil");

            migrationBuilder.RenameColumn(
                name: "DTH_INCLUSAO",
                table: "Perfil",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DTH_ALTERACAO",
                table: "Perfil",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_INCLUSAO",
                table: "Perfil",
                newName: "CriadoPor");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_ALTERACAO",
                table: "Perfil",
                newName: "AlteradoPor");

            migrationBuilder.RenameColumn(
                name: "SEQ_PERFIL",
                table: "Perfil",
                newName: "CodPerfil");

            migrationBuilder.AlterColumn<string>(
                name: "NomPerfil",
                table: "Perfil",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "DscPerfil",
                table: "Perfil",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AddColumn<bool>(
                name: "FlgAtivo",
                table: "Perfil",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Perfil",
                table: "Perfil",
                column: "CodPerfil");

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilFuncao_Perfil_CodPerfilNavigationCodPerfil",
                table: "PerfilFuncao",
                column: "CodPerfilNavigationCodPerfil",
                principalTable: "Perfil",
                principalColumn: "CodPerfil",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilUsuario_Perfil_CodPerfilNavigationCodPerfil",
                table: "PerfilUsuario",
                column: "CodPerfilNavigationCodPerfil",
                principalTable: "Perfil",
                principalColumn: "CodPerfil",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
