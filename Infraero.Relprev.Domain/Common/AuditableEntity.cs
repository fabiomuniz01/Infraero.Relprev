using System;

namespace Infraero.Relprev.Domain.Common
{
    public class AuditableEntity
    {
        public string CriadoPor { get; set; }

        public DateTime DataCriacao { get; set; }

        public string AlteradoPor { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public bool FlagAtivo { get; set; }
    }
}
