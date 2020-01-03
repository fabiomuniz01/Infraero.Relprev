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
        public DateTime DatOcorrencia { get; set; }
        public String HorOcorrencia { get; set; }
        public string DscLocalOcorrenciaRelator { get; set; }
        public string DscEnvolvidosOcorrencia { get; set; }
        public string DscOcorrenciaRelator { get; set; }
        public string NomRelator { get; set; }
        public string EmailRelator { get; set; }
        public string NumTelefoneRelator { get; set; }
        public string NomEmpresaRelator { get; set; }
        public string DscRelato { get; set; }

        [ForeignKey("CodRelato")]
        public virtual ICollection<RelatoArquivo> Arquivos { get; set; }
    }
}
