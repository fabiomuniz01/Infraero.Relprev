using System;
using System.Collections.Generic;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class Assunto : AuditableEntity
    {
        public Assunto()
        {
            Relato = new HashSet<Relato>();
            SubAssunto = new HashSet<SubAssunto>();
        }

        public int CodAssunto { get; set; }
        public string DscAssunto { get; set; }

        public virtual ICollection<Relato> Relato { get; set; }
        public virtual ICollection<SubAssunto> SubAssunto { get; set; }
    }
}
