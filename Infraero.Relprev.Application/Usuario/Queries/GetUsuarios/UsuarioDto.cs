using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;

namespace Infraero.Relprev.Application.Usuario.Queries.GetUsuarios
{
    public class UsuarioDto : IMapFrom<Domain.Entities.Usuario>
    {
        public int CodUsuario { get; set; }

        public string NomRazaoSocial { get; set; }
        public string NumCnpj { get; set; }
        public string NumTelefone { get; set; }

        public string NomUnidadeInfraestrutura { get; set; }

        //public UnidadeInfraestrutura UnidadeInfraestrutura { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Usuario, UsuarioDto>();
        }
    }
}
