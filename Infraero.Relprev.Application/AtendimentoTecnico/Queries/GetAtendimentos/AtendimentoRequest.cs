using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraero.Relprev.Application.AtendimentoTecnico.Queries.GetAtendimentoTecnico
{
    public class AtendimentoRequest
    {
            public string NumRelato { get; set; }
            public int CodResponsavelTecnico { get; set; }
            public string FlgStatusRelato { get; set; }
            public string DtOcorrenciaInicio { get; set; }
            public string DtOcorrenciaFim { get; set; }
    }

    
}
