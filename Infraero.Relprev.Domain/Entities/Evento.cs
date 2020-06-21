using System;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class Evento : AuditableEntity
    {
        [Key]
        public int CodEvento { get; set; }
        public DateTime DthRegistro { get; set; }
        public string ObsEvento { get; set; }
        public int TipEvento { get; set; }
        public int CodUsuario { get; set; }

        public virtual Usuario CodUsuarioNavigation { get; set; }
        public virtual TipoEvento TipEventoNavigation { get; set; }
    }
}
