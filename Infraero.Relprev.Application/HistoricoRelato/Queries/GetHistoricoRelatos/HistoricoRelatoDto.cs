using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraero.Relprev.Application.HistoricoRelato.Queries.GetHistoricoRelatos
{
    public class HistoricoRelatoDto : IMapFrom<Domain.Entities.HistoricoRelato>
    {
        [Key]
        public int CodHistoricoRelato { get; set; }
        public int CodRelato { get; set; }
        public string DscUltimaOcorrencia { get; set; }
        public string DscNaoIniciado { get; set; }
        public string DscAtribuicao { get; set; }
        public string DscClassificacao { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.HistoricoRelato, HistoricoRelatoDto>();
        }
    }
}
