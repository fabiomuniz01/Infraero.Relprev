using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class SituacaoRelato : AuditableEntity
    {
        public SituacaoRelato()
        {
        }

        [Key]
        public int CodSituacaoRelato { get; set; }
        public string DscSituacaoRelato { get; set; }

    }
}
