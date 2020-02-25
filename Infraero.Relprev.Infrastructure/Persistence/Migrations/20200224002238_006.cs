using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class _006 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionalidade",
                columns: table => new
                {
                    CodFuncionalidade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    NomFuncionalidade = table.Column<string>(nullable: true),
                    CodModulo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionalidade", x => x.CodFuncionalidade);
                    table.ForeignKey(
                        name: "FK_Funcionalidade_Modulo_CodModulo",
                        column: x => x.CodModulo,
                        principalTable: "Modulo",
                        principalColumn: "CodModulo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Funcionalidade",
                columns: new[] { "CodFuncionalidade", "AlteradoPor", "CodModulo", "CriadoPor", "DataAlteracao", "DataCriacao", "NomFuncionalidade" },
                values: new object[,]
                {
                    { 1, null, 1, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(2951), "Search,Insert,Delete,Update" },
                    { 2, null, 2, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3078), "Search,Insert,Delete,Update" },
                    { 3, null, 3, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3092), "Search,Insert,Delete,Update" },
                    { 4, null, 4, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3103), "Search,Insert,Delete,Update" },
                    { 5, null, 5, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3114), "Search,Insert,Delete,Update" },
                    { 6, null, 6, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3124), "Search,Insert,Delete,Update" }
                });

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                columns: new[] { "DataCriacao", "NomModulo" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7091), "UnidadeInfraestrutura" });

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                columns: new[] { "DataCriacao", "NomModulo" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7828), "Empresa" });

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                columns: new[] { "DataCriacao", "NomModulo" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7850), "ResponsavelTecnico" });

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                columns: new[] { "DataCriacao", "NomModulo" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7854), "Assunto" });

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                columns: new[] { "DataCriacao", "NomModulo" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7856), "SubAssunto" });

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                columns: new[] { "DataCriacao", "NomModulo" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7860), "Local" });

            migrationBuilder.InsertData(
                table: "Modulo",
                columns: new[] { "CodModulo", "AlteradoPor", "CriadoPor", "DataAlteracao", "DataCriacao", "NomModulo" },
                values: new object[,]
                {
                    { 13, null, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7882), "ParecerTecnico" },
                    { 14, null, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7885), "ContratoSmartStream" },
                    { 11, null, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7876), "AtribuirResponsavelRelato" },
                    { 9, null, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7869), "Perfil" },
                    { 8, null, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7866), "Usuario" },
                    { 7, null, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7863), "SubLocal" },
                    { 12, null, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7879), "AtendimentoTecnico" },
                    { 10, null, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7873), "Relatos" }
                });

            migrationBuilder.InsertData(
                table: "Funcionalidade",
                columns: new[] { "CodFuncionalidade", "AlteradoPor", "CodModulo", "CriadoPor", "DataAlteracao", "DataCriacao", "NomFuncionalidade" },
                values: new object[,]
                {
                    { 7, null, 7, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3134), "Search,Insert,Delete,Update" },
                    { 8, null, 8, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3144), "Search,Insert,Delete,Update" },
                    { 9, null, 9, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3155), "Search,Insert,Delete,Update" },
                    { 10, null, 10, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3165), "Search,Insert,Update,Cancel,Finalize" },
                    { 11, null, 11, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3177), "Send" },
                    { 12, null, 12, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3187), "Cancel,Details,Execute,Finalize,Assign" },
                    { 13, null, 13, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3198), "Complete,Evaluate,Reply" },
                    { 14, null, 14, "SistemaRelprev", null, new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3208), "Import,Configure" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionalidade_CodModulo",
                table: "Funcionalidade",
                column: "CodModulo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionalidade");

            migrationBuilder.DeleteData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                columns: new[] { "DataCriacao", "NomModulo" },
                values: new object[] { new DateTime(2020, 2, 20, 8, 46, 22, 672, DateTimeKind.Local).AddTicks(5522), "Cadastros" });

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                columns: new[] { "DataCriacao", "NomModulo" },
                values: new object[] { new DateTime(2020, 2, 20, 8, 46, 22, 672, DateTimeKind.Local).AddTicks(6193), "Relatos" });

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                columns: new[] { "DataCriacao", "NomModulo" },
                values: new object[] { new DateTime(2020, 2, 20, 8, 46, 22, 672, DateTimeKind.Local).AddTicks(6211), "AtribuirResponsavelRelato" });

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                columns: new[] { "DataCriacao", "NomModulo" },
                values: new object[] { new DateTime(2020, 2, 20, 8, 46, 22, 672, DateTimeKind.Local).AddTicks(6215), "AtendimentoTecnico" });

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                columns: new[] { "DataCriacao", "NomModulo" },
                values: new object[] { new DateTime(2020, 2, 20, 8, 46, 22, 672, DateTimeKind.Local).AddTicks(6218), "ParecerTecnico" });

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                columns: new[] { "DataCriacao", "NomModulo" },
                values: new object[] { new DateTime(2020, 2, 20, 8, 46, 22, 672, DateTimeKind.Local).AddTicks(6221), "ContratoSmartStream" });
        }
    }
}
