using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class SituacaoRelato : AuditableEntity
    {
        public SituacaoRelato()
        {
            Relato = new HashSet<Relato>();
        }

        [Key]
        public int CodSituacaoRelato { get; set; }
        public string DscSituacaoRelato { get; set; }

        public virtual ICollection<Relato> Relato { get; set; }
    }
}
