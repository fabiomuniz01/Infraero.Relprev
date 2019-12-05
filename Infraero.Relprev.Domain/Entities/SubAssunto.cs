using System.Collections.Generic;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class SubAssunto : AuditableEntity
    {
        public SubAssunto()
        {
            Relato = new HashSet<Relato>();
        }

        public int CodSubAssunto { get; set; }
        public string DscSubAssunto { get; set; }
        public int CodAssunto { get; set; }

        public virtual Assunto CodAssuntoNavigation { get; set; }
        public virtual ICollection<Relato> Relato { get; set; }
    }
}
