using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class _007 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 54, 23, 406, DateTimeKind.Local).AddTicks(5079), "Consultar,Incluir,Excluir,Alterar" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 54, 23, 406, DateTimeKind.Local).AddTicks(5296), "Consultar,Incluir,Excluir,Alterar" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 54, 23, 406, DateTimeKind.Local).AddTicks(5310), "Consultar,Incluir,Excluir,Alterar" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 54, 23, 406, DateTimeKind.Local).AddTicks(5319), "Consultar,Incluir,Excluir,Alterar" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 54, 23, 406, DateTimeKind.Local).AddTicks(5327), "Consultar,Incluir,Excluir,Alterar" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 54, 23, 406, DateTimeKind.Local).AddTicks(5336), "Consultar,Incluir,Excluir,Alterar" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 54, 23, 406, DateTimeKind.Local).AddTicks(5346), "Consultar,Incluir,Excluir,Alterar" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 54, 23, 406, DateTimeKind.Local).AddTicks(5355), "Consultar,Incluir,Excluir,Alterar" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 54, 23, 406, DateTimeKind.Local).AddTicks(5365), "Consultar,Incluir,Excluir,Alterar" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 54, 23, 406, DateTimeKind.Local).AddTicks(5375), "Consultar,Incluir,Alterar,Cancelar,Finalizar" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 54, 23, 406, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 54, 23, 406, DateTimeKind.Local).AddTicks(5391), "Cancelar,Detalhar,Executar,Finalizar,Atribuir" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 54, 23, 406, DateTimeKind.Local).AddTicks(5398), "Completar,Avaliar,Responder" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 54, 23, 406, DateTimeKind.Local).AddTicks(5406), "Importar,Configurar" });

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 54, 23, 402, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 54, 23, 403, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 54, 23, 403, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 54, 23, 403, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 54, 23, 403, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 54, 23, 403, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 54, 23, 403, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 54, 23, 403, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 54, 23, 403, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 54, 23, 403, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 54, 23, 403, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 54, 23, 403, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 54, 23, 403, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 54, 23, 403, DateTimeKind.Local).AddTicks(854));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(2951), "Search,Insert,Delete,Update" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3078), "Search,Insert,Delete,Update" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3092), "Search,Insert,Delete,Update" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3103), "Search,Insert,Delete,Update" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3114), "Search,Insert,Delete,Update" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3124), "Search,Insert,Delete,Update" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3134), "Search,Insert,Delete,Update" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3144), "Search,Insert,Delete,Update" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3155), "Search,Insert,Delete,Update" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3165), "Search,Insert,Update,Cancel,Finalize" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3187), "Cancel,Details,Execute,Finalize,Assign" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3198), "Complete,Evaluate,Reply" });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                columns: new[] { "DataCriacao", "NomFuncionalidade" },
                values: new object[] { new DateTime(2020, 2, 23, 21, 22, 37, 460, DateTimeKind.Local).AddTicks(3208), "Import,Configure" });

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 21, 22, 37, 458, DateTimeKind.Local).AddTicks(7885));
        }
    }
}
