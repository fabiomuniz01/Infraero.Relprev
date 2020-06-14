using Infraero.Relprev.Domain.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraero.Relprev.Domain.Entities
{
    public class Assunto : AuditableEntity
    {
        [Key, Column(Order = 0)]
        public int CodAssunto { get; set; }
        [Column(Order = 1)]
        public string DscAssunto { get; set; }

        [ForeignKey("CodAssunto")]
        public ICollection<SubAssunto> SubAssuntoList { get; set; }
    }
}
