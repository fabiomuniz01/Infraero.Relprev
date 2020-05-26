using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev005ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubAmbiente");

            migrationBuilder.DropTable(
                name: "Ambiente");

            migrationBuilder.DropColumn(
                name: "NomeRelatoArquivo",
                table: "CAD_RELATO_ARQUIVO");

            migrationBuilder.CreateTable(
                name: "CAD_CONFIG_AMBIENTE",
                columns: table => new
                {
                    SEQ_CONFIG_AMBIENTE = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOM_USU_INCLUSAO = table.Column<string>(nullable: true),
                    DTH_INCLUSAO = table.Column<DateTime>(nullable: false),
                    NOM_USU_ALTERACAO = table.Column<string>(nullable: true),
                    DTH_ALTERACAO = table.Column<DateTime>(nullable: true),
                    FLG_ATIVO = table.Column<bool>(nullable: false),
                    QTD_PARECER_TECNICO = table.Column<int>(nullable: false),
                    QTD_DEVOLVIDO_PARA_COMPLEMENTO = table.Column<int>(nullable: false),
                    QTD_TEMPO_NOTIFICACAO_PARA_RESPONDER = table.Column<int>(nullable: false),
                    TXT_MOTIVO_CANCELAMENTO = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_CONFIG_AMBIENTE", x => x.SEQ_CONFIG_AMBIENTE);
                });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4727));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CAD_CONFIG_AMBIENTE");

            migrationBuilder.AddColumn<string>(
                name: "NomeRelatoArquivo",
                table: "CAD_RELATO_ARQUIVO",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ambiente",
                columns: table => new
                {
                    CodAmbiente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodLocalidade = table.Column<int>(type: "int", nullable: false),
                    CodLocalidadeNavigationCodLocal = table.Column<int>(type: "int", nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatFimVigencia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatInicioVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DscAmbiente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DthRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlagAtivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambiente", x => x.CodAmbiente);
                    table.ForeignKey(
                        name: "FK_Ambiente_CAD_LOCAL_CodLocalidadeNavigationCodLocal",
                        column: x => x.CodLocalidadeNavigationCodLocal,
                        principalTable: "CAD_LOCAL",
                        principalColumn: "SEQ_LOCAL",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubAmbiente",
                columns: table => new
                {
                    CodSubAmbiente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodAmbiente = table.Column<int>(type: "int", nullable: true),
                    CodAmbienteNavigationCodAmbiente = table.Column<int>(type: "int", nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatFimVigencia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatInicioVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DscSubAmbiente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DthRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlagAtivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAmbiente", x => x.CodSubAmbiente);
                    table.ForeignKey(
                        name: "FK_SubAmbiente_Ambiente_CodAmbienteNavigationCodAmbiente",
                        column: x => x.CodAmbienteNavigationCodAmbiente,
                        principalTable: "Ambiente",
                        principalColumn: "CodAmbiente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 572, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 572, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 572, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 572, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 572, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 572, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 572, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 572, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 572, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 572, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 572, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 572, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 572, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 572, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 568, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 568, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 568, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 568, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 568, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 568, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 568, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 568, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 568, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 568, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 568, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 568, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 568, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 25, 12, 53, 21, 568, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.CreateIndex(
                name: "IX_Ambiente_CodLocalidadeNavigationCodLocal",
                table: "Ambiente",
                column: "CodLocalidadeNavigationCodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_SubAmbiente_CodAmbienteNavigationCodAmbiente",
                table: "SubAmbiente",
                column: "CodAmbienteNavigationCodAmbiente");
        }
    }
}
