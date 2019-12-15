using Infraero.Relprev.Domain.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infraero.Relprev.Domain.Entities
{
    public class Assunto : AuditableEntity
    {
        public Assunto()
        {
            Relato = new HashSet<Relato>();
            SubAssunto = new HashSet<SubAssunto>();
        }

        [Key]
        public int CodAssunto { get; set; }
        public string DscAssunto { get; set; }

        public virtual ICollection<Relato> Relato { get; set; }
        public virtual ICollection<SubAssunto> SubAssunto { get; set; }
    }
}
