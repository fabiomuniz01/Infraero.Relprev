using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_ResponsavelTecnicos_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_Usuarios_CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_ContratoUtilizacaoSistema_Empresas_CodEmpresaNavigationCodEmpresa",
                table: "ContratoUtilizacaoSistema");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaLocalidade_Empresas_CodEmpresaNavigationCodEmpresa",
                table: "EmpresaLocalidade");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaResponsavelTecnico_ResponsavelTecnicos_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "EmpresaResponsavelTecnico");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Usuarios_CodUsuarioNavigationCodUsuario",
                table: "Evento");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoRelato_Usuarios_CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_Local_UnidadeInfraestruturas_CodUnidadeInfraestrutura",
                table: "Local");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilUsuario_Usuarios_CodUsuarioNavigationCodUsuario",
                table: "PerfilUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Assuntos_CodAssuntoNavigationCodAssunto",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_SubAssuntos_CodSubAssuntoNavigationCodSubAssunto",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Usuarios_CodUsuarioRelatorNavigationCodUsuario",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_SubAssuntos_Assuntos_CodAssuntoNavigationCodAssunto",
                table: "SubAssuntos");

            migrationBuilder.DropForeignKey(
                name: "FK_SubLocals_Local_CodLocal",
                table: "SubLocals");

            migrationBuilder.DropForeignKey(
                name: "FK_UnidadeInfraestruturas_Empresas_EmpresaCodEmpresa",
                table: "UnidadeInfraestruturas");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioLocalidade_Usuarios_CodUsuarioNavigationCodUsuario",
                table: "UsuarioLocalidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnidadeInfraestruturas",
                table: "UnidadeInfraestruturas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubLocals",
                table: "SubLocals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubAssuntos",
                table: "SubAssuntos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResponsavelTecnicos",
                table: "ResponsavelTecnicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assuntos",
                table: "Assuntos");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "UnidadeInfraestruturas",
                newName: "UnidadeInfraestrutura");

            migrationBuilder.RenameTable(
                name: "SubLocals",
                newName: "SubLocal");

            migrationBuilder.RenameTable(
                name: "SubAssuntos",
                newName: "SubAssunto");

            migrationBuilder.RenameTable(
                name: "ResponsavelTecnicos",
                newName: "ResponsavelTecnico");

            migrationBuilder.RenameTable(
                name: "Empresas",
                newName: "Empresa");

            migrationBuilder.RenameTable(
                name: "Assuntos",
                newName: "Assunto");

            migrationBuilder.RenameIndex(
                name: "IX_UnidadeInfraestruturas_EmpresaCodEmpresa",
                table: "UnidadeInfraestrutura",
                newName: "IX_UnidadeInfraestrutura_EmpresaCodEmpresa");

            migrationBuilder.RenameIndex(
                name: "IX_SubLocals_CodLocal",
                table: "SubLocal",
                newName: "IX_SubLocal_CodLocal");

            migrationBuilder.RenameIndex(
                name: "IX_SubAssuntos_CodAssuntoNavigationCodAssunto",
                table: "SubAssunto",
                newName: "IX_SubAssunto_CodAssuntoNavigationCodAssunto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "CodUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnidadeInfraestrutura",
                table: "UnidadeInfraestrutura",
                column: "CodUnidadeInfraestrutura");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubLocal",
                table: "SubLocal",
                column: "CodSubLocal");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubAssunto",
                table: "SubAssunto",
                column: "CodSubAssunto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResponsavelTecnico",
                table: "ResponsavelTecnico",
                column: "CodResponsavelTecnico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa",
                column: "CodEmpresa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assunto",
                table: "Assunto",
                column: "CodAssunto");

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_ResponsavelTecnico_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato",
                column: "CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                principalTable: "ResponsavelTecnico",
                principalColumn: "CodResponsavelTecnico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_Usuario_CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato",
                column: "CodUsuarioAtribuidorNavigationCodUsuario",
                principalTable: "Usuario",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContratoUtilizacaoSistema_Empresa_CodEmpresaNavigationCodEmpresa",
                table: "ContratoUtilizacaoSistema",
                column: "CodEmpresaNavigationCodEmpresa",
                principalTable: "Empresa",
                principalColumn: "CodEmpresa",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaLocalidade_Empresa_CodEmpresaNavigationCodEmpresa",
                table: "EmpresaLocalidade",
                column: "CodEmpresaNavigationCodEmpresa",
                principalTable: "Empresa",
                principalColumn: "CodEmpresa",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaResponsavelTecnico_ResponsavelTecnico_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "EmpresaResponsavelTecnico",
                column: "CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                principalTable: "ResponsavelTecnico",
                principalColumn: "CodResponsavelTecnico",
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
                name: "FK_Relato_Assunto_CodAssuntoNavigationCodAssunto",
                table: "Relato",
                column: "CodAssuntoNavigationCodAssunto",
                principalTable: "Assunto",
                principalColumn: "CodAssunto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_SubAssunto_CodSubAssuntoNavigationCodSubAssunto",
                table: "Relato",
                column: "CodSubAssuntoNavigationCodSubAssunto",
                principalTable: "SubAssunto",
                principalColumn: "CodSubAssunto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Usuario_CodUsuarioRelatorNavigationCodUsuario",
                table: "Relato",
                column: "CodUsuarioRelatorNavigationCodUsuario",
                principalTable: "Usuario",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubAssunto_Assunto_CodAssuntoNavigationCodAssunto",
                table: "SubAssunto",
                column: "CodAssuntoNavigationCodAssunto",
                principalTable: "Assunto",
                principalColumn: "CodAssunto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubLocal_Local_CodLocal",
                table: "SubLocal",
                column: "CodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnidadeInfraestrutura_Empresa_EmpresaCodEmpresa",
                table: "UnidadeInfraestrutura",
                column: "EmpresaCodEmpresa",
                principalTable: "Empresa",
                principalColumn: "CodEmpresa",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioLocalidade_Usuario_CodUsuarioNavigationCodUsuario",
                table: "UsuarioLocalidade",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "Usuario",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_ResponsavelTecnico_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_Usuario_CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_ContratoUtilizacaoSistema_Empresa_CodEmpresaNavigationCodEmpresa",
                table: "ContratoUtilizacaoSistema");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaLocalidade_Empresa_CodEmpresaNavigationCodEmpresa",
                table: "EmpresaLocalidade");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaResponsavelTecnico_ResponsavelTecnico_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
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
                name: "FK_Relato_Assunto_CodAssuntoNavigationCodAssunto",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_SubAssunto_CodSubAssuntoNavigationCodSubAssunto",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Usuario_CodUsuarioRelatorNavigationCodUsuario",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_SubAssunto_Assunto_CodAssuntoNavigationCodAssunto",
                table: "SubAssunto");

            migrationBuilder.DropForeignKey(
                name: "FK_SubLocal_Local_CodLocal",
                table: "SubLocal");

            migrationBuilder.DropForeignKey(
                name: "FK_UnidadeInfraestrutura_Empresa_EmpresaCodEmpresa",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioLocalidade_Usuario_CodUsuarioNavigationCodUsuario",
                table: "UsuarioLocalidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnidadeInfraestrutura",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubLocal",
                table: "SubLocal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubAssunto",
                table: "SubAssunto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResponsavelTecnico",
                table: "ResponsavelTecnico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assunto",
                table: "Assunto");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "UnidadeInfraestrutura",
                newName: "UnidadeInfraestruturas");

            migrationBuilder.RenameTable(
                name: "SubLocal",
                newName: "SubLocals");

            migrationBuilder.RenameTable(
                name: "SubAssunto",
                newName: "SubAssuntos");

            migrationBuilder.RenameTable(
                name: "ResponsavelTecnico",
                newName: "ResponsavelTecnicos");

            migrationBuilder.RenameTable(
                name: "Empresa",
                newName: "Empresas");

            migrationBuilder.RenameTable(
                name: "Assunto",
                newName: "Assuntos");

            migrationBuilder.RenameIndex(
                name: "IX_UnidadeInfraestrutura_EmpresaCodEmpresa",
                table: "UnidadeInfraestruturas",
                newName: "IX_UnidadeInfraestruturas_EmpresaCodEmpresa");

            migrationBuilder.RenameIndex(
                name: "IX_SubLocal_CodLocal",
                table: "SubLocals",
                newName: "IX_SubLocals_CodLocal");

            migrationBuilder.RenameIndex(
                name: "IX_SubAssunto_CodAssuntoNavigationCodAssunto",
                table: "SubAssuntos",
                newName: "IX_SubAssuntos_CodAssuntoNavigationCodAssunto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "CodUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnidadeInfraestruturas",
                table: "UnidadeInfraestruturas",
                column: "CodUnidadeInfraestrutura");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubLocals",
                table: "SubLocals",
                column: "CodSubLocal");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubAssuntos",
                table: "SubAssuntos",
                column: "CodSubAssunto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResponsavelTecnicos",
                table: "ResponsavelTecnicos",
                column: "CodResponsavelTecnico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas",
                column: "CodEmpresa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assuntos",
                table: "Assuntos",
                column: "CodAssunto");

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_ResponsavelTecnicos_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato",
                column: "CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                principalTable: "ResponsavelTecnicos",
                principalColumn: "CodResponsavelTecnico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_Usuarios_CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato",
                column: "CodUsuarioAtribuidorNavigationCodUsuario",
                principalTable: "Usuarios",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContratoUtilizacaoSistema_Empresas_CodEmpresaNavigationCodEmpresa",
                table: "ContratoUtilizacaoSistema",
                column: "CodEmpresaNavigationCodEmpresa",
                principalTable: "Empresas",
                principalColumn: "CodEmpresa",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaLocalidade_Empresas_CodEmpresaNavigationCodEmpresa",
                table: "EmpresaLocalidade",
                column: "CodEmpresaNavigationCodEmpresa",
                principalTable: "Empresas",
                principalColumn: "CodEmpresa",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaResponsavelTecnico_ResponsavelTecnicos_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "EmpresaResponsavelTecnico",
                column: "CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                principalTable: "ResponsavelTecnicos",
                principalColumn: "CodResponsavelTecnico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Usuarios_CodUsuarioNavigationCodUsuario",
                table: "Evento",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "Usuarios",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoRelato_Usuarios_CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "Usuarios",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Local_UnidadeInfraestruturas_CodUnidadeInfraestrutura",
                table: "Local",
                column: "CodUnidadeInfraestrutura",
                principalTable: "UnidadeInfraestruturas",
                principalColumn: "CodUnidadeInfraestrutura",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilUsuario_Usuarios_CodUsuarioNavigationCodUsuario",
                table: "PerfilUsuario",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "Usuarios",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Assuntos_CodAssuntoNavigationCodAssunto",
                table: "Relato",
                column: "CodAssuntoNavigationCodAssunto",
                principalTable: "Assuntos",
                principalColumn: "CodAssunto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_SubAssuntos_CodSubAssuntoNavigationCodSubAssunto",
                table: "Relato",
                column: "CodSubAssuntoNavigationCodSubAssunto",
                principalTable: "SubAssuntos",
                principalColumn: "CodSubAssunto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Usuarios_CodUsuarioRelatorNavigationCodUsuario",
                table: "Relato",
                column: "CodUsuarioRelatorNavigationCodUsuario",
                principalTable: "Usuarios",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubAssuntos_Assuntos_CodAssuntoNavigationCodAssunto",
                table: "SubAssuntos",
                column: "CodAssuntoNavigationCodAssunto",
                principalTable: "Assuntos",
                principalColumn: "CodAssunto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubLocals_Local_CodLocal",
                table: "SubLocals",
                column: "CodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnidadeInfraestruturas_Empresas_EmpresaCodEmpresa",
                table: "UnidadeInfraestruturas",
                column: "EmpresaCodEmpresa",
                principalTable: "Empresas",
                principalColumn: "CodEmpresa",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioLocalidade_Usuarios_CodUsuarioNavigationCodUsuario",
                table: "UsuarioLocalidade",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "Usuarios",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
