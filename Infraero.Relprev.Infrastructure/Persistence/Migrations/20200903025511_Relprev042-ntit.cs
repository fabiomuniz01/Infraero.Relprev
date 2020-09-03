using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev042ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NOM_Modulo",
                table: "TAB_MODULO",
                maxLength: 100,
                nullable: false,
                comment: "Descriçao do Modulo",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "TAB_MODULO",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "TAB_MODULO",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "TAB_MODULO",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "TAB_MODULO",
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "TAB_MODULO",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_MODULO",
                table: "TAB_MODULO",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_FUNCIONALIDADE",
                table: "TAB_FUNCIONALIDADE",
                maxLength: 100,
                nullable: false,
                comment: "Descriçao do Funcionalidade",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "TAB_FUNCIONALIDADE",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "TAB_FUNCIONALIDADE",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "TAB_FUNCIONALIDADE",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "TAB_FUNCIONALIDADE",
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_MODULO",
                table: "TAB_FUNCIONALIDADE",
                nullable: false,
                comment: "Descriçao do Funcionalidade",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "TAB_FUNCIONALIDADE",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_FUNCIONALIDADE",
                table: "TAB_FUNCIONALIDADE",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "HST_CAD_RELATO",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ULTIMA_OCORRENCIA",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do assunto",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_PARECER",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do status de finalização",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_NAO_INICIADO",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do status nao iniciado",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_FINALIZACAO",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do status de finalização",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_CLASSIFICACAO",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do status de classificação",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_CANCELAMENTO",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do status de cancelamento",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ATRIBUICAO",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do status de atribuição",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "HST_CAD_RELATO",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "HST_CAD_RELATO",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "HST_CAD_RELATO",
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "HST_CAD_RELATO",
                nullable: false,
                comment: "Codigo sequencial do relato",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "HST_CAD_RELATO",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_HISTORICO_RELATO",
                table: "HST_CAD_RELATO",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "FLG_STATUS_RELATO",
                table: "HST_CAD_PARECER",
                nullable: false,
                comment: "Status do parecer",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "HST_CAD_PARECER",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ULTIMA_OCORRENCIA",
                table: "HST_CAD_PARECER",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao da última Ocorrência",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_PARECER",
                table: "HST_CAD_PARECER",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do parecer",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_MOTIVO_DEVOLUCAO",
                table: "HST_CAD_PARECER",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do motivo da devolução",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_COMPLEMENTO_PARECER",
                table: "HST_CAD_PARECER",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do complemento do parecer",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "HST_CAD_PARECER",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "HST_CAD_PARECER",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "HST_CAD_PARECER",
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_PARECER",
                table: "HST_CAD_PARECER",
                nullable: false,
                comment: "Codigo sequencial do Parecer",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "HST_CAD_PARECER",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_HISTORICO_PARECER",
                table: "HST_CAD_PARECER",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_UNIDADE_INFRAESTRUTURA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                maxLength: 255,
                nullable: true,
                comment: "Nome da unidade de infraestrutura",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                maxLength: 255,
                nullable: true,
                comment: "Nome da empresa",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                nullable: false,
                comment: "Sequencial da tabela unidade de infraestrutura",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "COD_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                nullable: false,
                comment: "Sequencial da tabela empresa",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_VINCULO_UNIDADE_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                nullable: false,
                comment: "Sequencial da tabela unidade de infraestrutura",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "COD_RESPONSAVEL_TECNICO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                nullable: false,
                comment: "Sequencial da tabela responsavel tecnico",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "COD_EMPRESA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                nullable: false,
                comment: "Sequencial da tabela empresa",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_VINCULO_RESPONSAVEL_EMPRESA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_USUARIO",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "END_ENDERECO_ELETRONICO",
                table: "CAD_USUARIO",
                maxLength: 150,
                nullable: false,
                comment: "Endereço eletrônico válido do usuário",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

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
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
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

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_USUARIO",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

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
                name: "SIG_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                maxLength: 8,
                nullable: false,
                comment: "Sigla da unidade",
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                comment: "Localização da Unidade de Infraestrutura",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "END_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                comment: "Localização da Unidade de Infraestrutura",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INI_VIGENCIA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                comment: "Data de Início do período de vigência da Unidade cadastrada",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_FIM_VIGENCIA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                comment: "Data de Fim do período de vigência da Unidade cadastrada",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                comment: "Detalhamento da Unidade de Infraestrutura",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                comment: "Código da unidade",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_SUBLOCAL",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_SUBLOCAL",
                table: "CAD_SUBLOCAL",
                maxLength: 300,
                nullable: false,
                comment: "Descrição do sublocal da ocorrencia",
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

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
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

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

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_SUBLOCAL",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_SUBLOCAL",
                table: "CAD_SUBLOCAL",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_SUBASSUNTO",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_SUBASSUNTO",
                table: "CAD_SUBASSUNTO",
                maxLength: 255,
                nullable: false,
                comment: "Descrição do subassunto",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

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
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_ASSUNTO",
                table: "CAD_SUBASSUNTO",
                nullable: false,
                comment: "Código sequencial do subassunto",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_SUBASSUNTO",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

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
                name: "FLG_GESTOR_SGSO",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: false,
                comment: "Flag gestor sgso site",
                oldClrType: typeof(bool),
                oldType: "bit");

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
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: false,
                comment: "Codigo sequencia da unidade de infraestrutura",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
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

            migrationBuilder.AlterColumn<string>(
                name: "NOM_ARQUIVO",
                table: "CAD_RELATO_ARQUIVO",
                maxLength: 200,
                nullable: false,
                comment: "Nome original do arquivo",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

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
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "CAD_RELATO_ARQUIVO",
                nullable: false,
                comment: "Codigo sequencial do relato",
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "NOM_ARQUIVO_UNICO",
                table: "CAD_RELATO_ARQUIVO",
                maxLength: 500,
                nullable: false,
                comment: "Nome unico do arquivo",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RELATO_ARQUIVO",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_RELATO_ARQUIVO",
                table: "CAD_RELATO_ARQUIVO",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_SUB_LOCAL",
                table: "CAD_RELATO",
                nullable: false,
                comment: "Sub local classificado",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "COD_SUB_ASSUNTO",
                table: "CAD_RELATO",
                nullable: false,
                comment: "Sub assunto classificado",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "COD_LOCAL",
                table: "CAD_RELATO",
                nullable: false,
                comment: "Local classificado",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "COD_ASSUNTO",
                table: "CAD_RELATO",
                nullable: false,
                comment: "Assunto classificado",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RELATO",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_PERFIL",
                table: "CAD_PERFIL",
                maxLength: 100,
                nullable: false,
                comment: "Nome do Perfil",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_PERFIL",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_PERFIL",
                table: "CAD_PERFIL",
                maxLength: 255,
                nullable: false,
                comment: "Descriçao do Perfil",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_PERFIL",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_PERFIL",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_PERFIL",
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_PERFIL",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_PERFIL",
                table: "CAD_PERFIL",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_ARQUIVO",
                table: "CAD_PARECER_ARQUIVO",
                maxLength: 200,
                nullable: false,
                comment: "Nome original do arquivo",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_PARECER_ARQUIVO",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_PARECER_ARQUIVO",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_PARECER_ARQUIVO",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_PARECER_ARQUIVO",
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_PARECER",
                table: "CAD_PARECER_ARQUIVO",
                nullable: false,
                comment: "Codigo sequencial do PARECER",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DIR_CAMINHO",
                table: "CAD_PARECER_ARQUIVO",
                maxLength: 500,
                nullable: false,
                comment: "Diretorio do arquivo",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_ARQUIVO_UNICO",
                table: "CAD_PARECER_ARQUIVO",
                maxLength: 500,
                nullable: false,
                comment: "Nome unico do arquivo",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_PARECER_ARQUIVO",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_PARECER_ARQUIVO",
                table: "CAD_PARECER_ARQUIVO",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "FLG_STATUS_RELATO",
                table: "CAD_PARECER",
                nullable: false,
                comment: "Status do parecer",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_PARECER",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_PARECER",
                table: "CAD_PARECER",
                maxLength: 500,
                nullable: false,
                comment: "Descrição do parecer",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_MOTIVO_DEVOLUCAO",
                table: "CAD_PARECER",
                maxLength: 500,
                nullable: true,
                comment: "Descrição do motivo da devolucao",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_COMPLEMENTO_PARECER",
                table: "CAD_PARECER",
                maxLength: 500,
                nullable: true,
                comment: "Descrição do complemento do parecer",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_PARECER",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_PARECER",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_PARECER",
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "CAD_PARECER",
                nullable: false,
                comment: "Relato a qual o parecer é atribuído",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_PARECER",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_PARECER",
                table: "CAD_PARECER",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_LOCAL",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_LOCAL",
                table: "CAD_LOCAL",
                maxLength: 255,
                nullable: false,
                comment: "Descrição do local da ocorrencia",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

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
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_LOCAL",
                nullable: false,
                comment: "Codigo sequencial da unidade de infraestrutura",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_LOCAL",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

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

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_EMPRESA",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_REGISTRO",
                table: "CAD_EMPRESA",
                nullable: false,
                comment: "Data Hora de registro",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

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

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_EMPRESA",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
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
                name: "TXT_MOTIVO_CANCELAMENTO",
                table: "CAD_CONFIG_AMBIENTE",
                maxLength: 1000,
                nullable: false,
                comment: "Texto descritivo a ser inserido no e-mail de notificação em caso de cancelamento do relato",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<int>(
                name: "QTD_TEMPO_NOTIFICACAO_PARA_RESPONDER",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: false,
                comment: "Tempo em que dever ser notificado por e-mail as Respostas dos Pareceres Técnicos",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "QTD_PARECER_TECNICO",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: false,
                comment: "Tempo que o técnico deve ter para responder um parecer técnico",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "QTD_DEVOLVIDO_PARA_COMPLEMENTO",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: false,
                comment: "Tempo de resposta do parecer técnico quando o mesmo é rejeitado e devolvido para complemento",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_CONFIG_AMBIENTE",
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_CONFIG_AMBIENTE",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_CONFIG_AMBIENTE",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_OBS_ATRIBUICAO",
                table: "CAD_ATRIBUICAO_RELATO",
                maxLength: 455,
                nullable: true,
                comment: "Descrição da observação da atribuição",
                oldClrType: typeof(string),
                oldType: "nvarchar(455)",
                oldMaxLength: 455,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_FIM_ATENDIMENTO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: true,
                comment: "Data Hora fim do atendimento",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ATRIBUICAO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                comment: "Data Hora da atribuição",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_PARECER_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO",
                maxLength: 455,
                nullable: true,
                comment: "Descrição do parecer técnico",
                oldClrType: typeof(string),
                oldType: "nvarchar(455)",
                oldMaxLength: 455,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_ATRIBUICAO_RELATO",
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "COD_USUARIO_ATRIBUIDOR",
                table: "CAD_ATRIBUICAO_RELATO",
                maxLength: 455,
                nullable: true,
                comment: "Código sequencial do usuário atribuidor. OBS: caso valor nulo, usuario atribuidor igual a SistemaRelprev",
                oldClrType: typeof(string),
                oldType: "nvarchar(455)",
                oldMaxLength: 455,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_SITUACAO_ATRIBUICAO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                comment: "Código de situação da atribuição",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "COD_RESPONSAVEL_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                comment: "Código do responsavel SGSO da atribuicao do relato",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                comment: "Código sequencial do relato",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_ATRIBUICAO_RELATO",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_ATRIBUICAO_RELATO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
                comment: "Descriçao do assunto",
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
                maxLength: 256,
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_ASSUNTO",
                maxLength: 256,
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_ASSUNTO",
                table: "CAD_ASSUNTO",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NOM_Modulo",
                table: "TAB_MODULO",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldComment: "Descriçao do Modulo");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "TAB_MODULO",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "TAB_MODULO",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "TAB_MODULO",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "TAB_MODULO",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "TAB_MODULO",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_MODULO",
                table: "TAB_MODULO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_FUNCIONALIDADE",
                table: "TAB_FUNCIONALIDADE",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldComment: "Descriçao do Funcionalidade");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "TAB_FUNCIONALIDADE",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "TAB_FUNCIONALIDADE",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "TAB_FUNCIONALIDADE",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "TAB_FUNCIONALIDADE",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_MODULO",
                table: "TAB_FUNCIONALIDADE",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Descriçao do Funcionalidade");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "TAB_FUNCIONALIDADE",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_FUNCIONALIDADE",
                table: "TAB_FUNCIONALIDADE",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "HST_CAD_RELATO",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ULTIMA_OCORRENCIA",
                table: "HST_CAD_RELATO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Descriçao do assunto");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_PARECER",
                table: "HST_CAD_RELATO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Descriçao do status de finalização");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_NAO_INICIADO",
                table: "HST_CAD_RELATO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Descriçao do status nao iniciado");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_FINALIZACAO",
                table: "HST_CAD_RELATO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Descriçao do status de finalização");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_CLASSIFICACAO",
                table: "HST_CAD_RELATO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Descriçao do status de classificação");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_CANCELAMENTO",
                table: "HST_CAD_RELATO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Descriçao do status de cancelamento");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ATRIBUICAO",
                table: "HST_CAD_RELATO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Descriçao do status de atribuição");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "HST_CAD_RELATO",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "HST_CAD_RELATO",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "HST_CAD_RELATO",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "HST_CAD_RELATO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Codigo sequencial do relato");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "HST_CAD_RELATO",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_HISTORICO_RELATO",
                table: "HST_CAD_RELATO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "FLG_STATUS_RELATO",
                table: "HST_CAD_PARECER",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Status do parecer");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "HST_CAD_PARECER",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ULTIMA_OCORRENCIA",
                table: "HST_CAD_PARECER",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Descriçao da última Ocorrência");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_PARECER",
                table: "HST_CAD_PARECER",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Descriçao do parecer");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_MOTIVO_DEVOLUCAO",
                table: "HST_CAD_PARECER",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Descriçao do motivo da devolução");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_COMPLEMENTO_PARECER",
                table: "HST_CAD_PARECER",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Descriçao do complemento do parecer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "HST_CAD_PARECER",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "HST_CAD_PARECER",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "HST_CAD_PARECER",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_PARECER",
                table: "HST_CAD_PARECER",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Codigo sequencial do Parecer");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "HST_CAD_PARECER",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_HISTORICO_PARECER",
                table: "HST_CAD_PARECER",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_UNIDADE_INFRAESTRUTURA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Nome da unidade de infraestrutura");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Nome da empresa");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela unidade de infraestrutura");

            migrationBuilder.AlterColumn<int>(
                name: "COD_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela empresa");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_VINCULO_UNIDADE_EMPRESA",
                table: "CAD_VINCULO_UNIDADE_EMPRESA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela unidade de infraestrutura");

            migrationBuilder.AlterColumn<int>(
                name: "COD_RESPONSAVEL_TECNICO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela responsavel tecnico");

            migrationBuilder.AlterColumn<int>(
                name: "COD_EMPRESA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela empresa");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_VINCULO_RESPONSAVEL_EMPRESA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_USUARIO",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "END_ENDERECO_ELETRONICO",
                table: "CAD_USUARIO",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150,
                oldComment: "Endereço eletrônico válido do usuário");

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
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

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

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_USUARIO",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

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
                name: "SIG_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 8,
                oldComment: "Sigla da unidade");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Localização da Unidade de Infraestrutura");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "END_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Localização da Unidade de Infraestrutura");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INI_VIGENCIA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data de Início do período de vigência da Unidade cadastrada");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_FIM_VIGENCIA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data de Fim do período de vigência da Unidade cadastrada");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Detalhamento da Unidade de Infraestrutura");

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
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldComment: "Código da unidade");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_SUBLOCAL",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_SUBLOCAL",
                table: "CAD_SUBLOCAL",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 300,
                oldComment: "Descrição do sublocal da ocorrencia");

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
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

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

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_SUBLOCAL",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_SUBLOCAL",
                table: "CAD_SUBLOCAL",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_SUBASSUNTO",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_SUBASSUNTO",
                table: "CAD_SUBASSUNTO",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldComment: "Descrição do subassunto");

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
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_ASSUNTO",
                table: "CAD_SUBASSUNTO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Código sequencial do subassunto");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_SUBASSUNTO",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

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
                name: "FLG_GESTOR_SGSO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Flag gestor sgso site");

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
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Codigo sequencia da unidade de infraestrutura");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
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

            migrationBuilder.AlterColumn<string>(
                name: "NOM_ARQUIVO",
                table: "CAD_RELATO_ARQUIVO",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldComment: "Nome original do arquivo");

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
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "CAD_RELATO_ARQUIVO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Codigo sequencial do relato");

            migrationBuilder.AlterColumn<string>(
                name: "DIR_CAMINHO",
                table: "CAD_RELATO_ARQUIVO",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldComment: "Diretorio do arquivo");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_ARQUIVO_UNICO",
                table: "CAD_RELATO_ARQUIVO",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldComment: "Nome unico do arquivo");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RELATO_ARQUIVO",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_RELATO_ARQUIVO",
                table: "CAD_RELATO_ARQUIVO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_SUB_LOCAL",
                table: "CAD_RELATO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sub local classificado");

            migrationBuilder.AlterColumn<int>(
                name: "COD_SUB_ASSUNTO",
                table: "CAD_RELATO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sub assunto classificado");

            migrationBuilder.AlterColumn<int>(
                name: "COD_LOCAL",
                table: "CAD_RELATO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Local classificado");

            migrationBuilder.AlterColumn<int>(
                name: "COD_ASSUNTO",
                table: "CAD_RELATO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Assunto classificado");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_RELATO",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_PERFIL",
                table: "CAD_PERFIL",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldComment: "Nome do Perfil");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_PERFIL",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_PERFIL",
                table: "CAD_PERFIL",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldComment: "Descriçao do Perfil");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_PERFIL",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_PERFIL",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_PERFIL",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_PERFIL",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_PERFIL",
                table: "CAD_PERFIL",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_ARQUIVO",
                table: "CAD_PARECER_ARQUIVO",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldComment: "Nome original do arquivo");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_PARECER_ARQUIVO",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_PARECER_ARQUIVO",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_PARECER_ARQUIVO",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_PARECER_ARQUIVO",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_PARECER",
                table: "CAD_PARECER_ARQUIVO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Codigo sequencial do PARECER");

            migrationBuilder.AlterColumn<string>(
                name: "DIR_CAMINHO",
                table: "CAD_PARECER_ARQUIVO",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldComment: "Diretorio do arquivo");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_ARQUIVO_UNICO",
                table: "CAD_PARECER_ARQUIVO",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldComment: "Nome unico do arquivo");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_PARECER_ARQUIVO",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_PARECER_ARQUIVO",
                table: "CAD_PARECER_ARQUIVO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "FLG_STATUS_RELATO",
                table: "CAD_PARECER",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Status do parecer");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_PARECER",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_PARECER",
                table: "CAD_PARECER",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldComment: "Descrição do parecer");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_MOTIVO_DEVOLUCAO",
                table: "CAD_PARECER",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true,
                oldComment: "Descrição do motivo da devolucao");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_COMPLEMENTO_PARECER",
                table: "CAD_PARECER",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true,
                oldComment: "Descrição do complemento do parecer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_PARECER",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_PARECER",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_PARECER",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "CAD_PARECER",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Relato a qual o parecer é atribuído");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_PARECER",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_PARECER",
                table: "CAD_PARECER",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_LOCAL",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_LOCAL",
                table: "CAD_LOCAL",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldComment: "Descrição do local da ocorrencia");

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
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_LOCAL",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Codigo sequencial da unidade de infraestrutura");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_LOCAL",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

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

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_EMPRESA",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_REGISTRO",
                table: "CAD_EMPRESA",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data Hora de registro");

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
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

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

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_EMPRESA",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

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
                name: "TXT_MOTIVO_CANCELAMENTO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 1000,
                oldComment: "Texto descritivo a ser inserido no e-mail de notificação em caso de cancelamento do relato");

            migrationBuilder.AlterColumn<int>(
                name: "QTD_TEMPO_NOTIFICACAO_PARA_RESPONDER",
                table: "CAD_CONFIG_AMBIENTE",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Tempo em que dever ser notificado por e-mail as Respostas dos Pareceres Técnicos");

            migrationBuilder.AlterColumn<int>(
                name: "QTD_PARECER_TECNICO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Tempo que o técnico deve ter para responder um parecer técnico");

            migrationBuilder.AlterColumn<int>(
                name: "QTD_DEVOLVIDO_PARA_COMPLEMENTO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Tempo de resposta do parecer técnico quando o mesmo é rejeitado e devolvido para complemento");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_CONFIG_AMBIENTE",
                table: "CAD_CONFIG_AMBIENTE",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_OBS_ATRIBUICAO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "nvarchar(455)",
                maxLength: 455,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 455,
                oldNullable: true,
                oldComment: "Descrição da observação da atribuição");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_FIM_ATENDIMENTO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data Hora fim do atendimento");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ATRIBUICAO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data Hora da atribuição");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_PARECER_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "nvarchar(455)",
                maxLength: 455,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 455,
                oldNullable: true,
                oldComment: "Descrição do parecer técnico");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "COD_USUARIO_ATRIBUIDOR",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "nvarchar(455)",
                maxLength: 455,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 455,
                oldNullable: true,
                oldComment: "Código sequencial do usuário atribuidor. OBS: caso valor nulo, usuario atribuidor igual a SistemaRelprev");

            migrationBuilder.AlterColumn<int>(
                name: "COD_SITUACAO_ATRIBUICAO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Código de situação da atribuição");

            migrationBuilder.AlterColumn<int>(
                name: "COD_RESPONSAVEL_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Código do responsavel SGSO da atribuicao do relato");

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Código sequencial do relato");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_ATRIBUICAO_RELATO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
                oldComment: "Descriçao do assunto");

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
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_ASSUNTO",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_ASSUNTO",
                table: "CAD_ASSUNTO",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
