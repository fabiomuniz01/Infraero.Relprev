using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class AtribuicaoRelato : AuditableEntity
    {
        public AtribuicaoRelato()
        {
            AnexoRelato = new HashSet<AnexoRelato>();
        }

        [Key]
        public int CodAtribuicaoRelato { get; set; }
        public int CodResponsavelTecnico { get; set; }
        public int CodRelato { get; set; }
        public int? CodSituacaoAtribuicao { get; set; }
        public string DscParecerTecnico { get; set; }
        public int CodUsuarioAtribuidor { get; set; }
        public DateTime DthAtribuicao { get; set; }
        public DateTime? DthFimAtendimento { get; set; }
        public string ObsAtribuicao { get; set; }

        public virtual Relato CodRelatoNavigation { get; set; }
        public virtual ResponsavelTecnico CodResponsavelTecnicoNavigation { get; set; }
        public virtual SituacaoAtribuicaoRelato CodSituacaoAtribuicaoNavigation { get; set; }
        public virtual Usuario CodUsuarioAtribuidorNavigation { get; set; }
        public virtual ICollection<AnexoRelato> AnexoRelato { get; set; }
    }
}
