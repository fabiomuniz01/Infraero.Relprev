using System.Collections.Generic;
using Infraero.Relprev.Application.AtribuicaoRelato.Queries.GetAtribuicaoRelatos;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class AtribuirRespRelatoModel
    {
        public string NomeEmpresa { get; set; }
        public string CodEmpresa { get; set; }
        public SelectList ListEmpresa { get; set; }
        public string NomeResponsavel { get; set; }
        public string CodResponsavel { get; set; }
        public SelectList ListResponsavel { get; set; }
        public RelatoDto Relato { get; set; }
        public List<AtribuicaoRelatoDto> ListResponsavelTecnico { get; set; }


    }
}
