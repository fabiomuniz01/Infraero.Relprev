using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class TipoEvento : AuditableEntity
    {
        public TipoEvento()
        {
            Evento = new HashSet<Evento>();
        }

        [Key]
        public int TipEvento { get; set; }
        public string DscTipoEvento { get; set; }

        public virtual ICollection<Evento> Evento { get; set; }
    }
}
