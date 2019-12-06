using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class SubAmbiente : AuditableEntity
    {
        public SubAmbiente()
        {
            Relato = new HashSet<Relato>();
        }

        [Key]
        public int CodSubAmbiente { get; set; }
        public string DscSubAmbiente { get; set; }
        public DateTime DatInicioVigencia { get; set; }
        public DateTime? DatFimVigencia { get; set; }
        public DateTime DthRegistro { get; set; }
        public int? CodAmbiente { get; set; }

        public virtual Ambiente CodAmbienteNavigation { get; set; }
        public virtual ICollection<Relato> Relato { get; set; }
    }
}
