using System;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class HistoricoRelato : AuditableEntity
    {
        public int CodHistorico { get; set; }
        public int CodRelato { get; set; }
        public int? CodUsuario { get; set; }
        public DateTime DthRegistro { get; set; }
        public string DscHistorico { get; set; }

        public virtual Relato CodRelatoNavigation { get; set; }
        public virtual Usuario CodUsuarioNavigation { get; set; }
    }
}
