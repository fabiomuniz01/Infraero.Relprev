using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev021ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VinculoUnidadeEmpresa_CAD_EMPRESA_CodEmpresa",
                table: "VinculoUnidadeEmpresa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VinculoUnidadeEmpresa",
                table: "VinculoUnidadeEmpresa");

            migrationBuilder.RenameTable(
                name: "VinculoUnidadeEmpresa",
                newName: "CAD_VINCULO_UNIDADE_EMPRESA");

            migrationBuilder.RenameColumn(
                name: "NomUnidadeInfraestrutura",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                newName: "NOM_UNIDADE_INFRAESTRUTURA");

            migrationBuilder.RenameColumn(
                name: "NomEmpresa",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                newName: "NOM_EMPRESA");

            migrationBuilder.RenameColumn(
                name: "FlagAtivo",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                newName: "FLG_ATIVO");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                newName: "DTH_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                newName: "DTH_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                newName: "NOM_USU_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "CodUnidadeInfraestrutura",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                newName: "COD_UNIDADE_INFRAESTRUTURA");

            migrationBuilder.RenameColumn(
                name: "CodEmpresa",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                newName: "COD_EMPRESA");

            migrationBuilder.RenameColumn(
                name: "AlteradoPor",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                newName: "NOM_USU_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CodVinculoUnidadeEmpresa",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                newName: "SEQ_VINCULO_UNIDADE_EMPRESA");

            migrationBuilder.RenameIndex(
                name: "IX_VinculoUnidadeEmpresa_CodEmpresa",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                newName: "IX_CAD_VINCULO_UNIDADE_EMPRESA_COD_EMPRESA");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "HST_CAD_RELATO",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ULTIMA_OCORRENCIA",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Descriçao do assunto");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_NAO_INICIADO",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Descriçao do status nao iniciado");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_FINALIZACAO",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Descriçao do status de finalização");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_CLASSIFICACAO",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Descriçao do status de classificação");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_CANCELAMENTO",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Descriçao do status de cancelamento");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ATRIBUICAO",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Descriçao do status de atribuição");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "HST_CAD_RELATO",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "HST_CAD_RELATO",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "HST_CAD_RELATO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "HST_CAD_RELATO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Codigo sequencial do relato");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "HST_CAD_RELATO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_HISTORICO_RELATO",
                table: "HST_CAD_RELATO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_TELEFONE",
                table: "CAD_USUARIO",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldComment: "Telefone de contato do usuário");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CPF",
                table: "CAD_USUARIO",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldComment: "Número do CPF do usuário");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USUARIO",
                table: "CAD_USUARIO",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldComment: "Descrição completa do nome do usuário");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_PERFIL",
                table: "CAD_USUARIO",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true,
                oldComment: "Nome d perfil do usuário");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_USUARIO",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "END_ENDERECO_ELETRONICO",
                table: "CAD_USUARIO",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldComment: "Endereço eletrônico válido do usuário");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_USUARIO",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_USUARIO",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_USUARIO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "COD_USUARIO_LOGIN",
                table: "CAD_USUARIO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Código do login do usuário");

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_USUARIO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Código sequencial do unidade de infraestrutura");

            migrationBuilder.AlterColumn<string>(
                name: "COD_PERFIL",
                table: "CAD_USUARIO",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true,
                oldComment: "Código do perfil do usuário");

            migrationBuilder.AlterColumn<int>(
                name: "COD_EMPRESA",
                table: "CAD_USUARIO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Código sequencial da empresa");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_USUARIO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_USUARIO",
                table: "CAD_USUARIO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "SIG_UNIDADE",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8,
                oldComment: "Sigla da unidade");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "COD_UNIDADE",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Código da unidade");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_SUBLOCAL",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_SUBLOCAL",
                table: "CAD_SUBLOCAL",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldComment: "Descrição do sublocal da ocorrencia");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_SUBLOCAL",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_SUBLOCAL",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_SUBLOCAL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_SUBLOCAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Código sequencial da unidade de infraestrutura");

            migrationBuilder.AlterColumn<int>(
                name: "COD_LOCAL",
                table: "CAD_SUBLOCAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Código sequencial do local");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_SUBLOCAL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_SUBLOCAL",
                table: "CAD_SUBLOCAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_SUBASSUNTO",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_SUBASSUNTO",
                table: "CAD_SUBASSUNTO",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldComment: "Descrição do subassunto");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_SUBASSUNTO",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_SUBASSUNTO",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_SUBASSUNTO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_ASSUNTO",
                table: "CAD_SUBASSUNTO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Código sequencial do subassunto");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_SUBASSUNTO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_SUBASSUNTO",
                table: "CAD_SUBASSUNTO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_TELEFONE",
                table: "CAD_RESPONSAVEL_TECNICO",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldComment: "Número do telefone");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_DOCUMENTO",
                table: "CAD_RESPONSAVEL_TECNICO",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true,
                oldComment: "Número do documento de correspondência");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CPF",
                table: "CAD_RESPONSAVEL_TECNICO",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldComment: "Número do CPF do Responsável Técnico ");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_RESPONSAVEL_TECNICO",
                table: "CAD_RESPONSAVEL_TECNICO",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Nome do Responsável Técnico  ");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_GESTOR_SGSO",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Flag gestor sgso site");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "END_RESPONSAVEL_TECNICO",
                table: "CAD_RESPONSAVEL_TECNICO",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "Endereço eletrônico do Responsável Técnico ");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Codigo sequencia da unidade de infraestrutura");

            migrationBuilder.AlterColumn<int>(
                name: "COD_EMPRESA",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Codigo sequencial da empresa");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_RESPONSAVEL_TECNICO",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_ARQUIVO",
                table: "CAD_RELATO_ARQUIVO",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "Nome original do arquivo");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_RELATO_ARQUIVO",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_RELATO_ARQUIVO",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_RELATO_ARQUIVO",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_RELATO_ARQUIVO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "CAD_RELATO_ARQUIVO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Codigo sequencial do relato");

            migrationBuilder.AlterColumn<string>(
                name: "DIR_CAMINHO",
                table: "CAD_RELATO_ARQUIVO",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "Diretorio do arquivo");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_ARQUIVO_UNICO",
                table: "CAD_RELATO_ARQUIVO",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "Nome unico do arquivo");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RELATO_ARQUIVO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_RELATO_ARQUIVO",
                table: "CAD_RELATO_ARQUIVO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_RELATO",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_RELATO",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_RELATO",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_RELATO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_SUB_LOCAL",
                table: "CAD_RELATO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Sub local classificado");

            migrationBuilder.AlterColumn<int>(
                name: "COD_SUB_ASSUNTO",
                table: "CAD_RELATO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Sub assunto classificado");

            migrationBuilder.AlterColumn<int>(
                name: "COD_LOCAL",
                table: "CAD_RELATO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Local classificado");

            migrationBuilder.AlterColumn<int>(
                name: "COD_ASSUNTO",
                table: "CAD_RELATO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Assunto classificado");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RELATO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_LOCAL",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_LOCAL",
                table: "CAD_LOCAL",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldComment: "Descrição do local da ocorrencia");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_LOCAL",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_LOCAL",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_LOCAL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_LOCAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Codigo sequencial da unidade de infraestrutura");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_LOCAL",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_LOCAL",
                table: "CAD_LOCAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_TELEFONE",
                table: "CAD_EMPRESA",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldNullable: true,
                oldComment: "Telefone da empresa");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CNPJ",
                table: "CAD_EMPRESA",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18,
                oldComment: "CNPJ da empresa / órgão público");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_RAZAO_SOCIAL",
                table: "CAD_EMPRESA",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldComment: "Empresa órgão público");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_EMPRESA",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_REGISTRO",
                table: "CAD_EMPRESA",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Data Hora de registro");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_EMPRESA",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_EMPRESA",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_EMPRESA",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CPF_CRIADO_POR",
                table: "CAD_EMPRESA",
                maxLength: 18,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18,
                oldNullable: true,
                oldComment: "Numero cpf criado por");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_EMPRESA",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_EMPRESA",
                table: "CAD_EMPRESA",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "TXT_MOTIVO_CANCELAMENTO",
                table: "CAD_CONFIG_AMBIENTE",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldComment: "Texto descritivo a ser inserido no e-mail de notificação em caso de cancelamento do relato");

            migrationBuilder.AlterColumn<int>(
                name: "QTD_TEMPO_NOTIFICACAO_PARA_RESPONDER",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Tempo em que dever ser notificado por e-mail as Respostas dos Pareceres Técnicos");

            migrationBuilder.AlterColumn<int>(
                name: "QTD_PARECER_TECNICO",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Tempo que o técnico deve ter para responder um parecer técnico");

            migrationBuilder.AlterColumn<int>(
                name: "QTD_DEVOLVIDO_PARA_COMPLEMENTO",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Tempo de resposta do parecer técnico quando o mesmo é rejeitado e devolvido para complemento");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_CONFIG_AMBIENTE",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_OBS_ATRIBUICAO",
                table: "CAD_ATRIBUICAO_RELATO",
                maxLength: 455,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(455)",
                oldMaxLength: 455,
                oldNullable: true,
                oldComment: "Descrição da observação da atribuição");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_FIM_ATENDIMENTO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Data Hora fim do atendimento");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ATRIBUICAO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Data Hora da atribuição");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_PARECER_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO",
                maxLength: 455,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(455)",
                oldMaxLength: 455,
                oldNullable: true,
                oldComment: "Descrição do parecer técnico");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_USUARIO_ATRIBUIDOR",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Código sequencial do usuário atribuidor. OBS: caso valor nulo, usuario atribuidor igual a SistemaRelprev");

            migrationBuilder.AlterColumn<int>(
                name: "COD_SITUACAO_ATRIBUICAO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Código de situação da atribuição");

            migrationBuilder.AlterColumn<int>(
                name: "COD_RESPONSAVEL_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Código do responsavel SGSO da atribuicao do relato");

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Código sequencial do relato");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_ATRIBUICAO_RELATO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_ASSUNTO",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ASSUNTO",
                table: "CAD_ASSUNTO",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldComment: "Descriçao do assunto");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_ASSUNTO",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_ASSUNTO",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_ASSUNTO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_ASSUNTO",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_ASSUNTO",
                table: "CAD_ASSUNTO",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_UNIDADE_INFRAESTRUTURA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAD_VINCULO_UNIDADE_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                column: "SEQ_VINCULO_UNIDADE_EMPRESA");

            migrationBuilder.CreateTable(
                name: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                columns: table => new
                {
                    SEQ_VINCULO_RESPONSAVEL_EMPRESA = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOM_USU_INCLUSAO = table.Column<string>(nullable: true),
                    DTH_INCLUSAO = table.Column<DateTime>(nullable: false),
                    NOM_USU_ALTERACAO = table.Column<string>(nullable: true),
                    DTH_ALTERACAO = table.Column<DateTime>(nullable: true),
                    FLG_ATIVO = table.Column<bool>(nullable: false),
                    COD_EMPRESA = table.Column<int>(nullable: false),
                    COD_RESPONSAVEL_TECNICO = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_VINCULO_RESPONSAVEL_EMPRESA", x => x.SEQ_VINCULO_RESPONSAVEL_EMPRESA);
                });

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 123, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 123, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 123, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 123, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 123, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 123, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 123, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 123, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 123, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 123, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 123, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 123, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 123, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 123, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 123, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 118, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 118, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 118, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 118, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 118, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 118, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 118, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 118, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 118, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 118, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 118, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 118, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 118, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 118, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 9, 44, 3, 118, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_VINCULO_UNIDADE_EMPRESA_CAD_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                column: "COD_EMPRESA",
                principalTable: "CAD_EMPRESA",
                principalColumn: "SEQ_EMPRESA",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_VINCULO_UNIDADE_EMPRESA_CAD_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA");

            migrationBuilder.DropTable(
                name: "CAD_VINCULO_RESPONSAVEL_EMPRESA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAD_VINCULO_UNIDADE_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA");

            migrationBuilder.RenameTable(
                name: "CAD_VINCULO_UNIDADE_EMPRESA",
                newName: "VinculoUnidadeEmpresa");

            migrationBuilder.RenameColumn(
                name: "NOM_UNIDADE_INFRAESTRUTURA",
                table: "VinculoUnidadeEmpresa",
                newName: "NomUnidadeInfraestrutura");

            migrationBuilder.RenameColumn(
                name: "NOM_EMPRESA",
                table: "VinculoUnidadeEmpresa",
                newName: "NomEmpresa");

            migrationBuilder.RenameColumn(
                name: "FLG_ATIVO",
                table: "VinculoUnidadeEmpresa",
                newName: "FlagAtivo");

            migrationBuilder.RenameColumn(
                name: "DTH_INCLUSAO",
                table: "VinculoUnidadeEmpresa",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DTH_ALTERACAO",
                table: "VinculoUnidadeEmpresa",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_INCLUSAO",
                table: "VinculoUnidadeEmpresa",
                newName: "CriadoPor");

            migrationBuilder.RenameColumn(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "VinculoUnidadeEmpresa",
                newName: "CodUnidadeInfraestrutura");

            migrationBuilder.RenameColumn(
                name: "COD_EMPRESA",
                table: "VinculoUnidadeEmpresa",
                newName: "CodEmpresa");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_ALTERACAO",
                table: "VinculoUnidadeEmpresa",
                newName: "AlteradoPor");

            migrationBuilder.RenameColumn(
                name: "SEQ_VINCULO_UNIDADE_EMPRESA",
                table: "VinculoUnidadeEmpresa",
                newName: "CodVinculoUnidadeEmpresa");

            migrationBuilder.RenameIndex(
                name: "IX_CAD_VINCULO_UNIDADE_EMPRESA_COD_EMPRESA",
                table: "VinculoUnidadeEmpresa",
                newName: "IX_VinculoUnidadeEmpresa_CodEmpresa");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "HST_CAD_RELATO",
                type: "bit",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ULTIMA_OCORRENCIA",
                table: "HST_CAD_RELATO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do assunto",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_NAO_INICIADO",
                table: "HST_CAD_RELATO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do status nao iniciado",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_FINALIZACAO",
                table: "HST_CAD_RELATO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do status de finalização",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_CLASSIFICACAO",
                table: "HST_CAD_RELATO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do status de classificação",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_CANCELAMENTO",
                table: "HST_CAD_RELATO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do status de cancelamento",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ATRIBUICAO",
                table: "HST_CAD_RELATO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do status de atribuição",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "HST_CAD_RELATO",
                type: "datetime2",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "HST_CAD_RELATO",
                type: "datetime2",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "HST_CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "HST_CAD_RELATO",
                type: "int",
                nullable: false,
                comment: "Codigo sequencial do relato",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "HST_CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_HISTORICO_RELATO",
                table: "HST_CAD_RELATO",
                type: "int",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_TELEFONE",
                table: "CAD_USUARIO",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                comment: "Telefone de contato do usuário",
                oldClrType: typeof(string),
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CPF",
                table: "CAD_USUARIO",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                comment: "Número do CPF do usuário",
                oldClrType: typeof(string),
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USUARIO",
                table: "CAD_USUARIO",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                comment: "Descrição completa do nome do usuário",
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_PERFIL",
                table: "CAD_USUARIO",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                comment: "Nome d perfil do usuário",
                oldClrType: typeof(string),
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_USUARIO",
                type: "bit",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "END_ENDERECO_ELETRONICO",
                table: "CAD_USUARIO",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                comment: "Endereço eletrônico válido do usuário",
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_USUARIO",
                type: "datetime2",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_USUARIO",
                type: "datetime2",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_USUARIO",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "COD_USUARIO_LOGIN",
                table: "CAD_USUARIO",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Código do login do usuário",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_USUARIO",
                type: "int",
                nullable: false,
                comment: "Código sequencial do unidade de infraestrutura",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "COD_PERFIL",
                table: "CAD_USUARIO",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                comment: "Código do perfil do usuário",
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_EMPRESA",
                table: "CAD_USUARIO",
                type: "int",
                nullable: false,
                comment: "Código sequencial da empresa",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_USUARIO",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_USUARIO",
                table: "CAD_USUARIO",
                type: "int",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "SIG_UNIDADE",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                comment: "Sigla da unidade",
                oldClrType: typeof(string),
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "bit",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "datetime2",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "datetime2",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "COD_UNIDADE",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Código da unidade",
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "int",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_SUBLOCAL",
                type: "bit",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "DSC_SUBLOCAL",
                table: "CAD_SUBLOCAL",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                comment: "Descrição do sublocal da ocorrencia",
                oldClrType: typeof(string),
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_SUBLOCAL",
                type: "datetime2",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_SUBLOCAL",
                type: "datetime2",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_SUBLOCAL",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_SUBLOCAL",
                type: "int",
                nullable: false,
                comment: "Código sequencial da unidade de infraestrutura",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "COD_LOCAL",
                table: "CAD_SUBLOCAL",
                type: "int",
                nullable: false,
                comment: "Código sequencial do local",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_SUBLOCAL",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_SUBLOCAL",
                table: "CAD_SUBLOCAL",
                type: "int",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_SUBASSUNTO",
                type: "bit",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "DSC_SUBASSUNTO",
                table: "CAD_SUBASSUNTO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                comment: "Descrição do subassunto",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_SUBASSUNTO",
                type: "datetime2",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_SUBASSUNTO",
                type: "datetime2",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_SUBASSUNTO",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_ASSUNTO",
                table: "CAD_SUBASSUNTO",
                type: "int",
                nullable: false,
                comment: "Código sequencial do subassunto",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_SUBASSUNTO",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_SUBASSUNTO",
                table: "CAD_SUBASSUNTO",
                type: "int",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_TELEFONE",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                comment: "Número do telefone",
                oldClrType: typeof(string),
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "NUM_DOCUMENTO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                comment: "Número do documento de correspondência",
                oldClrType: typeof(string),
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CPF",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                comment: "Número do CPF do Responsável Técnico ",
                oldClrType: typeof(string),
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_RESPONSAVEL_TECNICO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Nome do Responsável Técnico  ",
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_GESTOR_SGSO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "bit",
                nullable: false,
                comment: "Flag gestor sgso site",
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "bit",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "END_RESPONSAVEL_TECNICO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                comment: "Endereço eletrônico do Responsável Técnico ",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "datetime2",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "datetime2",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "int",
                nullable: false,
                comment: "Codigo sequencia da unidade de infraestrutura",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "COD_EMPRESA",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "int",
                nullable: false,
                comment: "Codigo sequencial da empresa",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_RESPONSAVEL_TECNICO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "int",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_ARQUIVO",
                table: "CAD_RELATO_ARQUIVO",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "Nome original do arquivo",
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_RELATO_ARQUIVO",
                type: "bit",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_RELATO_ARQUIVO",
                type: "datetime2",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_RELATO_ARQUIVO",
                type: "datetime2",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_RELATO_ARQUIVO",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "CAD_RELATO_ARQUIVO",
                type: "int",
                nullable: false,
                comment: "Codigo sequencial do relato",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "DIR_CAMINHO",
                table: "CAD_RELATO_ARQUIVO",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "Diretorio do arquivo",
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_ARQUIVO_UNICO",
                table: "CAD_RELATO_ARQUIVO",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "Nome unico do arquivo",
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RELATO_ARQUIVO",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_RELATO_ARQUIVO",
                table: "CAD_RELATO_ARQUIVO",
                type: "int",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_RELATO",
                type: "bit",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_RELATO",
                type: "datetime2",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_RELATO",
                type: "datetime2",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_SUB_LOCAL",
                table: "CAD_RELATO",
                type: "int",
                nullable: false,
                comment: "Sub local classificado",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "COD_SUB_ASSUNTO",
                table: "CAD_RELATO",
                type: "int",
                nullable: false,
                comment: "Sub assunto classificado",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "COD_LOCAL",
                table: "CAD_RELATO",
                type: "int",
                nullable: false,
                comment: "Local classificado",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "COD_ASSUNTO",
                table: "CAD_RELATO",
                type: "int",
                nullable: false,
                comment: "Assunto classificado",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_LOCAL",
                type: "bit",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "DSC_LOCAL",
                table: "CAD_LOCAL",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                comment: "Descrição do local da ocorrencia",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_LOCAL",
                type: "datetime2",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_LOCAL",
                type: "datetime2",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_LOCAL",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_LOCAL",
                type: "int",
                nullable: false,
                comment: "Codigo sequencial da unidade de infraestrutura",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_LOCAL",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_LOCAL",
                table: "CAD_LOCAL",
                type: "int",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_TELEFONE",
                table: "CAD_EMPRESA",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: true,
                comment: "Telefone da empresa",
                oldClrType: typeof(string),
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CNPJ",
                table: "CAD_EMPRESA",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                comment: "CNPJ da empresa / órgão público",
                oldClrType: typeof(string),
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_RAZAO_SOCIAL",
                table: "CAD_EMPRESA",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                comment: "Empresa órgão público",
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_EMPRESA",
                type: "bit",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_REGISTRO",
                table: "CAD_EMPRESA",
                type: "datetime2",
                nullable: false,
                comment: "Data Hora de registro",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_EMPRESA",
                type: "datetime2",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_EMPRESA",
                type: "datetime2",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_EMPRESA",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CPF_CRIADO_POR",
                table: "CAD_EMPRESA",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: true,
                comment: "Numero cpf criado por",
                oldClrType: typeof(string),
                oldMaxLength: 18,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_EMPRESA",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_EMPRESA",
                table: "CAD_EMPRESA",
                type: "int",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "TXT_MOTIVO_CANCELAMENTO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                comment: "Texto descritivo a ser inserido no e-mail de notificação em caso de cancelamento do relato",
                oldClrType: typeof(string),
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<int>(
                name: "QTD_TEMPO_NOTIFICACAO_PARA_RESPONDER",
                table: "CAD_CONFIG_AMBIENTE",
                type: "int",
                nullable: false,
                comment: "Tempo em que dever ser notificado por e-mail as Respostas dos Pareceres Técnicos",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "QTD_PARECER_TECNICO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "int",
                nullable: false,
                comment: "Tempo que o técnico deve ter para responder um parecer técnico",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "QTD_DEVOLVIDO_PARA_COMPLEMENTO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "int",
                nullable: false,
                comment: "Tempo de resposta do parecer técnico quando o mesmo é rejeitado e devolvido para complemento",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "datetime2",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "datetime2",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_CONFIG_AMBIENTE",
                table: "CAD_CONFIG_AMBIENTE",
                type: "int",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_OBS_ATRIBUICAO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "nvarchar(455)",
                maxLength: 455,
                nullable: true,
                comment: "Descrição da observação da atribuição",
                oldClrType: typeof(string),
                oldMaxLength: 455,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "bit",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_FIM_ATENDIMENTO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "datetime2",
                nullable: true,
                comment: "Data Hora fim do atendimento",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ATRIBUICAO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "datetime2",
                nullable: false,
                comment: "Data Hora da atribuição",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "DSC_PARECER_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "nvarchar(455)",
                maxLength: 455,
                nullable: true,
                comment: "Descrição do parecer técnico",
                oldClrType: typeof(string),
                oldMaxLength: 455,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "datetime2",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "datetime2",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_USUARIO_ATRIBUIDOR",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "int",
                nullable: false,
                comment: "Código sequencial do usuário atribuidor. OBS: caso valor nulo, usuario atribuidor igual a SistemaRelprev",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "COD_SITUACAO_ATRIBUICAO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "int",
                nullable: false,
                comment: "Código de situação da atribuição",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "COD_RESPONSAVEL_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "int",
                nullable: false,
                comment: "Código do responsavel SGSO da atribuicao do relato",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "int",
                nullable: false,
                comment: "Código sequencial do relato",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_ATRIBUICAO_RELATO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "int",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_ASSUNTO",
                type: "bit",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ASSUNTO",
                table: "CAD_ASSUNTO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                comment: "Descriçao do assunto",
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_ASSUNTO",
                type: "datetime2",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_ASSUNTO",
                type: "datetime2",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_ASSUNTO",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_ASSUNTO",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_ASSUNTO",
                table: "CAD_ASSUNTO",
                type: "int",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NomUnidadeInfraestrutura",
                table: "VinculoUnidadeEmpresa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomEmpresa",
                table: "VinculoUnidadeEmpresa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VinculoUnidadeEmpresa",
                table: "VinculoUnidadeEmpresa",
                column: "CodVinculoUnidadeEmpresa");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.AddForeignKey(
                name: "FK_VinculoUnidadeEmpresa_CAD_EMPRESA_CodEmpresa",
                table: "VinculoUnidadeEmpresa",
                column: "CodEmpresa",
                principalTable: "CAD_EMPRESA",
                principalColumn: "SEQ_EMPRESA",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
