using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos;
using Microsoft.AspNetCore.Http;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.Application.Usuario.Queries.GetUsuarios;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class ConfigurarAmbiente
    {
        public int CodConfigurarAmbiente { get; set; }
        public int QtdParecerTecnico { get; set; }
        public string DscMotivoCancelamento { get; set; }
        public int QtdTempoNotificacaoParaResponder { get; set; }
        public int QtdDevolvidoParaComplemento { get; set; }

    }
}
