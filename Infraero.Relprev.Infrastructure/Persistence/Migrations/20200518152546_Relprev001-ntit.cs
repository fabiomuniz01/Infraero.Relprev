using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev001ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ambiente_Local_CodLocalidadeNavigationCodLocal",
                table: "Ambiente");

            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_Usuario_CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_SUBLOCAL_Local_COD_LOCAL",
                table: "CAD_SUBLOCAL");

            migrationBuilder.DropForeignKey(
                name: "FK_ContratoUtilizacaoSistema_Empresa_CodEmpresaNavigationCodEmpresa",
                table: "ContratoUtilizacaoSistema");

            migrationBuilder.DropForeignKey(
                name: "FK_ContratoUtilizacaoSistema_Local_CodLocalidadeNavigationCodLocal",
                table: "ContratoUtilizacaoSistema");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaLocalidade_Empresa_CodEmpresaNavigationCodEmpresa",
                table: "EmpresaLocalidade");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaLocalidade_Local_CodLocalidadeNavigationCodLocal",
                table: "EmpresaLocalidade");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaResponsavelTecnico_Local_CodLocalidadeNavigationCodLocal",
                table: "EmpresaResponsavelTecnico");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Usuario_CodUsuarioNavigationCodUsuario",
                table: "Evento");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoRelato_Usuario_CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_Local_UnidadeInfraestrutura_CodUnidadeInfraestrutura",
                table: "Local");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilUsuario_Usuario_CodUsuarioNavigationCodUsuario",
                table: "PerfilUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_ResponsavelTecnico_Empresa_CodEmpresa",
                table: "ResponsavelTecnico");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioLocalidade_Local_CodLocalidadeNavigationCodLocal",
                table: "UsuarioLocalidade");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioLocalidade_Usuario_CodUsuarioNavigationCodUsuario",
                table: "UsuarioLocalidade");

            migrationBuilder.DropForeignKey(
                name: "FK_VinculoUnidadeEmpresa_Empresa_CodEmpresa",
                table: "VinculoUnidadeEmpresa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Local",
                table: "Local");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "CAD_USUARIO");

            migrationBuilder.RenameTable(
                name: "Local",
                newName: "CAD_LOCAL");

            migrationBuilder.RenameTable(
                name: "Empresa",
                newName: "CAD_EMPRESA");

            migrationBuilder.RenameColumn(
                name: "NumTelefone",
                table: "CAD_USUARIO",
                newName: "NUM_TELEFONE");

            migrationBuilder.RenameColumn(
                name: "NumCpf",
                table: "CAD_USUARIO",
                newName: "NUM_CPF");

            migrationBuilder.RenameColumn(
                name: "NomUsuario",
                table: "CAD_USUARIO",
                newName: "NOM_USUARIO");

            migrationBuilder.RenameColumn(
                name: "NomPerfil",
                table: "CAD_USUARIO",
                newName: "NOM_PERFIL");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "CAD_USUARIO",
                newName: "DSC_EMAIL");

            migrationBuilder.RenameColumn(
                name: "CodUsuarioLogin",
                table: "CAD_USUARIO",
                newName: "COD_USUARIO_LOGIN");

            migrationBuilder.RenameColumn(
                name: "CodUnidadeInfraestrutura",
                table: "CAD_USUARIO",
                newName: "COD_UNIDADE_INFRAESTRUTURA");

            migrationBuilder.RenameColumn(
                name: "CodPerfil",
                table: "CAD_USUARIO",
                newName: "COD_PERFIL");

            migrationBuilder.RenameColumn(
                name: "CodEmpresa",
                table: "CAD_USUARIO",
                newName: "COD_EMPRESA");

            migrationBuilder.RenameColumn(
                name: "CodUsuario",
                table: "CAD_USUARIO",
                newName: "SEQ_USUARIO");

            migrationBuilder.RenameColumn(
                name: "DscLocal",
                table: "CAD_LOCAL",
                newName: "DSC_LOCAL");

            migrationBuilder.RenameColumn(
                name: "CodUnidadeInfraestrutura",
                table: "CAD_LOCAL",
                newName: "COD_UNIDADE_INFRAESTRUTURA");

            migrationBuilder.RenameColumn(
                name: "CodLocal",
                table: "CAD_LOCAL",
                newName: "SEQ_LOCAL");

            migrationBuilder.RenameIndex(
                name: "IX_Local_CodUnidadeInfraestrutura",
                table: "CAD_LOCAL",
                newName: "IX_CAD_LOCAL_COD_UNIDADE_INFRAESTRUTURA");

            migrationBuilder.RenameColumn(
                name: "NumTelefone",
                table: "CAD_EMPRESA",
                newName: "NUM_TELEFONE");

            migrationBuilder.RenameColumn(
                name: "NumCnpj",
                table: "CAD_EMPRESA",
                newName: "NUM_CNPJ");

            migrationBuilder.RenameColumn(
                name: "NomRazaoSocial",
                table: "CAD_EMPRESA",
                newName: "NOM_RAZAO_SOCIAL");

            migrationBuilder.RenameColumn(
                name: "DthRegistro",
                table: "CAD_EMPRESA",
                newName: "DTH_REGISTRO");

            migrationBuilder.RenameColumn(
                name: "CpfCriadoPor",
                table: "CAD_EMPRESA",
                newName: "NUM_CPF_CRIADO_POR");

            migrationBuilder.RenameColumn(
                name: "CodEmpresa",
                table: "CAD_EMPRESA",
                newName: "SEQ_EMPRESA");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_PERFIL",
                table: "CAD_USUARIO",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "COD_PERFIL",
                table: "CAD_USUARIO",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NUM_TELEFONE",
                table: "CAD_EMPRESA",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CNPJ",
                table: "CAD_EMPRESA",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_RAZAO_SOCIAL",
                table: "CAD_EMPRESA",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NUM_CPF_CRIADO_POR",
                table: "CAD_EMPRESA",
                maxLength: 18,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAD_USUARIO",
                table: "CAD_USUARIO",
                column: "SEQ_USUARIO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAD_LOCAL",
                table: "CAD_LOCAL",
                column: "SEQ_LOCAL");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAD_EMPRESA",
                table: "CAD_EMPRESA",
                column: "SEQ_EMPRESA");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.AddForeignKey(
                name: "FK_Ambiente_CAD_LOCAL_CodLocalidadeNavigationCodLocal",
                table: "Ambiente",
                column: "CodLocalidadeNavigationCodLocal",
                principalTable: "CAD_LOCAL",
                principalColumn: "SEQ_LOCAL",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_CAD_USUARIO_CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato",
                column: "CodUsuarioAtribuidorNavigationCodUsuario",
                principalTable: "CAD_USUARIO",
                principalColumn: "SEQ_USUARIO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_LOCAL_UnidadeInfraestrutura_COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_LOCAL",
                column: "COD_UNIDADE_INFRAESTRUTURA",
                principalTable: "UnidadeInfraestrutura",
                principalColumn: "CodUnidadeInfraestrutura",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_SUBLOCAL_CAD_LOCAL_COD_LOCAL",
                table: "CAD_SUBLOCAL",
                column: "COD_LOCAL",
                principalTable: "CAD_LOCAL",
                principalColumn: "SEQ_LOCAL",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContratoUtilizacaoSistema_CAD_EMPRESA_CodEmpresaNavigationCodEmpresa",
                table: "ContratoUtilizacaoSistema",
                column: "CodEmpresaNavigationCodEmpresa",
                principalTable: "CAD_EMPRESA",
                principalColumn: "SEQ_EMPRESA",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContratoUtilizacaoSistema_CAD_LOCAL_CodLocalidadeNavigationCodLocal",
                table: "ContratoUtilizacaoSistema",
                column: "CodLocalidadeNavigationCodLocal",
                principalTable: "CAD_LOCAL",
                principalColumn: "SEQ_LOCAL",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaLocalidade_CAD_EMPRESA_CodEmpresaNavigationCodEmpresa",
                table: "EmpresaLocalidade",
                column: "CodEmpresaNavigationCodEmpresa",
                principalTable: "CAD_EMPRESA",
                principalColumn: "SEQ_EMPRESA",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaLocalidade_CAD_LOCAL_CodLocalidadeNavigationCodLocal",
                table: "EmpresaLocalidade",
                column: "CodLocalidadeNavigationCodLocal",
                principalTable: "CAD_LOCAL",
                principalColumn: "SEQ_LOCAL",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaResponsavelTecnico_CAD_LOCAL_CodLocalidadeNavigationCodLocal",
                table: "EmpresaResponsavelTecnico",
                column: "CodLocalidadeNavigationCodLocal",
                principalTable: "CAD_LOCAL",
                principalColumn: "SEQ_LOCAL",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_CAD_USUARIO_CodUsuarioNavigationCodUsuario",
                table: "Evento",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "CAD_USUARIO",
                principalColumn: "SEQ_USUARIO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoRelato_CAD_USUARIO_CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "CAD_USUARIO",
                principalColumn: "SEQ_USUARIO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilUsuario_CAD_USUARIO_CodUsuarioNavigationCodUsuario",
                table: "PerfilUsuario",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "CAD_USUARIO",
                principalColumn: "SEQ_USUARIO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResponsavelTecnico_CAD_EMPRESA_CodEmpresa",
                table: "ResponsavelTecnico",
                column: "CodEmpresa",
                principalTable: "CAD_EMPRESA",
                principalColumn: "SEQ_EMPRESA",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioLocalidade_CAD_LOCAL_CodLocalidadeNavigationCodLocal",
                table: "UsuarioLocalidade",
                column: "CodLocalidadeNavigationCodLocal",
                principalTable: "CAD_LOCAL",
                principalColumn: "SEQ_LOCAL",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioLocalidade_CAD_USUARIO_CodUsuarioNavigationCodUsuario",
                table: "UsuarioLocalidade",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "CAD_USUARIO",
                principalColumn: "SEQ_USUARIO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VinculoUnidadeEmpresa_CAD_EMPRESA_CodEmpresa",
                table: "VinculoUnidadeEmpresa",
                column: "CodEmpresa",
                principalTable: "CAD_EMPRESA",
                principalColumn: "SEQ_EMPRESA",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ambiente_CAD_LOCAL_CodLocalidadeNavigationCodLocal",
                table: "Ambiente");

            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_CAD_USUARIO_CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_LOCAL_UnidadeInfraestrutura_COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_LOCAL");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_SUBLOCAL_CAD_LOCAL_COD_LOCAL",
                table: "CAD_SUBLOCAL");

            migrationBuilder.DropForeignKey(
                name: "FK_ContratoUtilizacaoSistema_CAD_EMPRESA_CodEmpresaNavigationCodEmpresa",
                table: "ContratoUtilizacaoSistema");

            migrationBuilder.DropForeignKey(
                name: "FK_ContratoUtilizacaoSistema_CAD_LOCAL_CodLocalidadeNavigationCodLocal",
                table: "ContratoUtilizacaoSistema");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaLocalidade_CAD_EMPRESA_CodEmpresaNavigationCodEmpresa",
                table: "EmpresaLocalidade");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaLocalidade_CAD_LOCAL_CodLocalidadeNavigationCodLocal",
                table: "EmpresaLocalidade");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaResponsavelTecnico_CAD_LOCAL_CodLocalidadeNavigationCodLocal",
                table: "EmpresaResponsavelTecnico");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_CAD_USUARIO_CodUsuarioNavigationCodUsuario",
                table: "Evento");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoRelato_CAD_USUARIO_CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilUsuario_CAD_USUARIO_CodUsuarioNavigationCodUsuario",
                table: "PerfilUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_ResponsavelTecnico_CAD_EMPRESA_CodEmpresa",
                table: "ResponsavelTecnico");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioLocalidade_CAD_LOCAL_CodLocalidadeNavigationCodLocal",
                table: "UsuarioLocalidade");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioLocalidade_CAD_USUARIO_CodUsuarioNavigationCodUsuario",
                table: "UsuarioLocalidade");

            migrationBuilder.DropForeignKey(
                name: "FK_VinculoUnidadeEmpresa_CAD_EMPRESA_CodEmpresa",
                table: "VinculoUnidadeEmpresa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAD_USUARIO",
                table: "CAD_USUARIO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAD_LOCAL",
                table: "CAD_LOCAL");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAD_EMPRESA",
                table: "CAD_EMPRESA");

            migrationBuilder.RenameTable(
                name: "CAD_USUARIO",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "CAD_LOCAL",
                newName: "Local");

            migrationBuilder.RenameTable(
                name: "CAD_EMPRESA",
                newName: "Empresa");

            migrationBuilder.RenameColumn(
                name: "NUM_TELEFONE",
                table: "Usuario",
                newName: "NumTelefone");

            migrationBuilder.RenameColumn(
                name: "NUM_CPF",
                table: "Usuario",
                newName: "NumCpf");

            migrationBuilder.RenameColumn(
                name: "NOM_USUARIO",
                table: "Usuario",
                newName: "NomUsuario");

            migrationBuilder.RenameColumn(
                name: "NOM_PERFIL",
                table: "Usuario",
                newName: "NomPerfil");

            migrationBuilder.RenameColumn(
                name: "DSC_EMAIL",
                table: "Usuario",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "COD_USUARIO_LOGIN",
                table: "Usuario",
                newName: "CodUsuarioLogin");

            migrationBuilder.RenameColumn(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "Usuario",
                newName: "CodUnidadeInfraestrutura");

            migrationBuilder.RenameColumn(
                name: "COD_PERFIL",
                table: "Usuario",
                newName: "CodPerfil");

            migrationBuilder.RenameColumn(
                name: "COD_EMPRESA",
                table: "Usuario",
                newName: "CodEmpresa");

            migrationBuilder.RenameColumn(
                name: "SEQ_USUARIO",
                table: "Usuario",
                newName: "CodUsuario");

            migrationBuilder.RenameColumn(
                name: "DSC_LOCAL",
                table: "Local",
                newName: "DscLocal");

            migrationBuilder.RenameColumn(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "Local",
                newName: "CodUnidadeInfraestrutura");

            migrationBuilder.RenameColumn(
                name: "SEQ_LOCAL",
                table: "Local",
                newName: "CodLocal");

            migrationBuilder.RenameIndex(
                name: "IX_CAD_LOCAL_COD_UNIDADE_INFRAESTRUTURA",
                table: "Local",
                newName: "IX_Local_CodUnidadeInfraestrutura");

            migrationBuilder.RenameColumn(
                name: "NUM_TELEFONE",
                table: "Empresa",
                newName: "NumTelefone");

            migrationBuilder.RenameColumn(
                name: "NUM_CNPJ",
                table: "Empresa",
                newName: "NumCnpj");

            migrationBuilder.RenameColumn(
                name: "NOM_RAZAO_SOCIAL",
                table: "Empresa",
                newName: "NomRazaoSocial");

            migrationBuilder.RenameColumn(
                name: "DTH_REGISTRO",
                table: "Empresa",
                newName: "DthRegistro");

            migrationBuilder.RenameColumn(
                name: "NUM_CPF_CRIADO_POR",
                table: "Empresa",
                newName: "CpfCriadoPor");

            migrationBuilder.RenameColumn(
                name: "SEQ_EMPRESA",
                table: "Empresa",
                newName: "CodEmpresa");

            migrationBuilder.AlterColumn<string>(
                name: "NomPerfil",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodPerfil",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NumTelefone",
                table: "Empresa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NumCnpj",
                table: "Empresa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "NomRazaoSocial",
                table: "Empresa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "CpfCriadoPor",
                table: "Empresa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 18,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "CodUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Local",
                table: "Local",
                column: "CodLocal");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa",
                column: "CodEmpresa");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 899, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 899, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 899, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 899, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 899, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 899, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 899, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 899, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 899, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 899, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 899, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 899, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 899, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 899, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 897, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 897, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 897, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 897, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 897, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 897, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 897, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 897, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 897, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 897, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 897, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 897, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 897, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 21, 3, 25, 897, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.AddForeignKey(
                name: "FK_Ambiente_Local_CodLocalidadeNavigationCodLocal",
                table: "Ambiente",
                column: "CodLocalidadeNavigationCodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_Usuario_CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato",
                column: "CodUsuarioAtribuidorNavigationCodUsuario",
                principalTable: "Usuario",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_SUBLOCAL_Local_COD_LOCAL",
                table: "CAD_SUBLOCAL",
                column: "COD_LOCAL",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContratoUtilizacaoSistema_Empresa_CodEmpresaNavigationCodEmpresa",
                table: "ContratoUtilizacaoSistema",
                column: "CodEmpresaNavigationCodEmpresa",
                principalTable: "Empresa",
                principalColumn: "CodEmpresa",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContratoUtilizacaoSistema_Local_CodLocalidadeNavigationCodLocal",
                table: "ContratoUtilizacaoSistema",
                column: "CodLocalidadeNavigationCodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaLocalidade_Empresa_CodEmpresaNavigationCodEmpresa",
                table: "EmpresaLocalidade",
                column: "CodEmpresaNavigationCodEmpresa",
                principalTable: "Empresa",
                principalColumn: "CodEmpresa",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaLocalidade_Local_CodLocalidadeNavigationCodLocal",
                table: "EmpresaLocalidade",
                column: "CodLocalidadeNavigationCodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaResponsavelTecnico_Local_CodLocalidadeNavigationCodLocal",
                table: "EmpresaResponsavelTecnico",
                column: "CodLocalidadeNavigationCodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Usuario_CodUsuarioNavigationCodUsuario",
                table: "Evento",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "Usuario",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoRelato_Usuario_CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "Usuario",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Local_UnidadeInfraestrutura_CodUnidadeInfraestrutura",
                table: "Local",
                column: "CodUnidadeInfraestrutura",
                principalTable: "UnidadeInfraestrutura",
                principalColumn: "CodUnidadeInfraestrutura",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilUsuario_Usuario_CodUsuarioNavigationCodUsuario",
                table: "PerfilUsuario",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "Usuario",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResponsavelTecnico_Empresa_CodEmpresa",
                table: "ResponsavelTecnico",
                column: "CodEmpresa",
                principalTable: "Empresa",
                principalColumn: "CodEmpresa",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioLocalidade_Local_CodLocalidadeNavigationCodLocal",
                table: "UsuarioLocalidade",
                column: "CodLocalidadeNavigationCodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioLocalidade_Usuario_CodUsuarioNavigationCodUsuario",
                table: "UsuarioLocalidade",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "Usuario",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VinculoUnidadeEmpresa_Empresa_CodEmpresa",
                table: "VinculoUnidadeEmpresa",
                column: "CodEmpresa",
                principalTable: "Empresa",
                principalColumn: "CodEmpresa",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
