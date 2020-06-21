using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class SituacaoAtribuicaoRelato : AuditableEntity
    {
        public SituacaoAtribuicaoRelato()
        {
            AtribuicaoRelato = new HashSet<AtribuicaoRelato>();
        }

        [Key]
        public int CodSituacaoAtribuicao { get; set; }
        public string DscSituacaoAtribuicao { get; set; }

        public virtual ICollection<AtribuicaoRelato> AtribuicaoRelato { get; set; }
    }
}
