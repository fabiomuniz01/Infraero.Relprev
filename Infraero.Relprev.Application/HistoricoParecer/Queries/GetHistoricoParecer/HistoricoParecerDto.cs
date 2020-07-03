using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraero.Relprev.Application.HistoricoParecer.Queries.GetHistoricoParecer
{
    public class HistoricoParecerDto : IMapFrom<Domain.Entities.HistoricoParecer>
    {
        [Key]
        public int CodHistoricoParecer { get; set; }
        public int CodParecer { get; set; }
        public string DscParecer { get; set; }
        public string DscComplementoParecer { get; set; }
       
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.HistoricoParecer, HistoricoParecerDto>();
        }
    }
}
