using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class ConfigurarAmbiente : AuditableEntity
    {
        [Key]
        public int CodConfigurarAmbiente { get; set; }
        public int ParecerTecnico { get; set; }
        public int DevolvidoParaComplemento { get; set; }
        public int TempoNotificacaoParaResponder { get; set; }
        public string TextoMotivoCancelamento { get; set; }

    }
}
