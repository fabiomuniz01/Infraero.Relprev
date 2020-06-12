using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public class Relato : AuditableEntity
    {
        [Key]
        public int CodRelato { get; set; }
        public string NumRelato { get; set; }
        public DateTime DatOcorrencia { get; set; }
        public string HorOcorrencia { get; set; }
        public string DscLocalOcorrenciaRelator { get; set; }
        public string DscEnvolvidosOcorrencia { get; set; }
        public string DscOcorrenciaRelator { get; set; }
        public string NomRelator { get; set; }
        public string EmailRelator { get; set; }
        public string NumTelefoneRelator { get; set; }
        public string NomEmpresaRelator { get; set; }
        public string DscMotivoRelato { get; set; }
        public int FlgStatusRelato { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        [ForeignKey("CodUnidadeInfraestrutura")]
        public UnidadeInfraestrutura UnidadeInfraestrutura { get; set; }
        public int CodLocal { get; set; }
        //[ForeignKey("CodLocal")]
        //public Local Local { get; set; }
        public int CodSubLocal { get; set; }
        //[ForeignKey("CodSubLocal")]
        //public SubLocal SubLocal { get; set; }
        public int CodAssunto { get; set; }
        //[ForeignKey("CodAssunto")]
        //public Assunto Assunto { get; set; }
        public int CodSubAssunto { get; set; }
        //[ForeignKey("CodSubAssunto")]
        //public SubAssunto SubAssunto { get; set; }

        [ForeignKey("CodRelato")]
        public virtual ICollection<RelatoArquivo> ListArquivo { get; set; }
        //[ForeignKey("CodRelato")]
        //public HistoricoRelato HistoricoRelato { get; set; }


    }
}
