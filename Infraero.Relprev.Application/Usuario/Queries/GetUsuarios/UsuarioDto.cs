using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;

namespace Infraero.Relprev.Application.Usuario.Queries.GetUsuarios
{
    public class UsuarioDto : IMapFrom<Domain.Entities.Usuario>
    {
        public int CodUsuario { get; set; }
        public string CodUsuarioLogin { get; set; }
        public string NomUsuario { get; set; }
        public string NumCpf { get; set; }
        public string NumTelefone { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public string CodPerfil { get; set; }
        public int CodEmpresa { get; set; }
        public string NomPerfil { get; set; }
        public string Email { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Usuario, UsuarioDto>();
        }
    }
}
