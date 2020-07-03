using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev014rbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DSC_MOTIVO_DEVOLUCAO",
                table: "CAD_PARECER",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<string>(
                name: "DSC_COMPLEMENTO_PARECER",
                table: "CAD_PARECER",
                maxLength: 500,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HST_CAD_Parecer",
                columns: table => new
                {
                    SEQ_HISTORICO_PARECER = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOM_USU_INCLUSAO = table.Column<string>(nullable: true),
                    DTH_INCLUSAO = table.Column<DateTime>(nullable: false),
                    NOM_USU_ALTERACAO = table.Column<string>(nullable: true),
                    DTH_ALTERACAO = table.Column<DateTime>(nullable: true),
                    FLG_ATIVO = table.Column<bool>(nullable: false),
                    COD_PARECER = table.Column<int>(nullable: false),
                    DSC_ULTIMA_OCORRENCIA = table.Column<string>(maxLength: 255, nullable: true),
                    DSC_PARECER = table.Column<string>(maxLength: 255, nullable: true),
                    DSC_COMPLEMENTO_PARECER = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HST_CAD_Parecer", x => x.SEQ_HISTORICO_PARECER);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HST_CAD_Parecer");

            migrationBuilder.DropColumn(
                name: "DSC_COMPLEMENTO_PARECER",
                table: "CAD_PARECER");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_MOTIVO_DEVOLUCAO",
                table: "CAD_PARECER",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
