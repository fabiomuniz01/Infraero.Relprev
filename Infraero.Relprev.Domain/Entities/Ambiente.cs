using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class Ambiente : AuditableEntity
    {
        public Ambiente()
        {
            Relato = new HashSet<Relato>();
            SubAmbiente = new HashSet<SubAmbiente>();
        }

        [Key]
        public int CodAmbiente { get; set; }
        public string DscAmbiente { get; set; }
        public DateTime DatInicioVigencia { get; set; }
        public DateTime? DatFimVigencia { get; set; }
        public DateTime DthRegistro { get; set; }
        public int CodLocalidade { get; set; }

        public virtual Localidade CodLocalidadeNavigation { get; set; }
        public virtual ICollection<Relato> Relato { get; set; }
        public virtual ICollection<SubAmbiente> SubAmbiente { get; set; }
    }
}
