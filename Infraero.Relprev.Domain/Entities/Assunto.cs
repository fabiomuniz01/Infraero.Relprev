using Infraero.Relprev.Domain.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraero.Relprev.Domain.Entities
{
    public class Assunto : AuditableEntity
    {
        [Key]
        public int CodAssunto { get; set; }
        public string DscAssunto { get; set; }

        [ForeignKey("CodAssunto")]
        public ICollection<SubAssunto> SubAssuntoList { get; set; }
    }
}
