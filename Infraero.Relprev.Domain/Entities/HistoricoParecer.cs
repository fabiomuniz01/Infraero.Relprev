using System;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class HistoricoParecer : AuditableEntity
    {
        [Key]
        public int CodHistoricoParecer { get; set; }
        public int CodParecer { get; set; }
        public string DscUltimaOcorrencia { get; set; }
        public string DscParecer { get; set; }
        public string DscComplementoParecer { get; set; }
    }
}
