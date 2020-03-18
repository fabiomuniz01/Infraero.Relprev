using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnexoRelato");

            migrationBuilder.CreateTable(
                name: "Arquivo",
                columns: table => new
                {
                    CodArquivo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    CodRelato = table.Column<int>(nullable: false),
                    BinArquivo = table.Column<byte[]>(nullable: true),
                    NomArquivo = table.Column<string>(nullable: true),
                    RelatoCodRelato = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arquivo", x => x.CodArquivo);
                    table.ForeignKey(
                        name: "FK_Arquivo_Relato_RelatoCodRelato",
                        column: x => x.RelatoCodRelato,
                        principalTable: "Relato",
                        principalColumn: "CodRelato",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.CreateIndex(
                name: "IX_Arquivo_RelatoCodRelato",
                table: "Arquivo",
                column: "RelatoCodRelato");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arquivo");

            migrationBuilder.CreateTable(
                name: "AnexoRelato",
                columns: table => new
                {
                    CodAnexo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BinAnexo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CodAtribuicaoRelato = table.Column<int>(type: "int", nullable: true),
                    CodAtribuicaoRelatoNavigationCodAtribuicaoRelato = table.Column<int>(type: "int", nullable: true),
                    CodRelato = table.Column<int>(type: "int", nullable: false),
                    CodRelatoNavigationCodRelato = table.Column<int>(type: "int", nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DscAnexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DthRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipFormatoAnexo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnexoRelato", x => x.CodAnexo);
                    table.ForeignKey(
                        name: "FK_AnexoRelato_AtribuicaoRelato_CodAtribuicaoRelatoNavigationCodAtribuicaoRelato",
                        column: x => x.CodAtribuicaoRelatoNavigationCodAtribuicaoRelato,
                        principalTable: "AtribuicaoRelato",
                        principalColumn: "CodAtribuicaoRelato",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnexoRelato_Relato_CodRelatoNavigationCodRelato",
                        column: x => x.CodRelatoNavigationCodRelato,
                        principalTable: "Relato",
                        principalColumn: "CodRelato",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 839, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 839, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 839, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 839, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 839, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 839, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 839, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 839, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 839, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 839, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 839, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 839, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 839, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 839, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 837, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 837, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 837, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 837, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 837, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 837, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 837, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 837, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 837, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 837, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 837, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 837, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 837, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 14, 40, 12, 837, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.CreateIndex(
                name: "IX_AnexoRelato_CodAtribuicaoRelatoNavigationCodAtribuicaoRelato",
                table: "AnexoRelato",
                column: "CodAtribuicaoRelatoNavigationCodAtribuicaoRelato");

            migrationBuilder.CreateIndex(
                name: "IX_AnexoRelato_CodRelatoNavigationCodRelato",
                table: "AnexoRelato",
                column: "CodRelatoNavigationCodRelato");
        }
    }
}
