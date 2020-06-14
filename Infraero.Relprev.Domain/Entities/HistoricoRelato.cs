using System;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class HistoricoRelato : AuditableEntity
    {
        [Key]
        public int CodHistoricoRelato { get; set; }
        public int CodRelato { get; set; }
        public string DscUltimaOcorrencia { get; set; }
        public string DscNaoIniciado { get; set; }
        public string DscAtribuicao { get; set; }
        public string DscClassificacao { get; set; }
        public string DscCancelamento { get; set; }
        public string DscFinalizacao { get; set; }
    }
}
