using System.Collections.Generic;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class SituacaoRelato : AuditableEntity
    {
        public SituacaoRelato()
        {
            Relato = new HashSet<Relato>();
        }

        public int CodSituacaoRelato { get; set; }
        public string DscSituacaoRelato { get; set; }

        public virtual ICollection<Relato> Relato { get; set; }
    }
}
