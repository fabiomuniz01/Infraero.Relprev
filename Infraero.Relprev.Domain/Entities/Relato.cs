using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class Relato : AuditableEntity
    {
        public Relato()
        {
            AnexoRelato = new HashSet<AnexoRelato>();
            AtribuicaoRelato = new HashSet<AtribuicaoRelato>();
            HistoricoRelato = new HashSet<HistoricoRelato>();
        }

        [Key]
        public int CodRelato { get; set; }
        public int CodSituacaoRelato { get; set; }
        public int? CodLocalidade { get; set; }
        public int? CodAmbiente { get; set; }
        public int? CodSubAmbiente { get; set; }
        public DateTime DatOcorrencia { get; set; }
        public string DscLocalOcorrenciaRelator { get; set; }
        public string DscEnvolvidosOcorrencia { get; set; }
        public string DscOcorrenciaRelator { get; set; }
        public string NomRelator { get; set; }
        public string EmailRelator { get; set; }
        public string NumTelefoneRelator { get; set; }
        public string NomEmpresaRelator { get; set; }
        public DateTime DthRegistro { get; set; }
        public string HorOcorrencia { get; set; }
        public string DscOcorrenciaCorrigida { get; set; }
        public int? CodUsuarioRelator { get; set; }
        public int? CodAssunto { get; set; }
        public int? CodSubAssunto { get; set; }

        public virtual Ambiente CodAmbienteNavigation { get; set; }
        public virtual Assunto CodAssuntoNavigation { get; set; }
        public virtual Localidade CodLocalidadeNavigation { get; set; }
        public virtual SituacaoRelato CodSituacaoRelatoNavigation { get; set; }
        public virtual SubAmbiente CodSubAmbienteNavigation { get; set; }
        public virtual SubAssunto CodSubAssuntoNavigation { get; set; }
        public virtual Usuario CodUsuarioRelatorNavigation { get; set; }
        public virtual ICollection<AnexoRelato> AnexoRelato { get; set; }
        public virtual ICollection<AtribuicaoRelato> AtribuicaoRelato { get; set; }
        public virtual ICollection<HistoricoRelato> HistoricoRelato { get; set; }
    }
}
