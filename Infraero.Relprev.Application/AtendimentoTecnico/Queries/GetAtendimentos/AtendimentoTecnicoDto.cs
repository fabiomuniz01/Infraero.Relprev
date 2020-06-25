using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraero.Relprev.Application.AtendimentoTecnico.Queries.GetAtendimentoTecnico
{
    [Serializable]
    public class AtendimentoTecnicoDto
    {
        public class AtendimentoTecnicoRequest
        {
            public string NumRelato { get; set; }
            public string CodResponsavelTecnico { get; set; }
            public string FlgStatusRelato { get; set; }
            public string DtInicio { get; set; }
            public string DtFim { get; set; }
        }

        public class AtendimentoTecnicoResponse
        {
            public List<RelatoDto> ListRelato { get; set; }
        }
    }

    
}
