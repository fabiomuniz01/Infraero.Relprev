using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev008ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DSC_EMAIL",
                table: "CAD_USUARIO",
                newName: "END_ENDERECO_ELETRONICO");

            migrationBuilder.RenameColumn(
                name: "NOM_CAMINHO",
                table: "CAD_RELATO_ARQUIVO",
                newName: "DIR_CAMINHO");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_TELEFONE",
                table: "CAD_USUARIO",
                maxLength: 14,
                nullable: false,
                comment: "Telefone de contato do usuário",
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CPF",
                table: "CAD_USUARIO",
                maxLength: 14,
                nullable: false,
                comment: "Número do CPF do usuário",
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USUARIO",
                table: "CAD_USUARIO",
                maxLength: 60,
                nullable: false,
                comment: "Descrição completa do nome do usuário",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_PERFIL",
                table: "CAD_USUARIO",
                maxLength: 150,
                nullable: true,
                comment: "Nome d perfil do usuário",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "COD_USUARIO_LOGIN",
                table: "CAD_USUARIO",
                nullable: true,
                comment: "Código do login do usuário",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_USUARIO",
                nullable: false,
                comment: "Código sequencial do unidade de infraestrutura",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "COD_PERFIL",
                table: "CAD_USUARIO",
                maxLength: 250,
                nullable: true,
                comment: "Código do perfil do usuário",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_EMPRESA",
                table: "CAD_USUARIO",
                nullable: false,
                comment: "Código sequencial da empresa",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_USUARIO",
                table: "CAD_USUARIO",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "END_ENDERECO_ELETRONICO",
                table: "CAD_USUARIO",
                maxLength: 150,
                nullable: false,
                comment: "Endereço eletrônico válido do usuário",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "SIG_UNIDADE",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                maxLength: 8,
                nullable: false,
                comment: "Sigla da unidade",
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "COD_UNIDADE",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                comment: "Código da unidade",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_SUBLOCAL",
                table: "CAD_SUBLOCAL",
                maxLength: 300,
                nullable: false,
                comment: "Descrição do sublocal da ocorrencia",
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_SUBLOCAL",
                nullable: false,
                comment: "Código sequencial da unidade de infraestrutura",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "COD_LOCAL",
                table: "CAD_SUBLOCAL",
                nullable: false,
                comment: "Código sequencial do local",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_SUBLOCAL",
                table: "CAD_SUBLOCAL",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_SUBASSUNTO",
                table: "CAD_SUBASSUNTO",
                maxLength: 255,
                nullable: false,
                comment: "Descrição do subassunto",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "COD_ASSUNTO",
                table: "CAD_SUBASSUNTO",
                nullable: false,
                comment: "Código sequencial do subassunto",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_SUBASSUNTO",
                table: "CAD_SUBASSUNTO",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_ARQUIVO",
                table: "CAD_RELATO_ARQUIVO",
                maxLength: 200,
                nullable: false,
                comment: "Nome original do arquivo",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "CAD_RELATO_ARQUIVO",
                nullable: false,
                comment: "Codigo sequencial do relato",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_ARQUIVO_UNICO",
                table: "CAD_RELATO_ARQUIVO",
                maxLength: 500,
                nullable: false,
                comment: "Nome unico do arquivo",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_RELATO_ARQUIVO",
                table: "CAD_RELATO_ARQUIVO",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DIR_CAMINHO",
                table: "CAD_RELATO_ARQUIVO",
                maxLength: 500,
                nullable: false,
                comment: "Diretorio do arquivo",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_LOCAL",
                table: "CAD_LOCAL",
                maxLength: 255,
                nullable: false,
                comment: "Descrição do local da ocorrencia",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_LOCAL",
                nullable: false,
                comment: "Codigo sequencial da unidade de infraestrutura",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_LOCAL",
                table: "CAD_LOCAL",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_TELEFONE",
                table: "CAD_EMPRESA",
                maxLength: 14,
                nullable: true,
                comment: "Telefone da empresa",
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CNPJ",
                table: "CAD_EMPRESA",
                maxLength: 18,
                nullable: false,
                comment: "CNPJ da empresa / órgão público",
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_RAZAO_SOCIAL",
                table: "CAD_EMPRESA",
                maxLength: 250,
                nullable: false,
                comment: "Empresa órgão público",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_REGISTRO",
                table: "CAD_EMPRESA",
                nullable: false,
                comment: "Data Hora de registro",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CPF_CRIADO_POR",
                table: "CAD_EMPRESA",
                maxLength: 18,
                nullable: true,
                comment: "Numero cpf criado por",
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_EMPRESA",
                table: "CAD_EMPRESA",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ASSUNTO",
                table: "CAD_ASSUNTO",
                maxLength: 255,
                nullable: false,
                comment: "Descriçao do assunto",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldComment: "");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_ASSUNTO",
                table: "CAD_ASSUNTO",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 646, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 646, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 646, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 646, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 646, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 646, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 646, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 646, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 646, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 646, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 646, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 646, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 646, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 646, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 646, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 643, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 643, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 643, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 643, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 643, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 643, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 643, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 643, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 643, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 643, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 643, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 643, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 643, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 643, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 26, 43, 643, DateTimeKind.Local).AddTicks(4853));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "END_ENDERECO_ELETRONICO",
                table: "CAD_USUARIO",
                newName: "DSC_EMAIL");

            migrationBuilder.RenameColumn(
                name: "DIR_CAMINHO",
                table: "CAD_RELATO_ARQUIVO",
                newName: "NOM_CAMINHO");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_TELEFONE",
                table: "CAD_USUARIO",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 14,
                oldComment: "Telefone de contato do usuário");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CPF",
                table: "CAD_USUARIO",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 14,
                oldComment: "Número do CPF do usuário");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USUARIO",
                table: "CAD_USUARIO",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60,
                oldComment: "Descrição completa do nome do usuário");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_PERFIL",
                table: "CAD_USUARIO",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150,
                oldNullable: true,
                oldComment: "Nome d perfil do usuário");

            migrationBuilder.AlterColumn<string>(
                name: "COD_USUARIO_LOGIN",
                table: "CAD_USUARIO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Código do login do usuário");

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_USUARIO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Código sequencial do unidade de infraestrutura");

            migrationBuilder.AlterColumn<string>(
                name: "COD_PERFIL",
                table: "CAD_USUARIO",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldNullable: true,
                oldComment: "Código do perfil do usuário");

            migrationBuilder.AlterColumn<int>(
                name: "COD_EMPRESA",
                table: "CAD_USUARIO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Código sequencial da empresa");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_USUARIO",
                table: "CAD_USUARIO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_EMAIL",
                table: "CAD_USUARIO",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150,
                oldComment: "Endereço eletrônico válido do usuário");

            migrationBuilder.AlterColumn<string>(
                name: "SIG_UNIDADE",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 8,
                oldComment: "Sigla da unidade");

            migrationBuilder.AlterColumn<string>(
                name: "COD_UNIDADE",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Código da unidade");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_SUBLOCAL",
                table: "CAD_SUBLOCAL",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 300,
                oldComment: "Descrição do sublocal da ocorrencia");

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_SUBLOCAL",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Código sequencial da unidade de infraestrutura");

            migrationBuilder.AlterColumn<int>(
                name: "COD_LOCAL",
                table: "CAD_SUBLOCAL",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Código sequencial do local");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_SUBLOCAL",
                table: "CAD_SUBLOCAL",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_SUBASSUNTO",
                table: "CAD_SUBASSUNTO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldComment: "Descrição do subassunto");

            migrationBuilder.AlterColumn<int>(
                name: "COD_ASSUNTO",
                table: "CAD_SUBASSUNTO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Código sequencial do subassunto");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_SUBASSUNTO",
                table: "CAD_SUBASSUNTO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_ARQUIVO",
                table: "CAD_RELATO_ARQUIVO",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldComment: "Nome original do arquivo");

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "CAD_RELATO_ARQUIVO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Codigo sequencial do relato");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_ARQUIVO_UNICO",
                table: "CAD_RELATO_ARQUIVO",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldComment: "Nome unico do arquivo");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_RELATO_ARQUIVO",
                table: "CAD_RELATO_ARQUIVO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_CAMINHO",
                table: "CAD_RELATO_ARQUIVO",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldComment: "Diretorio do arquivo");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_LOCAL",
                table: "CAD_LOCAL",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldComment: "Descrição do local da ocorrencia");

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_LOCAL",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Codigo sequencial da unidade de infraestrutura");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_LOCAL",
                table: "CAD_LOCAL",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_TELEFONE",
                table: "CAD_EMPRESA",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 14,
                oldNullable: true,
                oldComment: "Telefone da empresa");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CNPJ",
                table: "CAD_EMPRESA",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 18,
                oldComment: "CNPJ da empresa / órgão público");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_RAZAO_SOCIAL",
                table: "CAD_EMPRESA",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldComment: "Empresa órgão público");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_REGISTRO",
                table: "CAD_EMPRESA",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data Hora de registro");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CPF_CRIADO_POR",
                table: "CAD_EMPRESA",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 18,
                oldNullable: true,
                oldComment: "Numero cpf criado por");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_EMPRESA",
                table: "CAD_EMPRESA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ASSUNTO",
                table: "CAD_ASSUNTO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                comment: "",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldComment: "Descriçao do assunto");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_ASSUNTO",
                table: "CAD_ASSUNTO",
                type: "int",
                nullable: false,
                comment: "",
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
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
    }
}
