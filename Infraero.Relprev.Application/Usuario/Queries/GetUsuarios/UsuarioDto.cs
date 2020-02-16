using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;

namespace Infraero.Relprev.Application.Usuario.Queries.GetUsuarios
{
    public class UsuarioDto : IMapFrom<Domain.Entities.Usuario>
    {
        public string CodUsuario { get; set; }
        public string NomUsuario { get; set; }
        public string NumCpf { get; set; }
        public string DscEmail { get; set; }
        public string NumTelefone { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public int CodPerfil { get; set; }
        public UnidadeInfraEstruturaDto UnidadeInfraestrutura { get; set; }
        public string DscPerfil { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Usuario, UsuarioDto>();
        }
    }
}
