using System.Collections.Generic;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class FuncaoSistema : AuditableEntity
    {
        public FuncaoSistema()
        {
            PerfilFuncao = new HashSet<PerfilFuncao>();
        }

        public int CodFuncao { get; set; }
        public string DscFuncao { get; set; }
        public string FlgVisivel { get; set; }

        public virtual ICollection<PerfilFuncao> PerfilFuncao { get; set; }
    }
}
