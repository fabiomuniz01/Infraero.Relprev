using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public class SubLocal : AuditableEntity
    {
        public SubLocal()
        {
            Relato = new HashSet<Relato>();
        }
        [Key]
        public int CodSubLocal { get; set; }
        public string DscSubLocal { get; set; }
        public int CodLocal { get; set; }

        public virtual Local CodLocalNavigation { get; set; }
        public virtual ICollection<Relato> Relato { get; set; }
    }
}