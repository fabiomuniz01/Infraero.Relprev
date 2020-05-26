using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.ConfigurarAmbiente.Queries.GetConfigurarAmbientes;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using System.Collections.Generic;

namespace Infraero.Relprev.Application.ConfigurarAmbiente.Queries.GetConfigurarAmbientes
{
    public class ConfigurarAmbienteDto : IMapFrom<Domain.Entities.ConfigurarAmbiente>
    {
        public int CodConfigurarAmbiente { get; set; }
        public int ParecerTecnico { get; set; }
        public int DevolvidoParaComplemento { get; set; }
        public int TempoNotificacaoParaResponder { get; set; }
        public string TextoMotivoCancelamento { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.ConfigurarAmbiente, ConfigurarAmbienteDto>();
        }
    }
}
