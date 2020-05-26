using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev007ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_USUARIO",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_USUARIO",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_USUARIO",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_USUARIO",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_USUARIO",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_SUBLOCAL",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_SUBLOCAL",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_SUBLOCAL",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_SUBLOCAL",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_SUBLOCAL",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_SUBASSUNTO",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_SUBASSUNTO",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_SUBASSUNTO",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_SUBASSUNTO",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_SUBASSUNTO",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NUM_TELEFONE",
                table: "CAD_RESPONSAVEL_TECNICO",
                maxLength: 14,
                nullable: false,
                comment: "Número do telefone",
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "NUM_DOCUMENTO",
                table: "CAD_RESPONSAVEL_TECNICO",
                maxLength: 15,
                nullable: true,
                comment: "Número do documento de correspondência",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CPF",
                table: "CAD_RESPONSAVEL_TECNICO",
                maxLength: 14,
                nullable: false,
                comment: "Número do CPF do Responsável Técnico ",
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_RESPONSAVEL_TECNICO",
                table: "CAD_RESPONSAVEL_TECNICO",
                maxLength: 50,
                nullable: false,
                comment: "Nome do Responsável Técnico  ",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "END_RESPONSAVEL_TECNICO",
                table: "CAD_RESPONSAVEL_TECNICO",
                maxLength: 50,
                nullable: true,
                comment: "Endereço eletrônico do Responsável Técnico ",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: false,
                comment: "Codigo sequencia da unidade de infraestrutura",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "COD_EMPRESA",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: false,
                comment: "Codigo sequencial da empresa",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_RESPONSAVEL_TECNICO",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_RELATO_ARQUIVO",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_RELATO_ARQUIVO",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_RELATO_ARQUIVO",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_RELATO_ARQUIVO",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RELATO_ARQUIVO",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_RELATO",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_RELATO",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_RELATO",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_RELATO",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RELATO",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_LOCAL",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_LOCAL",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_LOCAL",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_LOCAL",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_LOCAL",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_EMPRESA",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_EMPRESA",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_EMPRESA",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_EMPRESA",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_EMPRESA",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_ASSUNTO",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ASSUNTO",
                table: "CAD_ASSUNTO",
                maxLength: 255,
                nullable: false,
                comment: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_ASSUNTO",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_ASSUNTO",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_ASSUNTO",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_ASSUNTO",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_ASSUNTO",
                table: "CAD_ASSUNTO",
                nullable: false,
                comment: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 255)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 687, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 687, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 687, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 687, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 687, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 687, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 687, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 687, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 687, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 687, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 687, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 687, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 687, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 687, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 687, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 684, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 684, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 684, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 684, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 684, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 684, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 684, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 684, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 684, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 684, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 684, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 684, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 684, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 684, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 9, 29, 684, DateTimeKind.Local).AddTicks(4724));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_USUARIO",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_USUARIO",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_USUARIO",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_USUARIO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_USUARIO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_SUBLOCAL",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_SUBLOCAL",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_SUBLOCAL",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_SUBLOCAL",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_SUBLOCAL",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_SUBASSUNTO",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_SUBASSUNTO",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_SUBASSUNTO",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_SUBASSUNTO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_SUBASSUNTO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_TELEFONE",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 14,
                oldComment: "Número do telefone");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_DOCUMENTO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15,
                oldNullable: true,
                oldComment: "Número do documento de correspondência");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CPF",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 14,
                oldComment: "Número do CPF do Responsável Técnico ");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_RESPONSAVEL_TECNICO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldComment: "Nome do Responsável Técnico  ");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "END_RESPONSAVEL_TECNICO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "Endereço eletrônico do Responsável Técnico ");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Codigo sequencia da unidade de infraestrutura");

            migrationBuilder.AlterColumn<int>(
                name: "COD_EMPRESA",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Codigo sequencial da empresa");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_RESPONSAVEL_TECNICO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_RELATO_ARQUIVO",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_RELATO_ARQUIVO",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_RELATO_ARQUIVO",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_RELATO_ARQUIVO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RELATO_ARQUIVO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_RELATO",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_RELATO",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_RELATO",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_LOCAL",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_LOCAL",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_LOCAL",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_LOCAL",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_LOCAL",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_EMPRESA",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_EMPRESA",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_EMPRESA",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_EMPRESA",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_EMPRESA",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_ASSUNTO",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ASSUNTO",
                table: "CAD_ASSUNTO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldComment: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_ASSUNTO",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_ASSUNTO",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_ASSUNTO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_ASSUNTO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_ASSUNTO",
                table: "CAD_ASSUNTO",
                type: "int",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1966));
        }
    }
}
