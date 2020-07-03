using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev011rbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DSC_PARECER_TECNICO_RESPONDIDO",
                table: "CAD_RELATO",
                newName: "DscParecerTecnicoRespondido");

            migrationBuilder.RenameColumn(
                name: "DSC_NOVO_PARECER_TECNICO",
                table: "CAD_RELATO",
                newName: "DscNovoParecerTecnico");

            migrationBuilder.RenameColumn(
                name: "DSC_MOTIVO_DEVOLUCAO",
                table: "CAD_RELATO",
                newName: "DscMotivoDevolucao");

            migrationBuilder.RenameColumn(
                name: "DSC_ACOES_CORRETIVAS_RECOMENDADAS",
                table: "CAD_RELATO",
                newName: "DscAcoesCorretivasRecomendadas");

            migrationBuilder.AlterColumn<string>(
                name: "DscParecerTecnicoRespondido",
                table: "CAD_RELATO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DscNovoParecerTecnico",
                table: "CAD_RELATO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DscMotivoDevolucao",
                table: "CAD_RELATO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DscAcoesCorretivasRecomendadas",
                table: "CAD_RELATO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CAD_PARECER",
                columns: table => new
                {
                    SEQ_PARECER = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOM_USU_INCLUSAO = table.Column<string>(nullable: true),
                    DTH_INCLUSAO = table.Column<DateTime>(nullable: false),
                    NOM_USU_ALTERACAO = table.Column<string>(nullable: true),
                    DTH_ALTERACAO = table.Column<DateTime>(nullable: true),
                    FLG_ATIVO = table.Column<bool>(nullable: false),
                    DSC_PARECER = table.Column<string>(maxLength: 500, nullable: false),
                    DSC_MOTIVO_DEVOLUCAO = table.Column<string>(maxLength: 500, nullable: false),
                    FlgStatusParecer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_PARECER", x => x.SEQ_PARECER);
                });

            migrationBuilder.CreateTable(
                name: "CAD_PARECER_ARQUIVO",
                columns: table => new
                {
                    SEQ_PARECER_ARQUIVO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOM_USU_INCLUSAO = table.Column<string>(nullable: true),
                    DTH_INCLUSAO = table.Column<DateTime>(nullable: false),
                    NOM_USU_ALTERACAO = table.Column<string>(nullable: true),
                    DTH_ALTERACAO = table.Column<DateTime>(nullable: true),
                    FLG_ATIVO = table.Column<bool>(nullable: false),
                    COD_PARECER = table.Column<int>(nullable: false),
                    NOM_ARQUIVO = table.Column<string>(maxLength: 200, nullable: false),
                    NOM_ARQUIVO_UNICO = table.Column<string>(maxLength: 500, nullable: false),
                    DIR_CAMINHO = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_PARECER_ARQUIVO", x => x.SEQ_PARECER_ARQUIVO);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CAD_PARECER");

            migrationBuilder.DropTable(
                name: "CAD_PARECER_ARQUIVO");

            migrationBuilder.RenameColumn(
                name: "DscParecerTecnicoRespondido",
                table: "CAD_RELATO",
                newName: "DSC_PARECER_TECNICO_RESPONDIDO");

            migrationBuilder.RenameColumn(
                name: "DscNovoParecerTecnico",
                table: "CAD_RELATO",
                newName: "DSC_NOVO_PARECER_TECNICO");

            migrationBuilder.RenameColumn(
                name: "DscMotivoDevolucao",
                table: "CAD_RELATO",
                newName: "DSC_MOTIVO_DEVOLUCAO");

            migrationBuilder.RenameColumn(
                name: "DscAcoesCorretivasRecomendadas",
                table: "CAD_RELATO",
                newName: "DSC_ACOES_CORRETIVAS_RECOMENDADAS");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_PARECER_TECNICO_RESPONDIDO",
                table: "CAD_RELATO",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_NOVO_PARECER_TECNICO",
                table: "CAD_RELATO",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_MOTIVO_DEVOLUCAO",
                table: "CAD_RELATO",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ACOES_CORRETIVAS_RECOMENDADAS",
                table: "CAD_RELATO",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
