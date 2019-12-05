using System.Collections.Generic;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class SituacaoAtribuicaoRelato : AuditableEntity
    {
        public SituacaoAtribuicaoRelato()
        {
            AtribuicaoRelato = new HashSet<AtribuicaoRelato>();
        }

        public int CodSituacaoAtribuicao { get; set; }
        public string DscSituacaoAtribuicao { get; set; }

        public virtual ICollection<AtribuicaoRelato> AtribuicaoRelato { get; set; }
    }
}
